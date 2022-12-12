using Oracle.DataAccess.Client;
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
    public partial class withdraw : Form
    {
        private OracleConnection odpConn = new OracleConnection();
        const string idHolder = "아이디";
        TextBox[] txtList;
        public withdraw()
        {
            InitializeComponent();
        }
        private void SetPlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.ForeColor = Color.DarkGray;
            }
        }
        private void btnwithdraw_Click(object sender, EventArgs e)
        {
            odpConn.ConnectionString = "User Id=system; Password=system; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";
            odpConn.Open();
            String getID = textBox1.Text.Trim();
            string strqry = "DELETE FROM user_user WHERE userid = '" + getID + "'";
            OracleCommand OraCmd = new OracleCommand(strqry, odpConn);
            OraCmd.ExecuteNonQuery();
            MessageBox.Show("회원탈퇴를 성공했습니다. 이용해주셔서 감사합니다.");
            this.Hide();
            login login = new login();
            login.Show();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            main f2 = new main();
            f2.Show();
            this.Hide();
        }
    }
}
