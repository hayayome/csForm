using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
namespace MainForm
{
    public partial class make_playlist : Form
    {
        public make_playlist()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            save_playlist f4 = new save_playlist();
            f4.Show();
        }

        private void SearchOpenBtn_Click(object sender, EventArgs e)
        {
            String singername = this.txttitle.Text;
            string ConStr = "User Id=scott; Password=tiger; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";
            OracleConnection conn = new OracleConnection(ConStr);
            conn.Open();
            OracleDataAdapter DBAdapter = new OracleDataAdapter();
            DBAdapter.SelectCommand = new OracleCommand
            ("select * from singer where singernum = singernum ", conn);
            DBAdapter.SelectCommand.Parameters.Add("singernum", OracleDbType.Varchar2, 20);
            DataSet DS = new DataSet();
            DBAdapter.Fill(DS, "singer");
            DataTable phoneTable = DS.Tables["singer"];
            DBGrid1.DataSource = phoneTable;
        }

        private void Btnadd_Click(object sender, EventArgs e)
        {

        }

        private void PlayListOpenBtn_Click(object sender, EventArgs e)
        {
            String singername = this.txttitle.Text;
            String comboBox1 = this.DBGrid1.Text;
            string ConStr = "User Id=scott; Password=tiger; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";
            OracleConnection conn = new OracleConnection(ConStr);
            conn.Open();
            OracleDataAdapter DBAdapter = new OracleDataAdapter();
            DBAdapter.SelectCommand = new OracleCommand
            ("select * from SINGER where singername = '" + singername + "'", conn);
            DBAdapter.SelectCommand.Parameters.Add("name", OracleDbType.Varchar2, 20);
            DataSet DS = new DataSet();
            DBAdapter.Fill(DS, "Singer");
            DataTable phoneTable = DS.Tables["Singer"];
            DBGrid2.DataSource = phoneTable;
        }

        private void search_Click(object sender, EventArgs e)
        {

        }

        private void make_playlist_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DBGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txttitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }