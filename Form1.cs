using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23.Monthly_Payment_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Opacity = 0.95;
            CenterToParent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            txtPurchasePrice.BackColor = Color.White;
            txtDownPaymentAmount.BackColor = Color.White;
            txtInterestRate.BackColor = Color.White;
            txtLoanTerm.BackColor = Color.White;

            double purchasePrice = 0;
            double downPaymentAmount = 0;
            double interestRate = 0;
            int loanTerm = 0;
            double amountToFinance;
            double monthlyPayment;

            bool validInput = true;

            
            if (string.IsNullOrWhiteSpace(txtPurchasePrice.Text) ||
                string.IsNullOrWhiteSpace(txtDownPaymentAmount.Text) ||
                string.IsNullOrWhiteSpace(txtInterestRate.Text) ||
                string.IsNullOrWhiteSpace(txtLoanTerm.Text))
            {
                validInput = false;
                MessageBox.Show("Please enter values in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Double.TryParse(txtPurchasePrice.Text, out purchasePrice) &&
                    Double.TryParse(txtDownPaymentAmount.Text, out downPaymentAmount) &&
                    Double.TryParse(txtInterestRate.Text, out interestRate) &&
                    Int32.TryParse(txtLoanTerm.Text, out loanTerm))
                {
                    amountToFinance = purchasePrice - downPaymentAmount;
                    txtAmountToFinance.Text = amountToFinance.ToString("C");

                    double monthlyIR = interestRate / 12;

                    monthlyPayment = amountToFinance * (monthlyIR * Math.Pow(1 + monthlyIR, loanTerm)) / (Math.Pow(1 + monthlyIR, loanTerm) - 1);
                    monthlyPayment = Math.Round(monthlyPayment, 2);
                    txtMonthlyPayment.Text = monthlyPayment.ToString("C");
                }
                else
                {
                    validInput = false;
                    MessageBox.Show("Invalid input. Please enter valid numeric values on all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

           
            if (!validInput)
            {
                if (string.IsNullOrWhiteSpace(txtPurchasePrice.Text))
                    txtPurchasePrice.BackColor = Color.LightSalmon;
                if (string.IsNullOrWhiteSpace(txtDownPaymentAmount.Text))
                    txtDownPaymentAmount.BackColor = Color.LightSalmon;
                if (string.IsNullOrWhiteSpace(txtInterestRate.Text))
                    txtInterestRate.BackColor = Color.LightSalmon;
                if (string.IsNullOrWhiteSpace(txtLoanTerm.Text))
                    txtLoanTerm.BackColor = Color.LightSalmon;
            }


        }
    }
}
