using program;

namespace StudentAttempt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the File Name");
            string fileName = Console.ReadLine();
            Data2 t = new Data2(fileName);
            int Num_Attempts = 0;
            t.First();

            while (!t.End())
            {
                if (Num_Attempts < t.Current().attempts)
                {
                    Num_Attempts = t.Current().attempts;
                }
                t.Next();
            }
            Console.WriteLine(Num_Attempts);
        }
    }
}
