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
        private int intID;
        private string strCommand;

        private OracleConnection odpConn = new

        OracleConnection();

        public int getintID
        { get { return intID; } }
        public string getstrCommand
        { get { return strCommand; } }

        public make_playlist()
        {
            InitializeComponent();
            CBB1.SelectedIndex = 0;
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            save_playlist f4 = new save_playlist();
            f4.Show();
        }

        private void SearchOpenBtn_Click(object sender, EventArgs e)
        {
            String singername = this.txttitle.Text;
            string ConStr = "User Id=system; Password=system; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";
            OracleConnection conn = new OracleConnection(ConStr);
            conn.Open();
            OracleDataAdapter DBAdapter = new OracleDataAdapter();
            DBAdapter.SelectCommand = new OracleCommand
            ("select * from song where songnum = songnum ", conn);
            DBAdapter.SelectCommand.Parameters.Add("songnum", OracleDbType.Varchar2, 20);
            DataSet DS = new DataSet();
            DBAdapter.Fill(DS, "song");
            DataTable phoneTable = DS.Tables["song"];
            DBGrid1.DataSource = phoneTable;
        }

        private void Btnadd_Click(object sender, EventArgs e)
        {

        }

        private void PlayListOpenBtn_Click(object sender, EventArgs e)
        {
            string ConStr = "User Id=system; Password=system; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";
            OracleConnection conn = new OracleConnection(ConStr);
            conn.Open();
            OracleDataAdapter DBAdapter = new OracleDataAdapter();
            DBAdapter.SelectCommand = new OracleCommand
            ("select * from songsave where snumber = snumber", conn);
            DBAdapter.SelectCommand.Parameters.Add("songsave", OracleDbType.Varchar2, 20);
            DataSet DS = new DataSet();
            DBAdapter.Fill(DS, "songsave");
            DataTable phoneTable = DS.Tables["songsave"];
            DBGrid2.DataSource = phoneTable;
        }

        private void search_Click(object sender, EventArgs e)
        {
            String inCBB = CBB1.SelectedItem.ToString();
            String intxt = txttitle.Text.Trim();
            string ConStr = "User Id=system; Password=system; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";
            OracleConnection conn = new OracleConnection(ConStr); //192.168.142.10
            conn.Open();
            OracleDataAdapter DBAdapter = new OracleDataAdapter();
            DBAdapter.SelectCommand = new OracleCommand
            ("select * from song where'" +inCBB+"'Like'%"+ intxt+"%'" , conn);
            DBAdapter.SelectCommand.Parameters.Add("song", OracleDbType.Varchar2, 20);
            DataSet DS = new DataSet();
            DBAdapter.Fill(DS, "song");
            DataTable songTable = DS.Tables["song"];
            DBGrid1.DataSource = songTable;
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
            try
            {
                odpConn.ConnectionString = "User Id=system; Password=system; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";
                odpConn.Open();
                OracleDataAdapter oda = new OracleDataAdapter();
                oda.SelectCommand = new
                OracleCommand("SELECT * from song", odpConn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                odpConn.Close();
                DBGrid1.DataSource = dt;
                DBGrid1.AutoResizeColumns();
                DBGrid1.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
                DBGrid1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
                DBGrid1.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("에러 발생 : " + ex.ToString());
                odpConn.Close();
            }
        }

        private void txttitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }