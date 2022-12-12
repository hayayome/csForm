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
    public partial class add_song : Form
    {
        private int intID;
        private string strCommand;

        private OracleConnection odpConn = new

        OracleConnection();
        public int getintIDe
        { get { return intID; } }
        public string getstrCommand
        { get { return strCommand; } }

        private void DAOpenBtn_Click(object sender, EventArgs e)
        {
            string ConStr = "User Id=system; Password=system; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";
            OracleConnection conn = new OracleConnection(ConStr); //192.168.142.10
            conn.Open();
            OracleDataAdapter DBAdapter = new OracleDataAdapter();
            DBAdapter.SelectCommand = new OracleCommand
            ("select * from song where songnum = songnum ", conn);
            DBAdapter.SelectCommand.Parameters.Add("song", OracleDbType.Varchar2, 20);
            DataSet DS = new DataSet();
            DBAdapter.Fill(DS, "song");
            DataTable songTable = DS.Tables["song"];
            DBGrid.DataSource = songTable;
        }

        private void add_song_Load(object sender, EventArgs e)
        {
            showDataGridView();
        }

        private void 추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strCommand = "추가";
            add_song_detail form2 = new add_song_detail(this);
            form2.ShowDialog();
            form2.Dispose();
            showDataGridView();
        }

        private void 수정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strCommand = "수정";
            intID = Convert.ToInt32(DBGrid.SelectedCells[0].Value);
            add_song_detail form2 = new add_song_detail(this);
            form2.ShowDialog();
            form2.Dispose();
            showDataGridView();
        }

        private void 삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strCommand = "삭제";
            intID = Convert.ToInt32(DBGrid.SelectedCells[0].Value);
            add_song_detail form2 = new add_song_detail(this);
            form2.ShowDialog();
            form2.Dispose();
            showDataGridView();
        }

        private void add_song_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void showDataGridView() //사용자 정의 함수
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
                DBGrid.DataSource = dt;
                DBGrid.AutoResizeColumns();
                DBGrid.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
                DBGrid.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
                DBGrid.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("에러 발생 : " + ex.ToString());
                odpConn.Close();
            }
        }
        public add_song()
        {
            InitializeComponent();
        }
        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.Show();
        }
    }
}
