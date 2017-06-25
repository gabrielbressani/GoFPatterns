using GoFPatterns.Creational.FactoryMethod.AbstractFactories;
using GoFPatterns.Creational.FactoryMethod.ConcreteFactories;
using System;
using System.Collections.Generic;

namespace GoFPatterns.Creational.FactoryMethod
{
    public class RealWorld
    {
        public static void Run()
        {
            var documents = new List<Document>();
            documents.Add(new Resume());
            documents.Add(new Report());

            foreach (var document in documents)
            {
                Console.WriteLine($"\n { document.GetType().Name } --");

                foreach (var page in document.Pages)
                {
                    Console.WriteLine($" { page.GetType().Name }.");
                }
            }
        }
    }
}
