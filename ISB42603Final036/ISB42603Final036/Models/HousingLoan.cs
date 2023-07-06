using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ISB42603Final036.Models {
    public class HousingLoan {
        
        [Display(Name = "Customer id")]
        public string CustomerID {
            get;
            set;
        }

        [Display(Name = "Name")]
        public string Name {
            get;
            set;
        }
        
        [Display(Name = "Gender(M/F)")]
        public string Gender {
            get;
            set;
        }

        [Display(Name = "Credit Status(A/B/C)")]
        public string CreditStatus {
            get;
            set;
        }
        
        [Display(Name = "Principal (RM)")]
        public double Principal {
            get;
            set;
        }

        [Display(Name = "Number of Years")]
        public int NumberOfYears {
            get;
            set;
        }

        [Display(Name = "Interest rate(%)")]
        public double InterestRate {
            get {
                if (CreditStatus == "A") {
                    return Math.Round(3.0,2);
                }
                else if (CreditStatus == "B" || CreditStatus == "C"){
                    return Math.Round(3.1, 2);
                }
                else {
                    return 0;
                }
            }
            set { }
        }

        [Display(Name = "Monthly Payment (RM)")]
        public double MonthlyPayment {
            get {
                double monthlyInterestRate = (InterestRate / 100) / 12;
                double NumberOfMonths = NumberOfYears * 12;
                double numerator = monthlyInterestRate * (Math.Pow((1 + monthlyInterestRate), NumberOfMonths));
                double denominator = Math.Pow((1 + monthlyInterestRate), NumberOfMonths) - 1;
                return Math.Round( Principal * (numerator / denominator), 2);
            }
            set {

            }
        }
    }
}
