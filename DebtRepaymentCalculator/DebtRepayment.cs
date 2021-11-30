/*
Project name:   DebtRepaymentCalculator
Author : Zak Tedder
Date : 12/08/2020
Description : The program intakes multiple debt information for principal balances, interest rates, and
              minimum payments. Then the program gets user input for the monthly payment that will be made.
              Payments subtract the interest for each debt and apply the remaining payment to target the 
              debt with the highest interest rate and lowest principal balance. The amount of time to 
              repay the debt in years and months is then displayed.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebtRepaymentCalculator
{
    public partial class DebtRepayment : Form
    {
        List<DebtDetails> allDebt = new List<DebtDetails>();

        public DebtRepayment()
        {
            InitializeComponent();
        }

        private void GetDebtDetails(DebtDetails debt, decimal principal, decimal yearlyInterest, decimal minPayment)
        {
            decimal monthlyInterest;

            debt.PrincipalDebt = principal;
            debt.YearlyInterestRate = yearlyInterest / 100;
            monthlyInterest = yearlyInterest / 1200;
            debt.MonthlyInterestRate = monthlyInterest;
            debt.MinimumPayment = minPayment;                    
        
            principalTextBox.Clear();
            interestRateTextBox.Clear();
            monthlyPaymentTextBox.Clear();
            principalTextBox.Focus();
        }

        private int GetHighestInterest(List<DebtDetails> allDebt)
        {
            int target = 0;
            while (allDebt[target].PrincipalDebt == 0)
            {
                target += 1;
            }
            for (int i = target; i < allDebt.Count; i++)
            {
                if (allDebt[i].PrincipalDebt == 0)
                {
                    continue;
                }
                else if (allDebt[i].YearlyInterestRate > allDebt[target].YearlyInterestRate)
                {
                    target = i;
                }
                else if ((allDebt[i].YearlyInterestRate == allDebt[target].YearlyInterestRate)
                            && (allDebt[i].PrincipalDebt < allDebt[target].PrincipalDebt))
                {
                    target = i;
                }
            }

            return target;
        }

        private decimal PayMinimum(List<DebtDetails> allDebt, decimal payment)
        {
            for (int i = 0; i < allDebt.Count; i++)
            {
                if (allDebt[i].PrincipalDebt >= allDebt[i].MinimumPayment)
                {
                    allDebt[i].PrincipalDebt -= allDebt[i].MinimumPayment;
                    payment -= allDebt[i].MinimumPayment;
                }
                else
                {
                    payment -= allDebt[i].PrincipalDebt;
                    allDebt[i].PrincipalDebt = 0;
                }
            }

            return payment;
        }

        private decimal TargetPayment(List<DebtDetails> allDebt, decimal payment, int target)
        {
            if (allDebt[target].PrincipalDebt >= payment)
            {
                allDebt[target].PrincipalDebt -= payment;
                payment = 0;
            }
            else
            {
                payment -= allDebt[target].PrincipalDebt;
                allDebt[target].PrincipalDebt = 0;
            }

            return payment;
        }

        private decimal FindInterest(List<DebtDetails> allDebt)
        {
            decimal totalInterest = 0;

            for (int i = 0; i < allDebt.Count; i++)
            {
                decimal interest = allDebt[i].MonthlyInterestRate * allDebt[i].PrincipalDebt;
                totalInterest += interest;
            }

            return totalInterest;
        }

        private void DebtRepayment_Load(object sender, EventArgs e)
        {
            principalTextBox.Focus();
        }

        decimal totalPrincipalDebt;
        decimal averageYearlyInterest;
        decimal averageMonthlyInterest;
        decimal totalMinPayment;

        decimal monthlyPayment;

        private void enterDetailsButton_Click(object sender, EventArgs e)
        {
            decimal principal;
            decimal yearlyInterest;
            decimal minPayment;
            DebtDetails newDebt = new DebtDetails();

            if (decimal.TryParse(principalTextBox.Text, out principal))
            {
                if (decimal.TryParse(interestRateTextBox.Text, out yearlyInterest))
                {
                    if (decimal.TryParse(monthlyPaymentTextBox.Text, out minPayment))
                    {                        
                        GetDebtDetails(newDebt, principal, yearlyInterest, minPayment);
                        allDebt.Add(newDebt);

                        totalPrincipalDebt = 0;
                        averageYearlyInterest = 0;
                        averageMonthlyInterest = 0;
                        totalMinPayment = 0;

                        for (int i = 0; i < allDebt.Count; i++)
                        {
                            totalPrincipalDebt += allDebt[i].PrincipalDebt;
                            averageYearlyInterest += allDebt[i].YearlyInterestRate;
                            totalMinPayment += allDebt[i].MinimumPayment;
                        }

                        averageYearlyInterest = averageYearlyInterest / allDebt.Count;
                        averageMonthlyInterest = averageYearlyInterest / 12;

                        totalDebtLabel.Text = totalPrincipalDebt.ToString("c");
                        averageYearlyInterestLabel.Text = averageYearlyInterest.ToString("n4");
                        averageMonthlyInterestLabel.Text = averageMonthlyInterest.ToString("n4");
                        minPaymentLabel.Text = totalMinPayment.ToString("c");
                    }
                    else
                    {
                        MessageBox.Show("Minimum monthly payment must be a decimal number.");
                    }
                }
                else
                {
                    MessageBox.Show("Yearly interest rate must be a decimal number.");
                }
            }
            else
            {
                MessageBox.Show("Principal must be a decimal number.");
            }
            
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(paymentTextBox.Text, out monthlyPayment))
            {
                if (monthlyPayment >= totalMinPayment)
                {
                    
                    decimal remainingPayment;
                    int months = 0;
                    totalPrincipalDebt = 0;
                    decimal interest;

                    for (int i = 0; i < allDebt.Count; i++)
                    {
                        totalPrincipalDebt += allDebt[i].PrincipalDebt;
                    }
                    
                    interest = FindInterest(allDebt);
                    totalPrincipalDebt += interest;

                    while (totalPrincipalDebt > monthlyPayment)
                    {
                        
                        decimal payment = monthlyPayment;
                        interest = FindInterest(allDebt);
                        payment -= interest;
                        remainingPayment = PayMinimum(allDebt, payment);

                        while (remainingPayment > 0)
                        {
                            int target = GetHighestInterest(allDebt);
                            remainingPayment = TargetPayment(allDebt, remainingPayment, target);
                        }

                        months += 1;

                        totalPrincipalDebt = 0;
                        for (int i = 0; i < allDebt.Count; i++)
                        {
                            totalPrincipalDebt += allDebt[i].PrincipalDebt;
                        }
                        interest = FindInterest(allDebt);
                        totalPrincipalDebt += interest;

                    }
                    months += 1;

                    int years = 0;
                    if (months >= 12)
                    {
                        years = months / 12;
                        months = months % 12;
                    }

                    DisplayTime showMonths = new DisplayTime();
                    showMonths.yearLabel.Text = years.ToString();
                    showMonths.monthLabel.Text = months.ToString();
                    showMonths.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Monthly payment must be greater or equal to minimum monthly payment.");
                }
            }
            else
            {
                MessageBox.Show("Monthly payment must be a decimal number.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}