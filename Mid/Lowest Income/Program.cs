using Program;

namespace TelefonKFT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter FileName");
                string FileName = Console.ReadLine()!;
                infile t = new infile(FileName);
                string isTelenorKft = "No";

                t.First();

                while (!t.End())
                {
                    if (t.Current().Payment == 0)
                    {
                        isTelenorKft = "Yes";
                        break;
                    }
                    t.Next();   
                }
                Console.WriteLine(isTelenorKft);

            } 
            catch ( FileNotFoundException)
            { 
                Console.WriteLine(" file not found");

            }



        }
    }
}
