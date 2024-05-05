using Program;
using System.Globalization;

namespace Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter FileName");
            string FileName = Console.ReadLine();
            Infile t = new Infile(FileName);    
            int highest = int.MinValue;
            int month = 0;

            t.First();

            while (!t.End())
            {
                if (t.Current().Tvehicles > highest)
                {
                    highest = t.Current().Tvehicles; 
                    month = t.Current().month;

                }
                t.Next();   
            }
            Console.WriteLine(month);

            
        }
    }
}
