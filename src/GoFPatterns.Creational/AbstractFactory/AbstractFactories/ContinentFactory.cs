using GoFPatterns.Creational.AbstractFactory.AbstractEntites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoFPatterns.Creational.AbstractFactory.AbstractFactories
{
    public abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }
}
