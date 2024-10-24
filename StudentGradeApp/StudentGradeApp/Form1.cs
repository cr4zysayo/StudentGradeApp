using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            String english = textBox2.Text;
            String math = textBox3.Text;
            String science = textBox4.Text;
            String filipino = textBox5.Text;
            String history = textBox6.Text;


            double english1 = Convert.ToDouble(english);
            double math1 = Convert.ToDouble(math);
            double science1 = Convert.ToDouble(science);
            double filipino1 = Convert.ToDouble(filipino);
            double history1 = Convert.ToDouble(history);

            double totalgrades = english1 + math1 + science1 + filipino1 + history1;
            double average = totalgrades / 5;

            textBox7.Text = totalgrades.ToString();
            textBox8.Text = average.ToString();


            string grade;
            if (average >= 75)
            {
                grade = "The student passed.";
            }
            else
            {
                grade = "The student did not pass.";
            }
            textBox7.Text = grade;

            String genavg = "The general average of " + name + " is " + average.ToString();
            textBox8.Text = genavg;

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
