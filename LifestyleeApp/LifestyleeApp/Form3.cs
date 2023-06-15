using System;
using System.CodeDom;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            Form1 form1 = new Form1();

            form1.Show();
            this.Hide();




        }

        private void Form3_Shown(object sender, EventArgs e)
        {







            string comm = "datasource=127.0.0.1;port=3306;username=root;password=;database=ayandafirst";


            MySqlConnection conn = new MySqlConnection(comm);







            try
            {

                conn.Open();
                string query = "SELECT COUNT(*) FROM lifesytle";                // string query1 = "Select * from lifesytle";
                MySqlCommand commandDatabase = new MySqlCommand(query, conn);


                var myreader = commandDatabase.ExecuteScalar();

                string numberofrows=myreader.ToString();
                string query1 = "SELECT AVG(Age) FROM lifesytle";
                string query2 = "SELECT MAX(Age) FROM lifesytle";
                string query3 = "SELECT MIN(Age) FROM lifesytle";
                string query4 = "SELECT COUNT(*) FROM lifesytle where favoriteFoods LIKE '%Pizza%'";
                string query5 = "SELECT COUNT(*) FROM lifesytle where favoriteFoods LIKE '%Pasta%'";
                string query6 = "SELECT COUNT(*) FROM lifesytle where favoriteFoods LIKE '%Pap and Wors%'";

                string query7 = "SELECT ROUND(AVG(eatoutRating),1) from lifesytle";
                string query8 = "SELECT ROUND(AVG(watchmovieRating),1) from lifesytle";
                string query9 = "SELECT ROUND(AVG(watchTvRating),1) from lifesytle";
                string query10 = "SELECT ROUND(AVG(listenradioRating),1) from lifesytle";

                MySqlCommand avg = new MySqlCommand(query1, conn);
                MySqlCommand max = new MySqlCommand(query2, conn);
                MySqlCommand min = new MySqlCommand(query3, conn);
                MySqlCommand pizza = new MySqlCommand(query4, conn);
                MySqlCommand pasta = new MySqlCommand(query5, conn);
                MySqlCommand papwors = new MySqlCommand(query6, conn);






                MySqlCommand eatingout = new MySqlCommand(query7, conn);
                MySqlCommand moviewatch = new MySqlCommand(query8, conn);
                MySqlCommand TVwatch = new MySqlCommand(query9, conn);
                MySqlCommand Radiolisten = new MySqlCommand(query10, conn);





                var pizzavar =pizza.ExecuteScalar();
                var maximum=max.ExecuteScalar();
                var average = avg.ExecuteScalar();
                var minimum=min.ExecuteScalar();
                var pastavar=pasta.ExecuteScalar();
                var papworsvar=papwors.ExecuteScalar();




                var eatingoutvar=eatingout.ExecuteScalar();
                var moviewatchvar=moviewatch.ExecuteScalar();
                var TVwatchvar=TVwatch.ExecuteScalar();
                var Radiolistenvar=Radiolisten.ExecuteScalar();


                string eatingOutlike=eatingoutvar.ToString();
                string moviewatchlike=moviewatchvar.ToString();    
                string Tvwatchlike=TVwatchvar.ToString();
                string Radiollikes=Radiolistenvar.ToString();





              



                
                







                string papworslike=papworsvar.ToString();

                string pastalike=pastavar.ToString();

                string pizzalike=pizzavar.ToString();
                
                double papworsasvalue=Convert.ToDouble(papworslike);  
                double pastaasvalue=Convert.ToDouble(pastalike);
                double pizzaasvalue = Convert.ToDouble(pizzalike);


                double finalpizzapercent = (pizzaasvalue / Convert.ToDouble(numberofrows))*100;
                double finalpastapercent = (pastaasvalue / Convert.ToDouble(numberofrows)) * 100;
                double finalpapworspercent = (papworsasvalue / Convert.ToDouble(numberofrows)) * 100;


                string papworspercentasstring=finalpapworspercent.ToString();
                string percentasstring =finalpizzapercent.ToString();
                string pastapercentasstring=finalpastapercent.ToString();




                string averageage = average.ToString();
                string oldestage=maximum.ToString();



                string youngestage=minimum.ToString();


               





















                textBox1.Text = numberofrows;
                textBox2.Text = averageage;
                textBox3.Text = oldestage;
                textBox4.Text= youngestage;
                textBox5.Text = percentasstring+"%";
                textBox6.Text=pastapercentasstring+"%";
                textBox7.Text = papworspercentasstring + "%";
                textBox8.Text = eatingOutlike;
                textBox9.Text = moviewatchlike;
                textBox10.Text = Tvwatchlike;
                textBox11.Text = Radiollikes; 



                conn.Close();

















            }
            catch (Exception ex)
            {


                MessageBox.Show("Error:" + ex.Message);
            }
           
        }
    }
}
