using program;

namespace Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of File");
            string FileName = Console.ReadLine();   
            infile t = new infile(FileName);
            String allStrike = "No";
            t.First();

            while (!t.End())
            {
                if (t.Current().count == t.Current().score) 
                {
                   allStrike = "Yes";   
                    break;
                }
                t.Next();   
            }
            Console.WriteLine(allStrike);
        }
    }
}
