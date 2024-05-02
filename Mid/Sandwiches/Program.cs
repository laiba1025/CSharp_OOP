using System.Globalization;

namespace Sandwiches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter File Name");
            string FileName = Console.ReadLine();
            infile t = new infile(FileName);
            string Day = "";

            t.First();

            while (!t.End())
            {
                if (t.Current().count == t.Current().moreThan)
                {
                    Day = t.Current().Date; 

                }
                t.Next();   
            }
            Console.WriteLine(Day);
        }
    }
}
