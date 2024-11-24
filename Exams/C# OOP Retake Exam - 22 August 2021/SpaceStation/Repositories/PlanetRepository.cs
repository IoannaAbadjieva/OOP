﻿namespace SpaceStation.Repositories
{
    using System.Collections.Generic;
    using System.Linq;

    using Contracts;
    using Models.Planets.Contracts;


    public class PlanetRepository : IRepository<IPlanet>
    {

        private readonly ICollection<IPlanet> planets;

        public PlanetRepository()
        {
            this.planets = new HashSet<IPlanet>();
        }

        public IReadOnlyCollection<IPlanet> Models
            => (IReadOnlyCollection<IPlanet>)this.planets;

        public void Add(IPlanet model)
        {
            this.planets.Add(model);
        }

        public IPlanet FindByName(string name)
        => this.planets.FirstOrDefault(p => p.Name == name);

        public bool Remove(IPlanet model)
        => this.planets.Remove(model);
    }
}
