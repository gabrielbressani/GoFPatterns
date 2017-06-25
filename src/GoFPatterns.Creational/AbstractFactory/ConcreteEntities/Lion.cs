using System;
using GoFPatterns.Creational.AbstractFactory.AbstractEntites;

namespace GoFPatterns.Creational.AbstractFactory.ConcreteEntities
{
    public class Lion : Carnivore
    {
        public override void Eat(Herbivore herbivore)
        {
            Console.WriteLine($"{ this.GetType().Name } eats { herbivore.GetType().Name }");
        }
    }
}
