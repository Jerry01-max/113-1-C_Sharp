﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pay_and_Bonus
{
    public partial class Form1 : Form
    {
        // Constant field for the contribution rate
        private const decimal CONTRIB_RATE = 0.05m;

        public Form1()
        {
            InitializeComponent();
        }

        // The InputIsValid method converts the user input and stores
        // it in the arguments (passed by reference). If the conversion
        // is successful, the method returns true. Otherwise it returns
        // false.
        

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal grossPay = 0.0m;
            decimal bouns = 0.0m;

            if (InputIsValid(ref grossPay,ref bouns))
            {
                decimal contrinution = (grossPay +  bouns) * CONTRIB_RATE;
                contributionLabel.Text = contrinution.ToString("c");
            }
            else
            {
                MessageBox.Show("請輸入有效的數字");
            }
        }

        private bool InputIsValid(ref decimal grossPay,ref decimal bouns)
        {
            bool inputGood = false;

            if(decimal.TryParse(grossPayTextBox.Text, out grossPay))
            {

                if(decimal.TryParse(bonusTextBox.Text, out bouns))
                {
                    inputGood = true;
                }
            }
            return inputGood;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}