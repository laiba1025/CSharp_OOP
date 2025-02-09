﻿using TextFile;

using endtermpractice;

namespace Endterm
{
    class Program
    {

        static void Main()
        {
            (City v, Wonder l, int index) = Read();
            TestRun3(v, l, index);
        }

        static (City, Wonder, int) Read()
        {
            TextFileReader reader = new("input.txt");

            reader.ReadInt(out int distInd);
            reader.ReadInt(out int X);
            reader.ReadInt(out int Y);


            Wonder actWonder = null;
            List<District> ds = new List<District>();

            while (reader.ReadString(out string distName))
            {
                reader.ReadInt(out int count);
                List<Wonder> ws = new List<Wonder>();
                for (int i = 0; i < count; i++)
                {
                    reader.ReadString(out string wondType);
                    reader.ReadInt(out int wondX);
                    reader.ReadInt(out int wondY);
                    reader.ReadInt(out int wondInt);
                    reader.ReadInt(out int wondBuilt);

                    Wonder wonder;
                    switch (wondType)
                    {
                        case "museum":
                            wonder = new Museum(wondX, wondY, wondInt, wondBuilt);
                            break;
                        case "cathedral":
                            wonder = new Cathedral(wondX, wondY, wondInt, wondBuilt);
                            break;
                        case "castle":
                            wonder = new Castle(wondX, wondY, wondInt, wondBuilt);
                            break;
                        default:
                            throw new ArgumentException("Invalid wonder in the file!");
                    }
                    if (wonder.X == X && wonder.Y == Y)
                        actWonder = wonder;

                    ws.Add(wonder);
                }
                ds.Add(new District(distName, ws));

            }
            return (new City(ds), actWonder, distInd);
        }

        static void TestRun3(City v, Wonder l, int index)
        {
            Console.Write($"{v.ds[index].MaxDistance()} {v.WhichDistrict(l).name}");
        }
    }
}