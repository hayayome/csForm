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
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String userid = textBox1.Text;
            String userpw = textBox2.Text;

            if (userid.Equals("admin") && userpw.Equals("1234"))
            {
                MessageBox.Show("관리자 로그인을 성공했습니다.", "로그인");
                Form7 f7 = new Form7();
                f7.Show();
            } else if (userid.Equals("user") && userpw.Equals("1234"))
                {
                    MessageBox.Show("로그인에 성공했습니다.", "로그인");
                    Form2 f2 = new Form2();
                    f2.Show();
                }
                else
                {
                    MessageBox.Show("아이디/비밀번호가 맞지 않습니다.");

                }
            }

        }
    }
