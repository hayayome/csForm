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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            txttitle.Clear();
            txtname.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void SearchOpenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                /*dbc.DS.Clear();
                dbc.DBAdapter.Fill(dbc.DS, "phone");
                DBGrid.DataSource = dbc.DS.Tables["phone"].DefaultView;*/
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

        private void Btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                /*dbc.PhoneTable = dbc.DS.Tables["Phone"];
                DataRow newRow = dbc.PhoneTable.NewRow();
                newRow["id"] = Convert.ToInt32(txtid.Text);
                newRow["PName"] = txtName.Text;
                newRow["Phone"] = txtPhone.Text;
                newRow["Email"] = txtMail.Text;

                dbc.PhoneTable.Rows.Add(newRow);
                dbc.DBAdapter.Update(dbc.DS, "Phone");
                dbc.DS.AcceptChanges();
                ClearTextBoxes();
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

        private void PlayListOpenBtn_Click(object sender, EventArgs e)
        {
          /*  try
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
                MessageBox.Show(DE.Message);*/
            }

        private void search_Click(object sender, EventArgs e)
        {

        }
    }
    }