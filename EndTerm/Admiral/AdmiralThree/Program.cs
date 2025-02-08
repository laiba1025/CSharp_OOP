using System.Numerics;
using System;

namespace AdmiralProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("ship constructor: ");
                Corvette s = new Corvette(-1, 0, 0);
                Console.WriteLine("WRONG");
            }
            catch (Exception)
            {
                Console.WriteLine("OK");
            }
            try
            {
                Console.Write("star cruiser constructor: ");
                StarCruiser s = new StarCruiser(0, -1, 0);
                Console.WriteLine("WRONG");
            }
            catch (Exception)
            {
                Console.WriteLine("OK");
            }
            try
            {
                Console.Write("star cruiser constructor 2: ");
                StarCruiser s = new StarCruiser(0, 0, -1);
                Console.WriteLine("WRONG");
            }
            catch (Exception)
            {
                Console.WriteLine("OK");
            }
            try
            {
                Console.Write("star destroyer constructor: ");
                StarDestroyer s = new StarDestroyer(-1, 0, 0, 0);
                Console.WriteLine("WRONG");
            }
            catch (Exception)
            {
                Console.WriteLine("OK");
            }

            Corvette corv = new Corvette(19, 11, 3);
            Console.Write("corvette attributes: ");
            if (corv.Shield() == 11 && corv.Armor() == 19 && corv.Damage() == 3) Console.WriteLine("OK");
            else Console.WriteLine("WRONG");

            corv.TakeDamage(12);
            Console.Write("corvette TakeDamage: ");
            if (corv.Shield() == 0 && corv.Armor() == 18) Console.WriteLine("OK");
            else Console.WriteLine("WRONG");

            StarDestroyer starD = new(2, 9, 8, 1);
            Console.Write("starDestroyer attributes: ");
            if (starD.Shield() == 8 && starD.Armor() == 9 && starD.Damage() == 1) Console.WriteLine("OK");
            else Console.WriteLine("WRONG");
            Console.Write("star destroyer Attack: ");
            starD.Attack(corv);
            if (corv.Shield() == 0 && corv.Armor() == 16) Console.WriteLine("OK");
            else Console.WriteLine("WRONG");

            Corvette corv2 = new(9, 10, 1);
            Console.Write("corvette Attack: ");
            corv2.Attack(corv);
            if (corv.Shield() == 0 && corv.Armor() == 15) Console.WriteLine("OK");
            else Console.WriteLine("WRONG");

            StarCruiser starC = new(9, 10, 1);
            Console.Write("star cruiser attributes: ");
            if (starC.Shield() == 10 && starC.Armor() == 9 && starC.Damage() == 1) Console.WriteLine("OK");
            else Console.WriteLine("WRONG");
            Console.Write("star cruiser Attack: ");
            starC.Attack(corv);
            if (corv.Shield() == 0 && corv.Armor() == 13) Console.WriteLine("OK");
            else Console.WriteLine("WRONG");

            try
            {
                Console.Write("planet contructor: ");
                Planet planet = new("planet1", 0);
                Console.WriteLine("WRONG");
            }
            catch (Exception)
            {
                Console.WriteLine("OK");
            }
            Planet p = new("planet1", 2);
            Console.Write("planet attributes: ");
            if (p.Name() == "planet1" && p.MaxCapacity() == 4)
                Console.WriteLine("OK");
            else Console.WriteLine("WRONG");

            Battle battle = new(Fraction.Separatists, p, starD, corv);
            Console.Write("battle attributes: ");
            if (battle.Attacker() == Fraction.Separatists && battle.Place() == p)
                Console.WriteLine("OK");
            else Console.WriteLine("WRONG");


            Console.Write("battle fight: ");
            battle.Fight();
            if (corv.Shield() == 0 && corv.Armor() == 11 && starD.Shield() == 0 && starD.Armor() == 8)
                Console.WriteLine("OK");
            else Console.WriteLine("WRONG");
            Console.Write("battle result: ");
            int rep, sep;
            bool lr, ls;
            (lr, rep) = battle.Result(Fraction.Republic);
            (ls, sep) = battle.Result(Fraction.Separatists);

            Console.WriteLine((!lr && rep == 1 && !ls && sep == 1) ? "OK" : "WRONG");
            Console.Write("battle destroyedships: ");
            Console.WriteLine(battle.DestroyedShips() == 0 ? "OK" : "WRONG");

            Console.Write("battle fight 2: ");
            battle.Reinforcement(Fraction.Separatists, starC);
            battle.Reinforcement(Fraction.Separatists, corv2);
            battle.Fight(); //
            if (corv.Shield() == 0 && corv.Armor() == 6 && starD.Shield() == 0 && starD.Armor() == -1)
                Console.WriteLine("OK");
            else Console.WriteLine("WRONG");
            Console.Write("battle result 2: ");

            (lr, rep) = battle.Result(Fraction.Republic);
            (ls, sep) = battle.Result(Fraction.Separatists);
            Console.WriteLine((!lr && rep == 1 && !ls && sep == 2) ? "OK" : "WRONG");

            Console.Write("battle destroyedships 2: ");
            Console.WriteLine(battle.DestroyedShips() == 1 ? "OK" : "WRONG");

            corv.TakeDamage(4);
            Console.Write("battle fight 3: ");
            battle.Fight();
            if (corv.Shield() == 0 && corv.Armor() == 0 && starC.Shield() == 10 && starC.Armor() == 9 &&
                corv2.Shield() == 10 && corv2.Armor() == 9)
                Console.WriteLine("OK");
            else Console.WriteLine("WRONG");
            Console.Write("battle result 3: ");
            (lr, rep) = battle.Result(Fraction.Republic);
            (ls, sep) = battle.Result(Fraction.Separatists);
            Console.WriteLine((!lr && rep == 0 && ls && sep == 2) ? "OK" : "WRONG");

            Console.Write("battle destroyedships 3: ");
            Console.WriteLine(battle.DestroyedShips() == 2 ? "OK" : "WRONG");
            battle.Reinforcement(Fraction.Separatists, corv);
            try
            {
                Console.Write("battle reinforcement: ");
                battle.Reinforcement(Fraction.Separatists, corv);
                Console.WriteLine("WRONG");
            }
            catch (Exception)
            {
                Console.WriteLine("OK");
            }
        }
    }
}
