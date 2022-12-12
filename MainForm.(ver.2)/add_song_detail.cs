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
            txttitle.Clear();
            txtyear.Clear();
            txtgenre.Clear();
        }
        private void initialTextBoxes()
        {
            odpConn.ConnectionString = "User Id=system; Password=system; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";
            int getID = _parent.getintIDe;
            odpConn.Open();
            string strqry = "SELECT * FROM song WHERE songnum =" + getID;

            OracleCommand OraCmd = new OracleCommand(strqry, odpConn);
            OracleDataReader odr = OraCmd.ExecuteReader();
            while (odr.Read())
            {
                txtnum.Text = Convert.ToString(odr.GetValue(0));
                txttitle.Text = Convert.ToString(odr.GetValue(1));
                txtyear.Text = Convert.ToString(odr.GetValue(2));
                txtgenre.Text = Convert.ToString(odr.GetValue(3));
                txtsingernum.Text = Convert.ToString(odr.GetValue(4));
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
                txttitle.Enabled = false;
                initialTextBoxes();
            }
            else btnOK.Text = "추가";
        }

        private int INSERTRow()
        {
            odpConn.ConnectionString = "User Id=system; Password=system; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";
            odpConn.Open();
            int innum = Convert.ToInt32(txtnum.Text.Trim());
            String intitle = txttitle.Text.Trim();
            String inyear = txtyear.Text.Trim(); 
            String ingenre = txtgenre.Text.Trim();
            String inname = txtsingernum.Text.Trim();
            string strqry = "INSERT INTO song VALUES ('" + innum + "', '" + intitle + "', '" + inyear + "', '" + ingenre + "','" + inname + "')";
            OracleCommand OraCmd = new OracleCommand(strqry, odpConn);
            return OraCmd.ExecuteNonQuery();
        }
        private int UPDATERow()
        {
            odpConn.ConnectionString = "User Id=system; Password=system; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";
            odpConn.Open();
            int innum = Convert.ToInt32(txtnum.Text.Trim());
            String intitle = txttitle.Text.Trim();
            String inyear = txtyear.Text.Trim();
            String ingenre = txtgenre.Text.Trim();
            String inname = txtsingernum.Text.Trim();
            string strqry = "UPDATE song SET songname = '" + intitle + "', songyear = '" + inyear + "', genre = '" + ingenre + "', singernm = '" + inname + "' WHERE songnum = " + innum;
            OracleCommand OraCmd = new OracleCommand(strqry, odpConn);
            return OraCmd.ExecuteNonQuery();
        }
        private int DELETERow()
        {
            odpConn.ConnectionString = "User Id=system; Password=system; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";
            odpConn.Open();
            int getIDe = _parent.getintIDe;
            string strqry = "DELETE FROM song WHERE songnum = '" + getIDe + "'";
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
