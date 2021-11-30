using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtRepaymentCalculator
{
    class DebtDetails
    {
        public DebtDetails()
        {
            PrincipalDebt = 0;
            YearlyInterestRate = 0;
            MonthlyInterestRate = YearlyInterestRate / 12;
            MinimumPayment = 0;
        }

        public decimal PrincipalDebt { get; set; }
        public decimal YearlyInterestRate { get; set; }
        public decimal MonthlyInterestRate { get; set; }
        public decimal MinimumPayment { get; set; }
        
    }
 
}
