using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
           /* try
            {
                 dbc.DS.Clear();
                 dbc.DBAdapter.Fill(dbc.DS, "phone");
                 DBGrid.DataSource = dbc.DS.Tables["phone"].DefaultView;
             }
             catch (DataException DE)
             {
                 MessageBox.Show(DE.Message);
             }
             catch (Exception DE)
             {
                 MessageBox.Show(DE.Message);
            }*/
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
