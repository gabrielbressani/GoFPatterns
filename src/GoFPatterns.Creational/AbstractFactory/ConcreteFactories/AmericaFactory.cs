using System;
using GoFPatterns.Creational.AbstractFactory.AbstractFactories;
using GoFPatterns.Creational.AbstractFactory.AbstractEntites;
using GoFPatterns.Creational.AbstractFactory.ConcreteEntities;

namespace GoFPatterns.Creational.AbstractFactory.ConcreteFactories
{
    /// <summary>
    /// Implements the operations to create concrete entities objects.
    /// </summary>
    public class AmericaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }
    }
}
