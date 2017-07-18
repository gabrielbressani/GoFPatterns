using GofPatterns.Structural.Facade.Facade;
using GofPatterns.Structural.Facade.Subsystem;
using System;

namespace GofPatterns.Structural.Facade
{
    public class RealWorld
    {
        public static void Run()
        {
            var mortgage = new Mortgage();
            var customer = new Customer("Ann McKinsey");

            bool eligible = mortgage.IsEligible(customer, 125000);

            Console.WriteLine($"\n { customer.Name } has been { (eligible ? "Approved" : "Rejected") }");
        }
    }
}
