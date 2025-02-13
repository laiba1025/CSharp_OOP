namespace PackOpening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Card constructor 1: ");
                Defender d = new Defender(-1, 0, 0, 0, null);
                Console.WriteLine("WRONG");
            }
            catch (Exception)
            {
                Console.WriteLine("OK");
            }
            try
            {
                Console.Write("Card constructor 2: ");
                Attacker d = new Attacker(0, -1, 0, 0, null);
                Console.WriteLine("WRONG");
            }
            catch (Exception)
            {
                Console.WriteLine("OK");
            }
            try
            {
                Console.Write("Card constructor 3: ");
                Midfielder d = new Midfielder(0, 0, -1, 0, null);
                Console.WriteLine("WRONG");
            }
            catch (Exception)
            {
                Console.WriteLine("OK");
            }
            try
            {
                Console.Write("Card constructor 4: ");
                Defender d = new Defender(0, 0, 0, -1, null);
                Console.WriteLine("WRONG");
            }
            catch (Exception)
            {
                Console.WriteLine("OK");
            }

            MyClub club = new MyClub();

            Console.Write("Club avg empty: ");
            Console.WriteLine((club.AverageRating() == 0) ? "OK" : "WRONG");
            Console.Write("Club ENGcount empty: ");
            Console.WriteLine((club.EnglishPlayerCount() == 0) ? "OK" : "WRONG");
            Console.Write("Club ENGplays empty: ");
            Console.WriteLine((club.AllEnglishPlayers().Count == 0) ? "OK" : "WRONG");
            Console.Write("Club expPl empty: ");
            Console.WriteLine((!club.ExpensivePlayer()) ? "OK" : "WRONG");

            Attacker brs1 = new Attacker(0, 0, 0, 1, new Player("brasil1", Nation.BRASIL));
            Console.Write("Attacker rating: ");
            Console.WriteLine((brs1.Rating() == 1) ? "OK" : "WRONG");
            Console.Write("Attacker type: ");
            Console.WriteLine((brs1.GetType() == "attacker") ? "OK" : "WRONG");
            Console.Write("Attacker nat: ");
            Console.WriteLine((brs1.GetPlayer().Nat() == Nation.BRASIL) ? "OK" : "WRONG");
            Console.Write("Attacker name: ");
            Console.WriteLine((brs1.GetPlayer().Name() == "brasil1") ? "OK" : "WRONG");

            club.JoinMyClub(brs1);
            Console.Write("Club avg 1brasil: ");
            Console.WriteLine((club.AverageRating() == 1) ? "OK" : "WRONG");
            Console.Write("Club ENGcount 1brasil: ");
            Console.WriteLine((club.EnglishPlayerCount() == 0) ? "OK" : "WRONG");
            Console.Write("Club ENGplays 1brasil: ");
            Console.WriteLine((club.AllEnglishPlayers().Count == 0) ? "OK" : "WRONG");
            Console.Write("Club expPl 1brasil: ");
            Console.WriteLine((!club.ExpensivePlayer()) ? "OK" : "WRONG");

            Defender esp1 = new Defender(0, 2, 0, 0, new Player("spanish1", Nation.SPAIN));
            Console.Write("Defender rating: ");
            Console.WriteLine((esp1.Rating() == 2) ? "OK" : "WRONG");
            Console.Write("Defender type: ");
            Console.WriteLine((esp1.GetType() == "defender") ? "OK" : "WRONG");
            Console.Write("Defender nat: ");
            Console.WriteLine((esp1.GetPlayer().Nat() == Nation.SPAIN) ? "OK" : "WRONG");
            Console.Write("Defender name: ");
            Console.WriteLine((esp1.GetPlayer().Name() == "spanish1") ? "OK" : "WRONG");

            club.JoinMyClub(esp1);
            Console.Write("Club avg 2: ");
            Console.WriteLine((club.AverageRating() == 1.5) ? "OK" : "WRONG");
            Console.Write("Club ENGcount 2: ");
            Console.WriteLine((club.EnglishPlayerCount() == 0) ? "OK" : "WRONG");
            Console.Write("Club ENGplays 2: ");
            Console.WriteLine((club.AllEnglishPlayers().Count == 0) ? "OK" : "WRONG");
            Console.Write("Club expPl 2: ");
            Console.WriteLine((!club.ExpensivePlayer()) ? "OK" : "WRONG");

            Midfielder eng1 = new Midfielder(0, 0, 3, 0, new Player("english1", Nation.ENGLAND));
            Console.Write("Midfielder rating: ");
            Console.WriteLine((eng1.Rating() == 3) ? "OK" : "WRONG");
            Console.Write("Midfielder type: ");
            Console.WriteLine((eng1.GetType() == "midfielder") ? "OK" : "WRONG");
            Console.Write("Midfielder nat: ");
            Console.WriteLine((eng1.GetPlayer().Nat() == Nation.ENGLAND) ? "OK" : "WRONG");
            Console.Write("Midfielder name: ");
            Console.WriteLine((eng1.GetPlayer().Name() == "english1") ? "OK" : "WRONG");

            club.JoinMyClub(eng1);
            Console.Write("Club avg 3: ");
            Console.WriteLine((club.AverageRating() == 2) ? "OK" : "WRONG");
            Console.Write("Club ENGcount 3: ");
            Console.WriteLine((club.EnglishPlayerCount() == 1) ? "OK" : "WRONG");
            Console.Write("Club ENGplays 3: ");
            Console.WriteLine((club.AllEnglishPlayers()[0]=="english1") ? "OK" : "WRONG");
            Console.Write("Club expPl 3: ");
            Console.WriteLine((!club.ExpensivePlayer()) ? "OK" : "WRONG");

            Midfielder eng2 = new Midfielder(1000000, 0, 4, 0, new Player("english2", Nation.ENGLAND));
            club.JoinMyClub(eng2);
            Console.Write("Club expPl 4: ");
            Console.WriteLine((!club.ExpensivePlayer()) ? "OK" : "WRONG");
            Console.Write("Club ENGcount 3: ");
            Console.WriteLine((club.EnglishPlayerCount() == 2) ? "OK" : "WRONG");
            Console.Write("Club ENGplays 3: ");
            Console.WriteLine((club.AllEnglishPlayers()[0] == "english1" && club.AllEnglishPlayers()[1] == "english2") ? "OK" : "WRONG");
            Console.Write("Club expPl 4: ");
            Console.WriteLine((!club.ExpensivePlayer()) ? "OK" : "WRONG");

            Defender esp2 = new Defender(1000001, 5, 0, 0, new Player("spanish2", Nation.SPAIN));
            club.JoinMyClub(esp2);
            Console.Write("Club avg 5: ");
            Console.WriteLine((club.AverageRating() == 3) ? "OK" : "WRONG");
            Console.Write("Club expPl 5: ");
            Console.WriteLine((club.ExpensivePlayer()) ? "OK" : "WRONG");
            Console.Write("Club ENGcount 5: ");
            Console.WriteLine((club.EnglishPlayerCount() == 2) ? "OK" : "WRONG");
            Console.Write("Club ENGplays 5: ");
            Console.WriteLine((club.AllEnglishPlayers()[0] == "english1" && club.AllEnglishPlayers()[1] == "english2") ? "OK" : "WRONG");
            Console.Write("Club expPl 5: ");
            Console.WriteLine((club.ExpensivePlayer()) ? "OK" : "WRONG");

            Defender esp3 = new Defender(1000000, 5, 0, 0, new Player("spanish3", Nation.SPAIN));
            club.JoinMyClub(esp3);
            Console.Write("Club expPl 6: ");
            Console.WriteLine((club.ExpensivePlayer()) ? "OK" : "WRONG");

            MyClub club2 = new MyClub();
            club2.JoinMyClub(esp2);
            Console.Write("Club expPl 7: ");
            Console.WriteLine((club.ExpensivePlayer()) ? "OK" : "WRONG");

            club2.JoinMyClub(eng2);
            club2.JoinMyClub(esp1);
            Console.Write("Club expPl 8: ");
            Console.WriteLine((club.ExpensivePlayer()) ? "OK" : "WRONG");
        }
    }
}
