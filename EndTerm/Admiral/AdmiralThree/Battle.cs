using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmiralProject
{
    public class Battle
    {

        public readonly Fraction attacker;

        public Planet place;

        public List<Ship>attackers = new List<Ship>();
        public List<Ship>defenders = new List<Ship>();  

        public Battle(Fraction attacker, Planet place,Ship sA, Ship sD)
        {
            this.attacker = attacker;
            this.place = place;
            this.attackers.Add(sA);
            this.defenders.Add(sD);

        }
        public void Reinforcement(Fraction whom, Ship ship)
        {
            if (whom == attacker)
            {
                if (attackers.Count < place.MaxCapacity())
                {
                    attackers.Add(ship);
                }
                else
                {
                    throw new Exception();
                }
            }
            else
            {
                if (defenders.Count < place.MaxCapacity())
                {
                    defenders.Add(ship);
                }
                else
                {
                    throw new Exception();
                }
            }
             
            }
        
        public void Fight()
        {
            foreach(Ship s in attackers)
            {
                if(s.armor > 0)
                {
                    Ship ship;
                    bool l;
                    (l, ship) = SearchTarget(defenders);
                    if(l)
                    {
                        s.Attack(ship);
                    }
                }

            }
            foreach(Ship s in defenders)
            {
                if(s.armor > 0)
                {
                    Ship ship;
                    bool l;
                    (l, ship) = SearchTarget(attackers);
                    if(l)
                    {
                        s.Attack(ship);
                    }
                }
            }
        }
        public (bool, int) Result(Fraction side)
        {
            int remainA = 0;
            foreach(Ship s in attackers)
            {
                if(s.armor > 0)
                {
                    remainA++;
                }
            }
            int remainD = 0;
            foreach (Ship s in defenders)
            { if(s.armor > 0) { remainD ++; } }
            if(side == attacker)
            {
                return ((remainA > 0 && remainD == 0), remainA);
            }
            return ((remainD > 0 && remainA == 0), remainD);
        }
        public int DestroyedShips()
        {
            int sum = 0;
            foreach(Ship s in attackers)
            {
                if(s.armor <= 0)
                {
                    sum++;
                }
                
            }
            foreach(Ship s in defenders)
            {
                if(s.armor <= 0)
                {
                    sum++;
                }
            }
            return sum;

        }
        public(bool, Ship) SearchTarget(List<Ship>opponent)
        {
            foreach(var s in opponent)
            {
                if(s.armor > 0)
                {
                    return (true, s);

                }

            }
            return (false, null);
        }
        public Fraction Attacker()
        {
            return attacker;
        }
        public Planet Place()
        {
            return place;
        }



    }
}
