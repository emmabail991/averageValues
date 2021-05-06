//Emmanuel Bailey
//2021-05-06
//Average Values
//Mr.t 3U computer Sience


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace averageValues
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double totalValue;
        double average;
        int numbersAdded;

        private void addButton_Click(object sender, EventArgs e)
        {

            //try and catch stop user from entering letter or nothing
            try
            {
                int number = Convert.ToInt32(inputNumber.Text);



                //gte average of numbers and displays them
                if (number > 0)
                {
                    numbersAdded++;
                    totalValue = number + totalValue;


                    outputLabel.Text = $"{number} was added to the sum";
                }
                else
                {
                    average = totalValue / numbersAdded;
                    outputLabel.Text = $"{average} is the average of you numbers";
                }
            }
            catch
            {

                outputLabel.Text = " please enter a number";

            }

            //clear the text box after pressing add
            inputNumber.Clear();







        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            numbersAdded = 0;
            average = 0;
            totalValue = 0;

            outputLabel.Text = "";
        }
    }
}
