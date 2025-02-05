using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parliament
{
    public class Parliament
    {
        public List <Congressman> cmen = new List<Congressman>();
        public List <DraftLaw> laws = new List<DraftLaw>();
        public Parliament(List<Congressman> cm)
        {
            foreach (Congressman c in cm)
            {
                c.parliament = this;

                if (!cmen.Contains(c))
                {
                    cmen.Add(c);    
                }
            }
        }
        public void Submit(DraftLaw d)
        {
            bool l = false;

            foreach (DraftLaw e in laws)
            {
                if (e.ID == d.ID)
                {
                    l = true;
                }
                if (l)
                {
                    throw new ArgumentException();
                }
            }
           
            laws.Add(d);
            d.parliament = this;
        }

        public void Vote(Congressman cm, bool b, String ID)
        {
            bool l = false;
            DraftLaw elem = null ;
            foreach (DraftLaw t in laws)
            {
                if (t.ID == ID)
                {
                    l = true;
                    elem = t;       
                }
            }
            if (!l)
            {
                throw new MissingMemberException();
            }
            if (elem.cmen.Contains(cm))
            {
                throw new ArgumentException();
            }
            elem.cmen.Add(cm);
            elem.votes.Add(b);
        }
        public List<String> ValidLaws()
        {
            List <String>  list = new List<String>();   
           foreach (DraftLaw t in laws )
           {
                if (t.IsValid())
                {
                   list.Add(t.ID);  
                }
           }
           return list;
        }
    }
}
