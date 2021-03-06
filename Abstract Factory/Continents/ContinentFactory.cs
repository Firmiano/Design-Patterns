﻿namespace Abstract_Factory.Continents
{
    public abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }
}
