using System;
using GoFPatterns.Creational.AbstractFactory.AbstractEntites;
using GoFPatterns.Creational.AbstractFactory.AbstractFactories;
using GoFPatterns.Creational.AbstractFactory.ConcreteEntities;

namespace GoFPatterns.Creational.AbstractFactory.ConcreteFactories
{
    public class AfricaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }
    }
}
