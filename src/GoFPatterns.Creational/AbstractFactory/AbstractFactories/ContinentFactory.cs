using GoFPatterns.Creational.AbstractFactory.AbstractEntites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoFPatterns.Creational.AbstractFactory.AbstractFactories
{
    /// <summary>
    /// Declares an abstract class for operations that create abstract entities 
    /// </summary>
    public abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }
}
