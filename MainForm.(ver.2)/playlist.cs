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
    public partial class playlist : Form
    {
        public playlist()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            make_playlist f3 = new make_playlist();
            f3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                /*dbc.DS.Clear();
                dbc.DBAdapter.Fill(dbc.DS, "phone");
                DBGrid.DataSource = dbc.DS.Tables["phone"].DefaultView;
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);*/
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
    }