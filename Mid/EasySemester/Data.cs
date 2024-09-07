using System;
using System.Globalization;
using TextFile;

namespace dataFile
{
	public class Data
	{
		public string date;
		public string neptun;
		public int hours;

		public Data(string date, string neptun, int hours)
		{
			this.date = date;
			this.neptun = neptun;
			this.hours = hours;
		}
	}
    public class fData
	{
		public string date1;
	    public int hours1;
	}

	class Data2
	{
		public enum Status 
		{
			Success,
			unSuccess,
		};

		private TextFileReader X;
		private Status st;
		private fData curr = new fData();
		private bool end;
		private Data e;

		public Data2(string fileName)
		{
			X = new TextFileReader(fileName);	
		}

		private void Read(ref Status st, ref Data e, ref TextFileReader X)
		{
			e = new Data("", "", 0);
			X.ReadString(out e.date);	
			X.ReadString(out e.neptun);
			if (X.ReadInt(out e.hours))
			{
				st = Status.Success;
			}
			else
			{
				st = Status.unSuccess;
			}
			
		}

		public void First()
		{
			Read (ref st, ref e, ref X);
			Next();
		}
		public fData Current()
		{
			return curr;
		}
		public bool End()
		{
			return end;
		}

		public void Next()
		{
			end = st == Status.unSuccess;
			curr.date1 = e.date;
			curr.hours1 = 0;
			if (!end)
			{
				while (st == Status.Success && (curr.date1 == e.date))
				{
					curr.hours1 += e.hours;
					Read(ref st, ref e, ref X);
				}
			}
		}
	}
}
