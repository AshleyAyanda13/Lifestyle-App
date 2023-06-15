using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace LifestyleeApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //rename all to text
            string surname = textBox1.Text;

            string firstnames=textBox2.Text;
            string contactNumbers = textBox3.Text;
            string Date= dateTimePicker1.Text;
          string falsee = "False";

            
            string Age=textBox5.Text;


            int AgeasInt = 0;
            
           

            
            int id=0;

            string pizza;
            string pasta;
            string papwors;
            string chickenstir;
            string beefstir;
            string other;
            int valueofeatout=0;
            int valueofmovies=0;
            int valueofwatchTV=0;
            int valuelistenradio=0;
            ArrayList foods = new ArrayList();


            //  Console.WriteLine(surname+firstnames+contactNumbers+Date+Age);





            string comm = "datasource=127.0.0.1;port=3306;username=root;password=;database=ayandafirst";


            MySqlConnection conn = new MySqlConnection(comm);
           


          



            try
            {


                conn.Open();
              




               string trueb = "True";


                if (checkBox1.Checked.ToString() == trueb)
                {
                 



                 pizza = checkBox1.Text;

                     foods.Add(pizza);
                    
                  
                }
                else
                {

                 pizza = "";

                }
                if (checkBox2.Checked.ToString() == trueb)
                {
                  



                     pasta = checkBox2.Text;
                    foods.Add(pasta);


                }
                else
                {


                   pasta = "";

                }

                if (checkBox3.Checked.ToString()==trueb)
                {
             

                 

                    papwors = checkBox3.Text;

                foods.Add(papwors);

                }
                else
                {


                   papwors = "";

                }
                if (checkBox4.Checked.ToString() == trueb)
                {
            



                    chickenstir = checkBox4.Text;
                   foods.Add(chickenstir);


                }
                else
                {


                   chickenstir = "";

                }
                if (checkBox5.Checked.ToString() == trueb)
                {



                  beefstir = checkBox5.Text;

                    foods.Add(beefstir);

                }
                else
                {


                   beefstir = "";

                }
                if (checkBox6.Checked.ToString() == trueb)
                {
             



                     other = checkBox6.Text;
                   foods.Add(other);


                }
                else
                {


                    other = "";

                }










                // joins string with "/" between them
                string result = String.Join(",", foods.ToArray());

                Console.WriteLine(result);






















              if(  radioButton1.Checked.ToString() == trueb)


                {


                     valueofeatout = 1;
                    Console.WriteLine(valueofeatout);


                }

                if (radioButton2.Checked.ToString() == trueb)


                {


                  valueofeatout = 2;
                    Console.WriteLine(valueofeatout);


                }

                if (radioButton3.Checked.ToString() == trueb)


                {


                   valueofeatout = 3;
                    Console.WriteLine(valueofeatout);


                }

                if (radioButton4.Checked.ToString() == trueb)


                {


                valueofeatout = 4;

                    Console.WriteLine(valueofeatout);

                }

                if (radioButton5.Checked.ToString() == trueb)


                {


                     valueofeatout = 5;
                    Console.WriteLine(valueofeatout);


                }

                if (radioButton6.Checked.ToString() == trueb)


                {


                    valueofmovies = 1;
                    Console.WriteLine(valueofmovies);



                }
                if (radioButton7.Checked.ToString() == trueb)


                {


                 valueofmovies = 2;
                    Console.WriteLine(valueofmovies);



                }
                if (radioButton8.Checked.ToString() == trueb)


                {


                    valueofmovies = 3;
                    Console.WriteLine(valueofmovies);



                }
                if (radioButton9.Checked.ToString() == trueb)


                {


                   valueofmovies = 4;
                    Console.WriteLine(valueofmovies);



                }
                if (radioButton10.Checked.ToString() == trueb)


                {


                   valueofmovies = 5;
                    Console.WriteLine(valueofmovies);



                }
                if (radioButton11.Checked.ToString() == trueb)


                {


                    valueofwatchTV = 1;
                    Console.WriteLine(valueofwatchTV);



                }
                if (radioButton12.Checked.ToString() == trueb)


                {


                    valueofwatchTV = 2;
                    Console.WriteLine(valueofwatchTV);


                }
                if (radioButton13.Checked.ToString() == trueb)


                {


                  valueofwatchTV = 3;
                    Console.WriteLine(valueofwatchTV);


                }
                if (radioButton14.Checked.ToString() == trueb)


                {


                     valueofwatchTV = 4;
                    Console.WriteLine(valueofwatchTV);



                }
                if (radioButton15.Checked.ToString() == trueb)


                {


                 valueofwatchTV = 5;
                    Console.WriteLine(valueofwatchTV);



                }
                if (radioButton16.Checked.ToString() == trueb)


                {


                  valuelistenradio = 1;
                    Console.WriteLine(valuelistenradio);


                }
                if (radioButton17.Checked.ToString() == trueb)


                {


                     valuelistenradio = 2;
                    Console.WriteLine(valuelistenradio);


                }
                if (radioButton18.Checked.ToString() == trueb)


                {


                    valuelistenradio = 3;
                    Console.WriteLine(valuelistenradio);


                }
                if (radioButton19.Checked.ToString() == trueb)


                {


                   valuelistenradio = 4;
                    Console.WriteLine(valuelistenradio);


                }
                if (radioButton20.Checked.ToString() == trueb)


                {


                     valuelistenradio = 5;
                    Console.WriteLine(valuelistenradio);


                }



                Console.WriteLine(checkBox1.Checked.ToString());


                if (textBox1.Text.Length<1||textBox2.Text.Length<1||textBox3.Text.Length<1||textBox5.Text.Length<1)
                {

                    MessageBox.Show("Textfields are empty or too short","Error");
                   
                }
                else
                {


                   AgeasInt = Convert.ToInt32(Age);




                    if (AgeasInt < 5 || AgeasInt > 120)
                    {
                        MessageBox.Show("Age is either under 5 years or older than 120 years", "Error");



                    }
                    else
                    
                    {




                        if(valueofeatout == 0 || valueofmovies == 0 || valueofwatchTV == 0 || valuelistenradio == 0)

                        {


                            MessageBox.Show("You cannot submit without carrying out the ratings", "Error");



                        }

                        else
                        {


                            if(System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "[^0-9]")|| System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, "[^0-9]"))
                                
                                
                                
                            {

                                MessageBox.Show("Contact numbers and Age should only contain numbers","Error");

                          




                            }
                            else
                            {

                                if (textBox3.Text.Length < 10|| textBox3.Text.Length>10) 
                                {



                                    MessageBox.Show("Contact numbers is too short/long", "Error");


                                }
                                else
                                {

                                 





                                  if  (checkBox1.Checked.ToString()==falsee&& checkBox2.Checked.ToString() == falsee && checkBox3.Checked.ToString() == falsee && checkBox4.Checked.ToString() == falsee && checkBox5.Checked.ToString() == falsee && checkBox6.Checked.ToString() == falsee)
                                    
                                    
                                    {
                                        MessageBox.Show("Please pick your favorite food", "Error");




                                    }
                                    else
                                    {

                                        if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^a-zA-Z]") || System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^a-zA-Z]"))
                                        {


                                            MessageBox.Show("Surname and Name fields should only contain letters", "Error");



                                        }
                                        else
                                        {
                                            //if the program reaches this  the code then it means every part of the form has been validated and therefore the all the inputs from the user can be sent to the database.



                                            string query = "    Insert into lifesytle values (' " + id + "'  , '" + surname + "',  '" + firstnames + "',  '" + contactNumbers + "', '" + Date + "','" + Age + "','" + result + "','" + valueofeatout + "','" + valueofmovies + "','" + valueofwatchTV + "','" + valuelistenradio + "')";
                                          
                                            MySqlCommand commandDatabase = new MySqlCommand(query, conn);
                                               MySqlDataReader myreader = commandDatabase.ExecuteReader();



                                            MessageBox.Show("Thanks! Your form has been submitted");

                                            Form1 form1 = new Form1();

                                            form1.Show();
                                            this.Hide();

                                        }







                                    }








                                }


                            }


                        }






                    }


                }







                




             







            }
            catch (Exception ex) {


                MessageBox.Show("Error:" + ex.Message);
            }























































































        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
