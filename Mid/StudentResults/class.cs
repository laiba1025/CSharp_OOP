using System;
using TextFile;

namespace program
{
	public class Data
	{
		public string stdId;
		public int grade;

        public Data(string stdtId, int grade)
        {
            this.stdId = stdtId;
			this.grade = grade;
        }
    }

	public class tData
	{
		public string St_Id;
	    public int attempts;
	}


	public class Data2
	{
		enum Status
		{
			Success, unSuccess
		};
		TextFileReader X;
		Status st;
		tData curr = new tData();
		bool end;
		Data e;

		private void Read(ref TextFileReader X, ref Status st, ref Data e)
		{
			e = new Data("", 0);
			X.ReadString(out e.stdId);
			if (X.ReadInt(out e.grade))
			{
				st = Status.Success;
			}
			else
			{
				st = Status.unSuccess;
			}

		}

		public Data2(string fileName)
		{
			X = new TextFileReader(fileName);	
		}

		public tData Current()
		{
			return curr;
		}
		public bool End()
		{
			return end;
		}

		public void First()
		{
			Read (ref X, ref st, ref e);
			Next();
		} 
		public void Next()
		{
			end = st == Status.unSuccess;
			curr.St_Id = e.stdId;
			curr.attempts= 0;
			if (!end)
			{
				while (st == Status.Success && curr.St_Id == e.stdId)
				{
					curr.attempts ++;
					Read(ref X, ref st, ref e);
					
				}
			}
		}
	}

}