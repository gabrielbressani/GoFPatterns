using GoFPatterns.Creational.Singleton.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoFPatterns.Creational.Singleton
{
    public class RealWord
    {
        public static void Run()
        {
            var instanceA = DataCenter.GetInstance();
            var instanceB = DataCenter.GetInstance();
            var instanceC = DataCenter.GetInstance();
            var instanceD = DataCenter.GetInstance();

            if (instanceA == instanceB && instanceC == instanceD)
                Console.WriteLine("Same instance\n");
        }
    }
}
