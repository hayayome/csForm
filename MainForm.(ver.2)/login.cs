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
    public partial class login : Form
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



        public login()
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
                add_song f7 = new add_song();
                f7.Show();
            } else if (userid.Equals("user") && userpw.Equals("1234"))
                {
                    MessageBox.Show("로그인에 성공했습니다.", "로그인");
                    main f2 = new main();
                    f2.Show();
                    this.Hide();
            }
                else
                {
                    txtId.Text = "";
                    txtPw.Text = "";
                    MessageBox.Show("아이디/비밀번호가 맞지 않습니다.");
                
                }
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            sign_up f6 = new sign_up();
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

        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, e);
        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, e);
        }

        private void txtPw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, e);
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
    }
