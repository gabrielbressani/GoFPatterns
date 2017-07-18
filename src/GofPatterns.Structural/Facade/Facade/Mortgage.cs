using GofPatterns.Structural.Facade.Subsystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GofPatterns.Structural.Facade.Facade
{
    public class Mortgage
    {
        private Bank _bank = new Bank();
        private Loan _loan = new Loan();
        private Credit _credit = new Credit();

        public bool IsEligible(Customer customer, int amount)
        {
            Console.WriteLine($"{ customer.Name } applies for { amount } loan\n");

            if (!_bank.HasSufficientSavings(customer, amount))
                return false;
            else if (!_loan.HasNoBadLoans(customer))
                return false;
            else if (!_credit.HasGoodCredit(customer))
                return false;
            else
                return true;
        }
    }
}
