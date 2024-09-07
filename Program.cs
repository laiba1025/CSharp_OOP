using dataFile;
using System;
using TextFile;

namespace EasySem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the FileName");
            string FileName = Console.ReadLine();
            Data2 t = new Data2(FileName);
            
            string Easiest_Semester = "";
            int Least_hours = int.MaxValue;    
            t.First();
            while (!t.End())
            {
                if (Least_hours > t.Current().hours1)
                {
                    Least_hours = t.Current().hours1;
                    Easiest_Semester = t.Current().date1;
                }
                t.Next();
            }
            Console.WriteLine(Easiest_Semester);
            
            
           
        }
    }
}
