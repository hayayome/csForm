﻿using System;
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
    public partial class make_playlist : Form
    {
        public make_playlist()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            save_playlist f4 = new save_playlist();
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

        }

        private void PlayListOpenBtn_Click(object sender, EventArgs e)
        {

            }

        private void search_Click(object sender, EventArgs e)
        {

        }

        private void make_playlist_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
    }