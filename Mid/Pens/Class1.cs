using More_Pens;
using System;

namespace program
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter File Name");
            string filename = Console.ReadLine();   
            infile t = new infile(filename);
            t.First();
            string maxPens = "";
            while (!t.End())
            {
                if (t.Current().tCount > 70)
                {
                    maxPens = t.Current().penName;
                }
                t.Next();
            }
            Console.WriteLine(maxPens);
        }
    }
}   
