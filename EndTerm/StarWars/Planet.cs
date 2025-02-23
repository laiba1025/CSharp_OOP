using System;

namespace StarWars
{
    class Planet
    {
        public string Name { get; }
        public List<StarShip> Ships { get; private set; }

        public Planet(string name)
        {
            Name = name;
            Ships = new List<StarShip>();
        }

        public int ShipCount()
        {
            return Ships.Count;
        }

        public bool MaxPower(out double maxPower, out StarShip ship)
        {
            bool l = false;
            maxPower = 0;
            ship = null;
            foreach(StarShip s in Ships)
            {
                int b = s.Power();
                if (!l)
                {
                    l = true;
                    maxPower = b;
                    ship = s;
                }
                else
                {
                    if (maxPower < b)
                    {
                        maxPower = b;
                        ship = s;
                    }
                }
            }
            return l;
        }

        public int TotalShield()
        {
            int s = 0;
            foreach (StarShip e in Ships) s += e.Shield;
            return s;
        }

        public void Protect(StarShip s)
        {
            Ships.Add(s);
        }

        public void Leave(StarShip s)
        {
            Ships.Remove(s);
        }
    }
}