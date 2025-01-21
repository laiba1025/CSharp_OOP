using System;

namespace StarWars
{
    abstract class StarShip
    {
        public string Name { get; }
        public int Shield { get; }
        public int Armor { get ;}
        public int SpaceGuard { get; }

        public Planet Planet { get; private set; }

        public StarShip(string name, int shield, int armor, int guard)
        {
            Name = name;
            Shield = shield;
            Armor = armor;
            SpaceGuard = guard;
        }

        public void Protect(Planet p)
        {
            if (Planet != null) return;
            Planet = p;
            p.Protect(this);
        }

        public void Leave()
        {
            if (Planet == null) return;
            Planet.Leave(this);
            Planet = null;
        }

        public abstract int Power();
    }

    class Destroyer : StarShip
    {
        public Destroyer (string name, int shield, int armor, int guard) : base(name,shield,armor,guard) { }
        public override int Power()
        {
            return Shield / 2;
        }
    }

    class Transport : StarShip
    {
        public Transport (string name, int shield, int armor, int guard) : base(name,shield,armor,guard) { }
        public override int Power()
        {
            return SpaceGuard;
        }
    }

    class Ironclad : StarShip
    {
        public Ironclad (string name, int shield, int armor, int guard) : base(name,shield,armor,guard) { }
        public override int Power()
        {
            return Armor;
        }
    }

}