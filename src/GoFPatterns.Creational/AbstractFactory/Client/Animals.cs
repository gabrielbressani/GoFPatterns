using GoFPatterns.Creational.AbstractFactory.AbstractEntites;
using GoFPatterns.Creational.AbstractFactory.AbstractFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoFPatterns.Creational.AbstractFactory.Client
{
    public class Animals
    {
        private readonly Herbivore _herbivore;
        private readonly Carnivore _carnivore;

        public Animals(ContinentFactory continentFactory)
        {
            _herbivore = continentFactory.CreateHerbivore();
            _carnivore = continentFactory.CreateCarnivore();
        }

        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}
