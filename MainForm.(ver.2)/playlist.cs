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
    public partial class playlist : Form
    {
        public playlist()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConStr = "User Id=root; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";
            OracleConnection conn = new OracleConnection(ConStr);
            conn.Open();
            OracleDataAdapter DBAdapter = new OracleDataAdapter();
            DBAdapter.SelectCommand = new OracleCommand
            ("select * from playlist where name =:name ", conn);
            DBAdapter.SelectCommand.Parameters.Add("name", OracleDbType.Varchar2, 20);
            DataSet DS = new DataSet();
            DBAdapter.Fill(DS, "playlist");
            DataTable phoneTable = DS.Tables["playlist"];
            DBGrid1.DataSource = phoneTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
    }
