using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace MainForm
{
    public partial class add_song_detail : Form
    {
        private OracleConnection odpConn = new OracleConnection();
        add_song _parent;

        public add_song_detail (add_song inform1)
        {
            InitializeComponent();
            _parent = inform1;
        }
        private void txtnum_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void ClearTextBoxes()
        {
            txtnum.Clear();
            txtname.Clear();
            txttitle.Clear();
            txtagency.Clear();
        }
        private void initialTextBoxes()//사용자 함수 정의
        {
            odpConn.ConnectionString = "User Id=scott; Password=tiger; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";
            int getID = _parent.getintID;
            odpConn.Open();
            string strqry = "SELECT * FROM singer WHERE singernum=" + getID;

            OracleCommand OraCmd = new OracleCommand(strqry, odpConn);
            OracleDataReader odr = OraCmd.ExecuteReader();
            while (odr.Read())
            {
                txtnum.Text = Convert.ToString(odr.GetValue(0));
                txtname.Text = Convert.ToString(odr.GetValue(1));
                txttitle.Text = Convert.ToString(odr.GetValue(2));
                txtagency.Text = Convert.ToString(odr.GetValue(3));
            }
            odr.Close();
            odpConn.Close();
        }

        private void add_song_detail_Load(object sender, EventArgs e)
        {
            if (_parent.getstrCommand == "삭제")
            {
                btnOK.Text = "삭제";
                txtnum.Enabled = false;
                initialTextBoxes();
            }
            else if (_parent.getstrCommand == "수정")
            {
                btnOK.Text = "수정";
                txtnum.Enabled = false;
                txtname.Enabled = false;
                initialTextBoxes();
            }
            else btnOK.Text = "추가";
        }

        private int INSERTRow()//사용자 함수 정의
        {
            odpConn.ConnectionString = "User Id=scott; Password=tiger; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";
            odpConn.Open();
            int inid = Convert.ToInt32(txtnum.Text.Trim()); //**
            String inName = txtname.Text.Trim(); //**
            String inPhone = txttitle.Text.Trim(); //**
            String inMail = txtagency.Text.Trim(); //**
            string strqry = "INSERT INTO singer VALUES ('" + inid + "', '" + inName + "', '" + inPhone + "', '" + inMail + "')";
            //"INSERT INTO phone VALUES (id, pname, phone, email)"을 수정
            OracleCommand OraCmd = new OracleCommand(strqry, odpConn);
            return OraCmd.ExecuteNonQuery(); //추가되는 행수 반환
        }
        private int UPDATERow() //사용자 함수 정의
        {
            odpConn.ConnectionString = "User Id=scott; Password=tiger; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";
            odpConn.Open();
            String inName = txtname.Text.Trim(); //**
            String intitle = txttitle.Text.Trim(); //**
            String inagency = txtagency.Text.Trim(); //**
            string strqry = "UPDATE Singer SET Singer='" + intitle + "', email = '" + inagency + "' WHERE id = " + inName;
            OracleCommand OraCmd = new OracleCommand(strqry, odpConn);
            return OraCmd.ExecuteNonQuery(); //업데이트되는 행수 반환
        }
        private int DELETERow() //사용자 함수 정의
        {
            odpConn.ConnectionString = "User Id=scott; Password=tiger; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";
            odpConn.Open();
            int getID = _parent.getintID; //**
            string strqry = "DELETE FROM Singer WHERE singernum = '" + getID + "'";
            OracleCommand OraCmd = new OracleCommand(strqry, odpConn);
            return OraCmd.ExecuteNonQuery();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (btnOK.Text == "추가")
            {
                if (INSERTRow() > 0)
                {
                    MessageBox.Show("정상적으로 데이터 행이 추가됨.");
                }
                else MessageBox.Show("데이터 행이 추가되지 않음!");
                this.Close();
            }
            else if (btnOK.Text == "삭제")
            {
                if (DELETERow() > 0)
                {
                    MessageBox.Show("정상적으로 데이터 행이 삭제됨!");
                }
                else MessageBox.Show("데이터 행이 삭제되지 않음!");
                this.Close();
            }
            else
            {
                if (UPDATERow() > 0)
                {
                    MessageBox.Show("정상적으로 데이터가 업데이트됨!");
                }
                else MessageBox.Show("데이터 행이 업데이트되지 않음!");
                this.Close();
            }
        }
    }
}
