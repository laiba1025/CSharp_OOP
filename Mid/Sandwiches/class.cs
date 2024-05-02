using System;

using TextFile;

public class Data
{
	public string date;
	public string sandwich;
	public int sold;
	public Data(string date, string sandwich, int sold)
	{
		this.date = date;	
		this.sandwich = sandwich;	
		this.sold = sold;
	}
}
public class Tdata
{
	public string Date;
	public int count;
	public int moreThan;
}

public class infile
{

	enum Status
	{
		success, unSuccess
	};
	private TextFileReader X;
	private Data e;
	private Status st;
	private Tdata curr = new Tdata();
	private bool end;

	public infile(string FileName)
	{
		X = new TextFileReader(FileName);	
	}
	private void Read(ref Status st, ref TextFileReader X, ref Data e)
	{
		e = new Data("", "", 0);
		X.ReadString(out e.date);
		X.ReadString(out e.sandwich);
		if (X.ReadInt(out e.sold))
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
		Read(ref st, ref X, ref e);
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
		curr.Date = e.date;
		curr.count = 0;
		curr.moreThan = 0;	
		if (!end)
		{
			while (st == Status.success && curr.Date == e.date)
			{
				curr.count++;	
				if (e.sold > 1000)
				{
					curr.moreThan++;	
				}
				Read(ref st, ref X,ref e);	
			}
		}
	}
}