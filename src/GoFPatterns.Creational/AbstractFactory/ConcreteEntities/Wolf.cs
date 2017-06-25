using GoFPatterns.Creational.AbstractFactory.AbstractEntites;
using System;

namespace GoFPatterns.Creational.AbstractFactory.ConcreteEntities
{
    public class Wolf : Carnivore
    {
        public override void Eat(Herbivore herbivore)
        {
            Console.WriteLine($"{ this.GetType().Name } eats { herbivore.GetType().Name }");
        }
    }
}
