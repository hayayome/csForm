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
        public add_song()
        {
            InitializeComponent();
        }

        private void DAOpenBtn_Click(object sender, EventArgs e)
        {
            string ConStr = "User Id=root; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";
            OracleConnection conn = new OracleConnection(ConStr);
            conn.Open();
            OracleDataAdapter DBAdapter = new OracleDataAdapter();
            DBAdapter.SelectCommand = new OracleCommand
            ("select * from musicinfo where name =:name ", conn);
            DBAdapter.SelectCommand.Parameters.Add("name", OracleDbType.Varchar2, 20);
            DataSet DS = new DataSet();
            DBAdapter.Fill(DS, "musicinfo");
            DataTable phoneTable = DS.Tables["musicinfo"];
            DBGrid1.DataSource = phoneTable;
        }

        private void add_song_Load(object sender, EventArgs e)
        {

        }

        private void 추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_song_detail detail = new add_song_detail("추가");
            detail.ShowDialog();
        }

        private void 수정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_song_detail detail = new add_song_detail("수정");
            detail.ShowDialog();
        }

        private void 삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_song_detail detail = new add_song_detail("삭제");
            detail.ShowDialog();
        }

        private void add_song_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
