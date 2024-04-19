using System;
using TextFile;

namespace Program
{
	public class Data
	{
		public int month;
		public string name;
		public int payment;
		public Data(int month, string name, int payment)
		{
			this.month = month;
			this.name = name;
			this.payment = payment;
		}

	}

	public class Tdata
	{
		public int Month;
		public int Payment;

	}

	public class infile
	{
		enum Status
		{
			success, unsuccess
		};

		TextFileReader X;
		Data e;
		Status st;
		Tdata curr = new Tdata();
		bool end;

		private void Read(ref TextFileReader X, ref Status st, ref Data e)
		{
			e = new Data(0, "", 0);
			X.ReadInt(out e.month);
			X.ReadString(out e.name);
			if (X.ReadInt(out e.payment))
			{
				st = Status.success;
			}
			else
			{
				st = Status.unsuccess;
			}
		}

		public infile(string FileName)
		{
			X = new TextFileReader(FileName);
		}

		public void First()
		{
			Read(ref X, ref st, ref e);
			Next();
		}
		public Tdata Current()
		{
			return curr;
		}
		public bool End()
		{
			return end;
		}

		public void Next()
		{
			end = st == Status.unsuccess;
			curr.Month = e.month;
			curr.Payment = 0;

			if (!end)
			{
				while (st == Status.success && curr.Month == e.month)
				{
					if (e.name == "TelenorKft" && e.payment > 0)
					{
						curr.Payment++;	
						Console.WriteLine(curr.Payment);
					}
                    Read(ref X, ref st, ref e);
                }
			}
		}
	}
}
