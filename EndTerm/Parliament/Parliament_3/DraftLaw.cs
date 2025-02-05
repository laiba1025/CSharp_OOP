using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parliament
{
    public abstract class DraftLaw
    {
        public String date;
        public String ID;
        public List<bool> votes = new List<bool>();
        public Parliament parliament;
        public List<Congressman> cmen = new List<Congressman>();    

        public DraftLaw(string d, string ID)
        {
            this.date = d;
            this.ID = ID;
        }   

        public int YesCount()
        { 
            int sum = 0;    
            foreach(bool e in votes) 
            {
                if (e)
                {
                    sum++;
                }
            }
            return sum ; 
        }

        public virtual bool IsValid()
        {
            return false;
        }
    }

    public class Normal : DraftLaw
    {
        public Normal(String d, String ID) : base(d, ID) { }

        public override bool IsValid ()
        {
            return (YesCount() * 2 > votes.Count());
        }
    }

    public class Cardinal : DraftLaw
    {
        public Cardinal(String d, String ID) : base(d, ID) { }

        public override bool IsValid()
        {
            if (parliament == null)
            {
                return false ;
            }
            else
            {
                return (YesCount() * 2 > parliament.cmen.Count());
            }
        }
    }

    public class Constitutional : DraftLaw
    {
        public Constitutional(String d, String ID) : base(d, ID) { }

        public override bool IsValid()
        {
            if (parliament == null  || parliament.cmen.Count() == 0)
            {
                return false;
            }
            return (YesCount() *3 >= parliament.cmen.Count() * 2);
        }

    }
}
