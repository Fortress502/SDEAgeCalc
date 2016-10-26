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
            double daysAlive;
            DateTime timestamp = DateTime.Now;
            name = textBox1.Text.ToString();
            dateOfBirth = textBox2.Text.ToString();

            DateTime dt = Convert.ToDateTime(dateOfBirth);


            daysAlive = Math.Floor((DateTime.Now - dt).TotalDays);

            string dbtimestamp = DateTime.Now.ToString("yyyy-MM-dd h:mm tt");

            //Method to Add Calculation into the Database
            AddCalc ac = new AddCalc();
            ac.InsertIntoTable(name, dateOfBirth, daysAlive, dbtimestamp);

            textBox3.Text = (daysAlive.ToString());

            MessageBox.Show("Calculation added successfully.");
        
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
