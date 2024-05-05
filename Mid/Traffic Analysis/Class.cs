using System;
using System.Data;
using TextFile;
using static Program.Data;

namespace Program
{
	public class Data
	{
		public int month;
		public int day;
		public int vehicles;
		public Data(int month, int day, int vehicles)
		{
			this.month = month;
			this.day = day;
			this.vehicles = vehicles;
		}
		public class Tdata
		{
			public int month;
			public int Tvehicles;
		}
	}

    public class Infile
    {
        enum Status
        {
            success, unSuccess
        };

        private TextFileReader X;
        private Data e;
        private Tdata curr = new Tdata();
        bool end;
        Status st;

        public Infile(string FileName)
        {
            X = new TextFileReader(FileName);
        }

        private void Read(ref TextFileReader X, ref Status st, ref Data e)
        {
            e = new Data(0, 0, 0);
            X.ReadInt(out e.month);
            X.ReadInt(out e.day);
            if (X.ReadInt(out e.vehicles))
            {
                st = Status.success;
            }
            else
            {
                st = Status.unSuccess;
            }

        }

        public void First()
        {
            Read(ref X, ref st, ref e);
            Next();
        }
        public bool End()
        {
            return end;
        }
        public Tdata Current()
        {
            return curr;
        }

        public void Next()
        {
            end = st == Status.unSuccess;
            curr.month = e.month;
            curr.Tvehicles = 0;

            if (!end)
            {
                while (st == Status.success && curr.month == e.month)
                {
                    curr.Tvehicles += e.vehicles;
                    Read(ref X, ref st, ref e);
                }
                Console.WriteLine(curr.Tvehicles);
            }
        }
    }
}