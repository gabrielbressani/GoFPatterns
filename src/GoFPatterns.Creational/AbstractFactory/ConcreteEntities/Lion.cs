﻿using System;
using GoFPatterns.Creational.AbstractFactory.AbstractEntites;

namespace GoFPatterns.Creational.AbstractFactory.ConcreteEntities
{
    /// <summary>
    /// This is a concrete class that inherits from an abstract class that the abstract factory creates.
    /// </summary>
    public class Lion : Carnivore
    {
        public override void Eat(Herbivore herbivore)
        {
            Console.WriteLine($"{ this.GetType().Name } eats { herbivore.GetType().Name }");
        }
    }
}
