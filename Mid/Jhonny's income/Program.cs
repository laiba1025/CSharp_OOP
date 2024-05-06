namespace exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the NAME");
            string FileName = Console.ReadLine();
            Infile t = new Infile(FileName);
            string isChina = "yes";
            t.First();
            while (!t.End())
            {
                Console.WriteLine(t.Current().income);
                if (t.Current().income < 30000 )
                {
                    isChina = "no";
                    break;
                }

                t.Next();
            }
            Console.WriteLine(isChina);

        }
    }
}
