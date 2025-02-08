using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using AdmiralFive;

namespace AdmiralFive
{
    public class Simulation
    {
        public List<Battle> battles = new List<Battle>();
        public List<Ship> sa = new List<Ship>();
        //public List<Ship> sd = new List<Ship>(); 

        public Simulation()
        {



        }
        public void Run(int n)
        {
            for (int i = 0; i < n; i++)
            {
                foreach (Battle b in battles)
                {
                    b.Fight();

                }
            }
        }
        public void NewBattle(Fraction side, Planet place, Ship sA, Ship sD)
        {

            foreach (Battle b in battles)
            {
                bool l;
                if (b.place == place)
                {
                    l = true;

                    if (l)
                    {
                        throw new Exception();
                    }


                }
            }
            Battle newB = new Battle(side, place, sA, sD);
            battles.Add(newB);
        }
        public void Reinforcement(Fraction side, Planet place, List<Ship> ships)
        {
            bool l = false;
            Battle elem;
            foreach (Battle b in battles)
            {
                if (b.place == place)
                {
                    l = true;
                    elem = b;
                    if (l)
                    {
                        foreach (Ship s in ships)
                        {
                            elem.Reinforcement(side, s);
                        }
                    }
                    else
                    {
                        throw new Exception();
                    }
                }

            }
        }
        public int DestroyedShips(string place)
        {
            int i = 0;
            foreach (Battle b in battles)
            {
                //  b.DestroyedShips(); 
                if (b.place.name == place)
                {

                    i = i + b.DestroyedShips();
                }
            }
            return i;

        }
        public Planet SweepingVictory(Fraction side)
        {
            int max = 0;
            int max2 = 0;
            bool l = false;
            bool l2 = false;
            int ind = 0;
            for (int i = 0; i < battles.Count; i++)
            {
                (l, max) = battles[i].Result(side);
                if (max > max2)
                {
                    //(l2,max2)= battles[i ].Result(side); 
                    max = max2;
                    ind = i;
                }
                if (l)
                {
                    return battles[ind].place;
                }



            }
            return null;
        }

    }
}