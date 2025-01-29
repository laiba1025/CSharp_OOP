using SpartanFive;

namespace SpartanFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("competition constructor check: ");
                List<Category> cat = new();
                Competition comp = new(2009, "salgo", cat);
                Console.WriteLine("WRONG");
            }
            catch (Exception)
            {
                Console.WriteLine("OK - zero categories");
            }
            try
            {
                Console.Write("competition constructor check: ");
                List<Category> cat = new();
                cat.Add(Sprint.Instance());
                Competition comp = new(1999, "salgo", cat);
                Console.WriteLine("WRONG");
            }
            catch (Exception)
            {
                Console.WriteLine("OK - too small year");
            }
            try
            {
                Console.Write("competition register check: ");
                List<Category> cat = new();
                cat.Add(Sprint.Instance());
                Competition comp = new(2009, "salgo", cat);
                comp.Register(new Competitor(1, "", true));
                comp.Register(new Competitor(1, "", true));
                Console.WriteLine("WRONG");
            }
            catch (Exception)
            {
                Console.WriteLine("OK - existing ID");
            }
            try
            {
                Console.Write("competition score check: ");
                List<Category> cat = new();
                cat.Add(Sprint.Instance());
                Competition comp = new(2009, "salgo", cat);
                comp.Register(new Competitor(1, "", true));
                comp.Score(1, 1, 1, Super.Instance());
                Console.WriteLine("WRONG");
            }
            catch (Exception)
            {
                Console.WriteLine("OK - nonexisting category");
            }
            try
            {
                Console.Write("competition score check: ");
                List<Category> cat = new();
                cat.Add(Sprint.Instance());
                Competition comp = new(2009, "salgo", cat);
                comp.Register(new Competitor(1, "", true));
                comp.Score(1, 1, 2, Sprint.Instance());
                Console.WriteLine("WRONG");
            }
            catch (Exception)
            {
                Console.WriteLine("OK - nonexisting ID");
            }
            try
            {
                Console.Write("competition score check: ");
                List<Category> cat = new();
                cat.Add(Sprint.Instance());
                Competition comp = new(2009, "salgo", cat);
                comp.Register(new Competitor(1, "", true));
                comp.Score(1, 1, 1, Sprint.Instance());
                comp.Score(1, 2, 1, Sprint.Instance());
                Console.WriteLine("WRONG");
            }
            catch (Exception)
            {
                Console.WriteLine("OK - existing ID");
            }
            try
            {
                Console.Write("competitor constructor check: ");
                Competitor comp = new(-2, "", true);
                Console.WriteLine("WRONG");
            }
            catch (Exception)
            {
                Console.WriteLine("OK - negative ID");
            }
            try
            {
                Console.Write("result constructor check: ");
                Result res = new(-2, 2, null, null);
                Console.WriteLine("WRONG");
            }
            catch (Exception)
            {
                Console.WriteLine("OK - negative min");
            }
            try
            {
                Console.Write("result constructor check: ");
                Result res = new(2, -2, null, null);
                Console.WriteLine("WRONG");
            }
            catch (Exception)
            {
                Console.WriteLine("OK - negative sec");
            }
            try
            {
                Console.Write("result constructor check: ");
                Result res = new(2, 60, null, null);
                Console.WriteLine("WRONG");
            }
            catch (Exception)
            {
                Console.WriteLine("OK - too big sec");
            }
            List<Category> cat2 = new();
            cat2.Add(Sprint.Instance());
            cat2.Add(Super.Instance());
            Competition comp2 = new(2001, "Salgotarjan", cat2);
            List<Competitor> competitors = new();
            competitors.Add(new Competitor(1, "A", true)); comp2.Register(competitors[0]);
            competitors.Add(new Competitor(2, "B", true)); comp2.Register(competitors[1]);
            competitors.Add(new Competitor(3, "C", true)); comp2.Register(competitors[2]);
            competitors.Add(new Competitor(4, "D", false)); comp2.Register(competitors[3]);
            competitors.Add(new Competitor(5, "E", false)); comp2.Register(competitors[4]);
            competitors.Add(new Competitor(6, "F", false)); comp2.Register(competitors[5]);
            Console.WriteLine("Popular empty: " + (comp2.PopularCat().Type() == "sprint" ? "OK" : "WRONG"));
            bool l;
            Competitor winner;
            comp2.Score(10, 8, 4, Super.Instance());
            comp2.Score(10, 8, 4, Sprint.Instance());
            Console.WriteLine("not IsWinner 0: " + (!competitors[0].IsWinner(Super.Instance()) ? "OK" : "WRONG"));
            Console.WriteLine("IsWinner 1: " + (competitors[3].IsWinner(Super.Instance()) ? "OK" : "WRONG"));

            (l, winner) = comp2.Winner(Sprint.Instance(), true);
            Console.WriteLine("Winner empty: " + (l ? "WRONG" : "OK"));

            comp2.Score(10, 10, 1, Sprint.Instance());
            comp2.Score(20, 10, 1, Super.Instance());
            Console.WriteLine("Popular 1: " + (comp2.PopularCat().Type() == "sprint" ? "OK" : "WRONG"));
            (l, winner) = comp2.Winner(Sprint.Instance(), true);
            Console.WriteLine("Winner 1: " + ((l && winner.ID() == 1) ? "OK" : "WRONG"));

            Console.WriteLine("not IsWinner 0: " + (!competitors[2].IsWinner(Super.Instance()) ? "OK" : "WRONG"));
            Console.WriteLine("IsWinner 1: " + (competitors[0].IsWinner(Super.Instance()) ? "OK" : "WRONG"));

            comp2.Score(10, 9, 2, Super.Instance());
            Console.WriteLine("Popular super: " + (comp2.PopularCat().Type() == "super" ? "OK" : "WRONG"));
            (l, winner) = comp2.Winner(Super.Instance(), true);
            Console.WriteLine("Winner 2: " + ((l && winner.ID() == 2) ? "OK" : "WRONG"));
            Console.WriteLine("IsWinner 2: " + (competitors[3].IsWinner(Super.Instance()) ? "OK" : "WRONG"));

            Console.WriteLine("not IsWinner 2: " + (!competitors[0].IsWinner(Super.Instance()) ? "OK" : "WRONG"));
        }
    }
}
