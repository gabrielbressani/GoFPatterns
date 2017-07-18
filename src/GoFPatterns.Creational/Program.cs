using System;

namespace GoFPatterns.Creational
{
    public class Program
    {
        public static void Main()
        {
            FactoryMethod.RealWorld.Run();
            AbstractFactory.RealWorld.Run();
            Singleton.RealWorld.Run();

            Console.ReadKey();
        }
    }
}
