using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LifestyleeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();
            this.Hide();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            form3.Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {


            MessageBox.Show("This Application was created by Ayanda Mthombeni in 2023", "About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
