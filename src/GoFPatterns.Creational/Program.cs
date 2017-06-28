using System;

namespace GoFPatterns.Creational
{
    public class Program
    {
        public static void Main()
        {
            FactoryMethod.RealWorld.Run();
            AbstractFactory.RealWord.Run();
            Singleton.RealWord.Run();

            Console.ReadKey();
        }
    }
}
