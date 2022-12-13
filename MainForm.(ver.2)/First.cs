using Oracle.DataAccess.Client;
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
    public partial class First : Form
    {
        private int intID;
        private string strCommand;

        private OracleConnection odpConn = new OracleConnection();
        public int getintIDe
        { get { return intID; } }
        public string getstrCommand
        { get { return strCommand; } }
        public First()
        {
            InitializeComponent();
        }

        private void First_Load(object sender, EventArgs e)
        {
            showDataGridView();
        }
        private void showDataGridView() //사용자 정의 함수
        {
            try
            {
                odpConn.ConnectionString = "User Id=system; Password=system; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";
                odpConn.Open();
                OracleDataAdapter oda = new OracleDataAdapter();
                oda.SelectCommand = new
                OracleCommand("SELECT * from song order by songnum DESC", odpConn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                odpConn.Close();
                DBGridV.DataSource = dt;
                DBGridV.AutoResizeColumns();
                DBGridV.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
                DBGridV.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
                DBGridV.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("에러 발생 : " + ex.ToString());
                odpConn.Close();
            }
        }
    }
}
