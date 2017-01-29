using System;
using Abstract_Factory.Continents;

namespace Abstract_Factory
{
    class Program
    {
        static void Main()
        {
            ContinentFactory africa = new AfricaFactory();
            var world = new AnimalWorld(africa);
            world.RunFoodChain();

            var america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();

            Console.ReadKey();
        }
    }
}
