using System;
using System.Globalization;
using TextFile;


namespace program {
	public class Data
	{
		public int round;
		public string name;
		public int score;

		public Data(int round, string name	, int score)
		{
			this.round = round;
			this.name = name;
			this.score = score;
		}
	}
	public class tdata
	{
		public int Round;
		public int score;
		public int count;
	}

	public class infile
	{
		enum Status { success, unSuccess}

		TextFileReader X;
		Data e;
		tdata curr = new tdata();
		bool end;
		Status st;


		private void Read(ref TextFileReader X, ref Status st, ref Data e)
		{
			e = new Data(0, "", 0);
			X.ReadInt(out e.round);
			X.ReadString(out e.name);
			if (X.ReadInt(out e.score))
			{
				st = Status.success;
			}
			else 
			{
				st = Status.unSuccess;	
			}

		}

		public  infile(string FileName)
		{
			X = new TextFileReader(FileName);	
		}

		public void First()
		{
			Read(ref X, ref st, ref e);
			Next();
		}

		public tdata Current()
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
			curr.count = 0;
			curr.Round = e.round;
			curr.score = 0;

			if (!end) 
			{
				while (st == Status.success && (curr.Round  == e.round) )
				{
					curr.count ++;
					if (e.score == 10)
					{
						curr.score++;
					}
					Read(ref X, ref st, ref e);	

				}
            }
			
		}
	}
}