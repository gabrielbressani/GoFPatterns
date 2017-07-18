using System;

namespace GofPatterns.Structural.Facade.Subsystem
{
    public class Credit
    {
        public bool HasGoodCredit(Customer customer)
        {
            Console.WriteLine($"Check credit for { customer.Name }");
            return true;
        }
    }
}
