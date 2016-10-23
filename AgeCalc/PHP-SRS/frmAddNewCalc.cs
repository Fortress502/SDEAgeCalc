using System;
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
    public partial class frmAddNewCalc : Form
    {
        public frmAddNewCalc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name;
            string dateOfBirth;
            string daysAlive = "500";
            DateTime timestamp = DateTime.Now;
            name = textBox1.Text.ToString();
            dateOfBirth = textBox2.Text.ToString();


            //Method to Add Calculation into the Database
            AddCalc ac = new AddCalc();
            ac.InsertIntoTable(name, dateOfBirth, timestamp);

            // MessageShow
            MessageBox.Show("Calculation added successfully.");

            textBox3.Text = daysAlive;

        
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmAddNewCalc_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
