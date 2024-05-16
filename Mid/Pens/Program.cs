using TextFile;
using System;

namespace More_Pens 
{
    public class Data
    {
        public string brand;
        public string color;
        public int count;


        public Data(string brand, string color, int count)
        {
            this.brand = brand;
            this.color = color;
            this.count = count;
        }
    }
    public class fData
    {
        public string penName;
        public int tCount;
    }

    public class infile
    {
        public enum Status 
        {
            norm, abnorm
        };

        private TextFileReader X;
        private Data e;
        private fData curr = new fData();
        private bool end;
        private Status st;

        private static void Read(ref Status st, ref TextFileReader X, ref Data e)
        {
            e = new Data("", "", 0);
            X.ReadString(out e.brand);
            X.ReadString (out e.color);
            if (X.ReadInt(out e.count))
            {
                st = infile.Status.norm;
            }
            else
            {
                st = infile.Status.abnorm;
            }
        }
        public infile( string filename)
        {
            X = new TextFileReader(filename);
        }

        public fData Current()
        {
            return curr;
        }
        public bool End()
        {
            return end;
        }

    
        public void First ()
        {
            Read(ref st, ref X, ref e);

            Next();
        }

        public void Next()
        {
            end = st == Status.abnorm;
            curr.penName = e.brand;
            curr.tCount =0;

            if (!end)
            {
                while (st == Status.norm && curr.penName == e.brand)
                {
                    curr.tCount += e.count;
                    Read (ref st, ref X, ref e);    
                }
            }
        }
    }


}