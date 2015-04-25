using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonusCalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double interest;

        private double principle;

        private int time;

        private double interestrate;
     
        private void calculateInterestButton_Click(object sender, EventArgs e)
        {
            if (bankNameComboBox.SelectedItem == "BRAC")
            {

                interestrate = 0.06;
                principle = double.Parse(balanceTextBox.Text);
                time = int.Parse(timeTextBox.Text);
                interest = principle*time*interestrate;
                interestTextBox.Text = interest.ToString();
            }

            else if (bankNameComboBox.SelectedItem == "DBBL")
            {

                interestrate = 0.07;
                principle = double.Parse(balanceTextBox.Text);
                time = int.Parse(timeTextBox.Text);
                interest = principle * time * interestrate;
                interestTextBox.Text = interest.ToString();
            }

            else if (bankNameComboBox.SelectedItem == "HSBC")
            {

                interestrate = 0.08;
                principle = double.Parse(balanceTextBox.Text);
                time = int.Parse(timeTextBox.Text);
                interest = principle * time * interestrate;
                interestTextBox.Text = interest.ToString();
            }

            else
            {
                MessageBox.Show("You haven't selected");
            }
        }
    }
}
