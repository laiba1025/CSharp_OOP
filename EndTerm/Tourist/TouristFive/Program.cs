using System.Diagnostics;
using TextFile;

namespace Tourist_Exam
{
    internal class Program
    {

        private static City init(string filename)
        {
            TextFileReader rd = new TextFileReader(filename);

            int districtNum = int.Parse(rd.ReadLine());

            List<District> tempDistrict = new List<District>();

            for (int i = 0; i < districtNum; i++)
            {
                string[] line = rd.ReadLine().Split(" ");

                string distName = line[0];
                int wonderCount = int.Parse(line[1]);

                List<Wonder> ws = new List<Wonder>();
                for (int j = 0; j < wonderCount; j++)
                {
                    string line1 = rd.ReadLine();

                    string[] line2 = line1.Split(" ");
                    string nameTemp = line2[0];
                    int x = int.Parse(line2[1]);
                    int y = int.Parse(line2[2]);
                    int interest = int.Parse(line2[3]);
                    int b = int.Parse(line2[4]);

                    switch (nameTemp)
                    {

                        case "Museum":
                            ws.Add(new Museum(x, y, interest, b)); break;
                        case "Castle":
                            ws.Add(new Castle(x, y, interest, b)); break;
                        case "Cathedral":
                            ws.Add(new Cathedral(x, y, interest, b)); break;

                        default: break;
                    }


                    switch (line2[5]) 
                    {
                        case "n":
                            break;
                        case "y":
                            ws[i].setGuide(new Guide(line2[6], int.Parse(line2[7])));
                            break;

                        default: break;
                        
                    }



                }

                District District = new District(ws, distName);

                tempDistrict.Add(District);


            }

            City CITY = new City(tempDistrict);

            return CITY;
        }
        static void Main(string[] args)
        {

            City CITY = init("input.txt");
           

            Wonder temp = new Museum(3, 1, 12, 1927);
            District d = CITY.WhichDistrict(temp);

            Console.WriteLine(d.name);

            Console.WriteLine(CITY.ds[0].MaxDistance());

            Console.WriteLine(CITY.MaxTotalTime().name);

            Console.WriteLine(CITY.CathedralEverywhere());

            
            


        }
    }
}