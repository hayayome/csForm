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
            panelSet(f3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            playlist f5 = new playlist();
            panelSet(f5);
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            login login = new login();
            login.Show();
        }

        private void panelSet(Form form)

        {
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            panel1.Controls.Clear();
            form.TopLevel = false;
            panel1.Controls.Add(form);
            form.Show();
            form.Dock = DockStyle.Fill;
        }



    }
}
