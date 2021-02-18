using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] userAns = new int[5];
        int[] answer = new int[5];
        int score = 0;
        int count = 0;
        double percent = 0;
        Boolean gogo = false;
        String[] inputs = System.IO.File.ReadAllLines(@"C:\Users\saveh\OneDrive\Documents\triviaquestions.txt");
        string[] questionOne = new string[6];
        string[] questionTwo = new string[6];
        string[] questionThree = new string[6];
        string[] questionFour = new string[6];
        string[] questionFive = new string[6];



        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {



                Array.Copy(inputs, 0, questionOne, 0, 6);
                Array.Copy(inputs, 6, questionTwo, 0, 6);
                Array.Copy(inputs, 12, questionThree, 0, 6);
                Array.Copy(inputs, 18, questionFour, 0, 6);
                Array.Copy(inputs, 24, questionFive, 0, 6);
                // answer index variables
                int answerOne = int.Parse(questionOne[5]);
                int answerTwo = int.Parse(questionTwo[5]);
                int answerThree = int.Parse(questionThree[5]);
                int answerFour = int.Parse(questionFour[5]);
                int answerFive = int.Parse(questionFive[5]);

                answer[0] = answerOne;
                answer[1] = answerTwo;
                answer[2] = answerThree;
                answer[3] = answerFour;
                answer[4] = answerFive;



                label1.Text = questionOne[0];

                listBox1.Items.Add(questionOne[1]);
                listBox1.Items.Add(questionOne[2]);
                listBox1.Items.Add(questionOne[3]);
                listBox1.Items.Add(questionOne[4]);
            

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
            label3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gogo = false;
            try
            {
                if (listBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Error!! Select a capitol!");

                }
                else
                {

                    userAns[count] = listBox1.SelectedIndex + 1;
                    if (userAns[count] == answer[count])
                    {
                        MessageBox.Show("Correct!");
                        score++;
                        count++;
                        MessageBox.Show("select next question");

                    }
                    else
                    {
                        MessageBox.Show("That is incorrect!");
                    }
                    if(count == 5)
                    {
                        MessageBox.Show("game over");
                        
                    }
                    
                    
                    percent = (double)(score * 100) / 5;
                    label2.Text = (Math.Round(percent, 2).ToString());
                    gogo = true;



                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (gogo == false)
                {
                    MessageBox.Show("Error!! Answer the question!");
                }
                else
                {
                    listBox1.Items.Clear();
                    switch (count)
                    {
                        case 1:
                            {
                                label1.Text = questionTwo[0];
                                listBox1.Items.Add(questionTwo[1]);
                                listBox1.Items.Add(questionTwo[2]);
                                listBox1.Items.Add(questionTwo[3]);
                                listBox1.Items.Add(questionTwo[4]);
                                break;
                            }
                        case 2:
                            {

                                label1.Text = questionThree[0];
                                listBox1.Items.Add(questionThree[1]);
                                listBox1.Items.Add(questionThree[2]);
                                listBox1.Items.Add(questionThree[3]);
                                listBox1.Items.Add(questionThree[4]);
                                break;

                            }
                        case 3:
                            {
                                label1.Text = questionFour[0];
                                listBox1.Items.Add(questionFour[1]);
                                listBox1.Items.Add(questionFour[2]);
                                listBox1.Items.Add(questionFour[3]);
                                listBox1.Items.Add(questionFour[4]);
                                break;
                            }

                            
                        case 4:
                            {
                                label1.Text = questionFive[0];
                                listBox1.Items.Add(questionFive[1]);
                                listBox1.Items.Add(questionFive[2]);
                                listBox1.Items.Add(questionFive[3]);
                                listBox1.Items.Add(questionFive[4]);
                                break;
                            } 
                            
                        default:
                            {
                                if (count == 5)
                                {
                                    MessageBox.Show("Thanks for playing. Out of the quesitions answered, your score is " +
                                        (Math.Round(percent, 2).ToString()) + "%");
                                }   break;

                                     }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Good-Bye!");
            Close();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
    }
    }








    