using System;

namespace StarWars
{
    class SolarSystem
    {
        private static SolarSystem instance = null;
        public List<Planet> Planets { get; }
        private SolarSystem() { Planets = new List<Planet>(); }
        public static SolarSystem Instance()
        {
            if (instance == null) instance = new SolarSystem();
            return instance;
        }

        public bool MaxPowerShip(out StarShip bestship)
        {
            bool l = false;
            double maxpower = 0;
            bestship = null;
            foreach(Planet p in Planets)
            {
                bool ll = p.MaxPower(out double power, out StarShip ship);
                if (!ll) continue;
                if (!l)
                {
                    l = true;
                    maxpower = power;
                    bestship = ship;
                }
                else
                {
                    if (maxpower < power)
                    {
                        maxpower = power;
                        bestship = ship;
                    }
                }
            }
            return l;
        }

        public Planet Unprotected()
        {
            foreach(Planet p in Planets)
            {
                if (p.ShipCount() == 0) return p;
            }
            return null;
        }
    }
}