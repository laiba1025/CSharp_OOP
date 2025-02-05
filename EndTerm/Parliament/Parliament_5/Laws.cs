using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH_Parlament
{
    public abstract class DraftLaw
    {
        public string date;
        public string ID;
        public List<bool> votes;
        public List<Congressman> cmen;
        public Parliament parliament;

        protected DraftLaw(string d, string ID) { 
            this.date = d;
            this.ID = ID;
            votes= new List<bool>();
            cmen= new List<Congressman>();
        }
        protected int YesCount()
        {
            int s = 0;
            foreach (var item in votes)
            {
                if (item)
                {
                    s++;
                }
            }
            return s;
        }
        public abstract bool IsValid();

        public bool Abstain(Party p)
        {
            foreach( var c in cmen)
            {
                if (c.party == p)
                {
                    return false;
                }
            }
            return true;
        }
    }

    public class Normal : DraftLaw
    {
        public Normal(string d, string ID) : base(d, ID) { }
        public override bool IsValid()
        {
            return YesCount()*2 > votes.Count;
        }
    }

    public class Cardinal : DraftLaw
    {
        public Cardinal(string d, string ID) : base(d, ID) { }
        public override bool IsValid()
        {
            if (parliament == null)
            {
                return false;
            }
            return YesCount() * 2 > parliament.cmen.Count;
        }
    }

    public class Constitutional : DraftLaw
    {
        public Constitutional(string d, string ID) : base(d, ID) { }
        public override bool IsValid()
        {
            if (parliament == null || parliament.cmen.Count == 0)
            {
                return false;
            }
            return YesCount() * 3 >= parliament.cmen.Count * 2;
        }
    }
}
