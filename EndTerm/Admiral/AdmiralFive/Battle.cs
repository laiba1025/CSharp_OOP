using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using AdmiralFive;

namespace AdmiralFive
{
    public class Battle
    {
        public Fraction attacker;
        public Planet place;
        public List<Ship> attackers = new List<Ship>();
        public List<Ship> defenders = new List<Ship>();


        public Battle(Fraction attacker, Planet place, Ship sA, Ship sD)
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
                    throw new Exception("error");
                }


            }
            else if (defenders.Count < place.MaxCapacity())
            {
                defenders.Add(ship);
            }
            else { throw new Exception("error"); }


        }
        public void Fight()
        {
            Ship ships;
            bool ll;
            Ship ship;
            bool l;


            foreach (Ship s in attackers)
            {
                if (s.armor > 0)
                {
                    (ll, ships) = SearchTarget(defenders);
                    if (ll)
                    {
                        s.Attack(ships);

                    }
                }
            }
            foreach (Ship s in defenders)
            {

                if (s.armor > 0)
                {
                    (l, ship) = SearchTarget(attackers);

                    if (l)
                    {
                        s.Attack(ship);

                    }

                }
            }
        }
        public (bool, Ship) SearchTarget(List<Ship> opponent)
        {
            bool e = false;
            Ship sl = null;
            foreach (Ship s in opponent)
            {
                if (s.armor > 0)
                {
                    e = true;
                    sl = s;
                    return (e, sl);
                }
            }
            return (false, null);
        }

        public int DestroyedShips()
        {
            int sum1 = 0;
            int sum2 = 0;
            int SUM = 0;
            foreach (Ship s in attackers)
            {
                if (s.armor <= 0)
                {
                    sum1++;
                }
            }
            foreach (Ship S in defenders)
            {
                if (S.armor <= 0)
                {
                    sum2++;
                }
            }

            SUM = sum1 + sum2;
            return SUM;
        }
        public Fraction Attacker()
        {
            return attacker;
        }
        public Planet Place()
        {
            return place;
        }

        public (bool, int) Result(Fraction side)
        {
            int remainA = 0;
            int remainD = 0;
            bool l = false;

            foreach (Ship s in attackers)
            {
                if (s.armor > 0)
                {
                    remainA++;
                }
            }
            foreach (Ship S in defenders)
            {
                if (S.armor > 0)
                {
                    remainD++;
                }
            }
            if (side == attacker)
            {
                return ((remainA > 0 && remainD == 0), remainA);

            }

            return (remainD > 0 && remainA == 0, remainD);
        }


    }
}
