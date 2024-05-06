using System;
using System.Globalization;
using System.Runtime.Serialization;
using TextFile;
public class Class1
{
    public int month;
	public string name;
	public int income;

	public Class1(int month, string name, int income)
	{
		this.month = month;	
		this.name = name;	
		this.income = income;	
	}

}

public class Tdata
{
	public int month;	
	public string Name;	
	public int income;	
}

public class Infile
{
	enum Status
	{
		success, unsuccess
	};

	TextFileReader X;
	Class1 e;
	Tdata curr = new Tdata();
	bool end;
	Status st;


	private void Read(ref TextFileReader X, ref Status st, ref Class1 e)
	{
		e = new Class1(0, "", 0);
        X.ReadInt(out e.month);
        X.ReadString(out e.name);
        if (X.ReadInt(out e.income))
        {
            st = Status.success;
        }
        else
        {
            st = Status.unsuccess;
        }

    }
	public Infile(string FileName)
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
		curr.month = e.month;
		curr.month = 0;
		
		if (!end)
		{
			while (st == Status.success && curr.month == e.month)
			{
				if (e.name == "Jhon")
				{
					curr.income += e.income; 
				} Read(ref X, ref st, ref e);	
			}
		}
	}
}
