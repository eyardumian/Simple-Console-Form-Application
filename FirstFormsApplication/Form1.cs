﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Variables for input and ouput.
            int FirstNum = Convert.ToInt32(numOne.Text);
            int SecondNum = Convert.ToInt32(numTwo.Text);
            string Operation = operation.Text;
            int Answer;

            //Determine what operation to use.
            if (Operation.Equals("+"))
            {
                Answer = FirstNum + SecondNum;
                answer.Text = "Answer:" + "  " + Answer.ToString();
            }
            else if (Operation.Equals("-"))
            {
                Answer = FirstNum - SecondNum;
                answer.Text = "Answer:" + "  " + Answer.ToString();
            }
            else if (Operation.Equals("x"))
            {
                Answer = FirstNum * SecondNum;
                answer.Text = "Answer:" + "  " + Answer.ToString();
            }
            // Display message if user input is incorrect.
            else
            {
                answer.Text = "Wrong input.";
            }
        }
    }
}
