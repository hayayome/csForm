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
    public partial class Form1 : Form
    {
        const string idHolder = "아이디";
        const string pwHolder = "비밀번호";
        TextBox[] txtList;

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text == idHolder | txt.Text == pwHolder)
            {
                txt.ForeColor = Color.Black;
                txt.Text = string.Empty;
                if (txt == txtPw) txtPw.PasswordChar = '●';
            }
        }



        private void SetPlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.ForeColor = Color.DarkGray;
                if (txt == txtId) txt.Text = idHolder;
                else if (txt == txtPw) { txt.Text = pwHolder; txtPw.PasswordChar = default; }
            }
        }



        public Form1()
        {
            InitializeComponent();

            txtList = new TextBox[] { txtId, txtPw};
            foreach (var txt in txtList)
            {
                //처음 공백 Placeholder 지정
                txt.ForeColor = Color.DarkGray;
                if (txt == txtId) txt.Text = idHolder;
                else if (txt == txtPw) txt.Text = pwHolder;
                //텍스트박스 커서 Focus 여부에 따라 이벤트 지정
                txt.GotFocus += RemovePlaceholder;
                txt.LostFocus += SetPlaceholder;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String userid = txtId.Text;
            String userpw = txtPw.Text;

            if (userid.Equals("admin") && userpw.Equals("1234"))
            {
                MessageBox.Show("관리자 로그인을 성공했습니다.", "로그인");
                this.Visible = false;
                Form7 f7 = new Form7();
                f7.Show();
            } else if (userid.Equals("user") && userpw.Equals("1234"))
                {
                    MessageBox.Show("로그인에 성공했습니다.", "로그인");
                    this.Visible = false;
                    Form2 f2 = new Form2();
                    f2.Show();
                }
                else
                {
                    MessageBox.Show("아이디/비밀번호가 맞지 않습니다.");

                }
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            find_pw find_pw = new find_pw();
            find_pw.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    }
