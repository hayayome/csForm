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
    public partial class sign_up : Form
    {
        const string idHolder = "아이디";
        const string pwHolder = "비밀번호";
        const string pwConfirmHolder = "비밀번호 확인";
        const string nickHolder = "닉네임";
        TextBox[] txtList;

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text == idHolder | txt.Text == pwHolder | txt.Text == pwConfirmHolder | txt.Text == nickHolder)
            {
                txt.ForeColor = Color.Black;
                txt.Text = string.Empty;
                if (txt == txtPw) txtPw.PasswordChar = '●';
                if (txt == txtPw2) txtPw2.PasswordChar = '●';
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
                else if (txt == txtPw2) { txt.Text = pwConfirmHolder; txtPw2.PasswordChar = default; }
                else if (txt == txtNick) txt.Text = nickHolder;
            }
        }

        public sign_up()
        {
            InitializeComponent();

            txtList = new TextBox[] { txtId, txtPw, txtPw2, txtNick };
            foreach (var txt in txtList)
            {
                //처음 공백 Placeholder 지정
                txt.ForeColor = Color.DarkGray;
                if (txt == txtId) txt.Text = idHolder;
                else if (txt == txtPw) txt.Text = pwHolder;
                else if (txt == txtPw2) txt.Text = pwConfirmHolder;
                else if (txt == txtNick) txt.Text = nickHolder;
                //텍스트박스 커서 Focus 여부에 따라 이벤트 지정
                txt.GotFocus += RemovePlaceholder;
                txt.LostFocus += SetPlaceholder;
            }
        }

        private void resetText()
        {
            txtId.Text = "";
            txtPw.Text = "";
            txtPw2.Text = "";
            txtNick.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userID = txtId.Text;
            string userPW = txtPw.Text;
            string userPW2 = txtPw2.Text;
            string userNICK = txtNick.Text;



            if (userID == idHolder || userID == "")
            {
                MessageBox.Show("아이디를 입력해주세요.");
                resetText();
            }
            else if (userPW == pwHolder || userPW == "")
            {
                MessageBox.Show("비밀번호를 입력해주세요.");
                resetText();
            }
            else if (!userPW.Equals(userPW2))
            {
                MessageBox.Show("비밀번호가 다릅니다.");
                resetText();
            }
            else if (userNICK == nickHolder || userNICK == "")
            {
                MessageBox.Show("닉네임을 입력해주세요.");
                resetText();
            }
            else {
                MessageBox.Show("회원가입을 성공하였습니다.");
                this.Close();
            }
                            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sign_up_KeyDown(object sender, KeyEventArgs e)
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
    }
}

