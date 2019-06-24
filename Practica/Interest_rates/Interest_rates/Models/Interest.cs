using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Interest_rates.Models
{
    public class Interest
    {
        [Required(ErrorMessage = "Please type in your name.")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please type in your initial debt.")]
        public double StartingAmmount { get; set; }
        [Required(ErrorMessage ="Please type in the interest rate.")]
        public decimal InterestRate { get; set; }
        [Required(ErrorMessage ="Please type in ammount of days from the beginning of this transaction.")]
        [RegularExpression("^[0-9]*$")]
        public int time { get; set; }

        //Calculo del interes.
        public double GetInterest(double capita, decimal rate,int time) {
            double interest = 0;
            // i = c i t
            interest = capita * Convert.ToDouble(rate) * time;
            return interest;
        }
        //Calculo del total a pagar.
        public double GetTotal(double TotalInterest, double capita) {
            double total = 0;
            // = i + c
            total = TotalInterest + capita;
            return total;
        }
    }
}