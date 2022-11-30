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
    public partial class save_playlist : Form
    {
        public save_playlist()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("제목을 입력하세요.");
            }
            else
            {
                if (MessageBox.Show("저장하시겠습니까?", "저장", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("저장이 완료되었습니다.");
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void save_playlist_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, e);
        }
    }
}
