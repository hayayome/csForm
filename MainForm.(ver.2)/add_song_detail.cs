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
    public partial class add_song_detail : Form
    {
        DBClass dbc = new DBClass();
        public add_song_detail(String txt)
        {
            InitializeComponent();
            this.button.Text = txt;
        }


        private void txtnum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button_Click(sender, e);
        }
        private void ClearTextBoxes()
        {

            txtnum.Clear();
            txtname.Clear();
            txttitle.Clear();
            txtagency.Clear();
        }
        private void button_Click(object sender, EventArgs e)
        {
            if (this.button.Text.Equals("추가"))
            {
                try
                {
                    dbc.PhoneTable = dbc.DS.Tables["musicinfo"];
                    DataRow newRow = dbc.PhoneTable.NewRow();
                    newRow["id"] = Convert.ToInt32(txtnum.Text);
                    newRow["name"] = txtname.Text;
                    newRow["musictitle"] = txttitle.Text;
                    newRow["agency"] = txtagency.Text;

                    dbc.PhoneTable.Rows.Add(newRow);
                    dbc.DBAdapter.Update(dbc.DS, "musicinfo");
                    dbc.DS.AcceptChanges();
                    ClearTextBoxes();
                }
                catch (DataException DE)
                {
                    MessageBox.Show(DE.Message);
                }
                catch (Exception DE)
                {
                    MessageBox.Show(DE.Message);
                }
            }
            else if (this.button.Text.Equals("삭제"))
            {
                try
                {
                    /*              dbc.PhoneTable = dbc.DS.Tables["Phone"];//*
                                    DataColumn[] PrimaryKey = new DataColumn[1];
                                    PrimaryKey[0] = dbc.PhoneTable.Columns["id"];
                                    dbc.PhoneTable.PrimaryKey = PrimaryKey;

                                    DataRow currRow = dbc.PhoneTable.Rows.Find(dbc.SelectedRowIndex);
                                    currRow.Delete();

                                    dbc.DBAdapter.Update(dbc.DS.GetChanges(DataRowState.Deleted), "Phone");
                                    DBGrid.DataSource = dbc.DS.Tables["Phone"].DefaultView;*/
                }
                catch (DataException DE)
                {
                    MessageBox.Show(DE.Message);
                }
                catch (Exception DE)
                {
                    MessageBox.Show(DE.Message);
                }
            }
            else if (this.button.Text.Equals("수정"))
            {
                try
                {
                    /*    dbc.PhoneTable = dbc.DS.Tables["Phone"];//*
                        DataColumn[] PrimaryKey = new DataColumn[1];
                        PrimaryKey[0] = dbc.PhoneTable.Columns["id"];
                        dbc.PhoneTable.PrimaryKey = PrimaryKey;

                        DataRow currRow = dbc.PhoneTable.Rows.Find(dbc.SelectedRowIndex);


                        currRow.BeginEdit();
                        currRow["id"] = txtnumber.Text;
                        currRow["PName"] = txtName.Text;
                        currRow["Phone"] = txttitle.Text;
                        currRow.EndEdit();

                        DataSet UpdatedSet = dbc.DS.GetChanges(DataRowState.Modified);
                        if (UpdatedSet.HasErrors)
                        {
                            MessageBox.Show("변경된 데이터에 문제가 있습니다.");
                        }
                        else
                        {
                            dbc.DBAdapter.Update(UpdatedSet, "Phone");
                            dbc.DS.AcceptChanges();
                        }

                        DBGrid.DataSource = dbc.DS.Tables["Phone"].DefaultView;
                    */
                }
                catch (DataException DE)
                {
                    MessageBox.Show(DE.Message);
                }
                catch (Exception DE)
                {
                    MessageBox.Show(DE.Message);
                }
            }

        }

        private void add_song_detail_Load(object sender, EventArgs e)
        {

        }
    }
}
