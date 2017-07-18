using System;

namespace GofPatterns.Structural.Facade.Subsystem
{
    public class Bank
    {
        public bool HasSufficientSavings(Customer customer, int amount)
        {
            Console.WriteLine($"Check bank for { customer.Name }");
            return true;
        }
    }
}
