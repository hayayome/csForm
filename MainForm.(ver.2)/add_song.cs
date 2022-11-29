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
    public partial class add_song : Form
    {
        public add_song()
        {
            InitializeComponent();
        }

        private void DAOpenBtn_Click(object sender, EventArgs e)
        {
           /* try
            {
                 dbc.DS.Clear();
                 dbc.DBAdapter.Fill(dbc.DS, "phone");
                 DBGrid.DataSource = dbc.DS.Tables["phone"].DefaultView;
             }
             catch (DataException DE)
             {
                 MessageBox.Show(DE.Message);
             }
             catch (Exception DE)
             {
                 MessageBox.Show(DE.Message);
            }*/
        }

        private void add_song_Load(object sender, EventArgs e)
        {

        }

        private void 추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            add_song_detail detail = new add_song_detail();
            detail.ShowDialog();


            try
            {
                /*     dbc.PhoneTable = dbc.DS.Tables["Phone"];
                       DataRow newRow = dbc.PhoneTable.NewRow();
                       newRow["id"] = Convert.ToInt32(txtnumber.Text);
                       newRow["PName"] = txtName.Text;
                       newRow["Phone"] = txttitle.Text;

                       dbc.PhoneTable.Rows.Add(newRow);
                       dbc.DBAdapter.Update(dbc.DS, "Phone");
                       dbc.DS.AcceptChanges();
                       ClearTextBoxes(); 
                       DBGrid.DataSource = dbc.DS.Tables["Phone"].DefaultView; */
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

        private void 수정ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            add_song_detail detail = new add_song_detail();
            detail.ShowDialog();
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

        private void 삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            add_song_detail detail = new add_song_detail();
            detail.ShowDialog();
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

        private void add_song_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
