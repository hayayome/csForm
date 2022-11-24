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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String userid = textBox1.Text;
            String userpw = textBox2.Text;
            String userpw1 = textBox3.Text;
            String nickName = textBox4.Text;

            if (userid == "")
            {
                MessageBox.Show("아이디를 입력해주세요.");
            }
            else if (userpw == "")
            {
                MessageBox.Show("비밀번호를 입력해주세요.");
            }
            else if (userpw != userpw1)
            {
                MessageBox.Show("비밀번호가 다릅니다.");
            }
            else if (nickName == "")
            {
                MessageBox.Show("닉네임을 입력해주세요.");
            }
            else if (userid != "")
            {
                if (userpw1 == userpw)
                {
                    if (userpw != "")
                    {
                        if (nickName != "")
                        {
                            MessageBox.Show("회원가입을 성공하였습니다.");
                            this.Close();
                        }
                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}

