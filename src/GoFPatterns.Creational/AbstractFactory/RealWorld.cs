using GoFPatterns.Creational.AbstractFactory.AbstractFactories;
using GoFPatterns.Creational.AbstractFactory.Client;
using GoFPatterns.Creational.AbstractFactory.ConcreteFactories;

namespace GoFPatterns.Creational.AbstractFactory
{
    public class RealWorld
    {
        public static void Run()
        {
            ContinentFactory africa = new AfricaFactory();
            var animals = new Animals(africa);
            animals.RunFoodChain();

            ContinentFactory america = new AmericaFactory();
            animals = new Animals(america);
            animals.RunFoodChain();
        }
    }
}
