﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeCalc
{
    public partial class frmCalcHistory : Form
    {
        public frmCalcHistory()
        {
            InitializeComponent();
            History st = new History();
            st.SelectFromTable("SELECT * FROM martiancalctable", dataGridSales);
        }

        private void dataGridSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Close();
        }
    }
}
