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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            make_playlist f3 = new make_playlist();
            f3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            playlist f5 = new playlist();
            f5.ShowDialog();
        }
    }
}
