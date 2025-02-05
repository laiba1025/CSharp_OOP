using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH_Parlament
{
    public class Parliament
    {
        public List<Congressman> cmen;
        public List<DraftLaw> laws;
        public List<Party> parties;
        public Parliament(List<Congressman> cm)
        {
            cmen = new();
            laws = new();
            parties = new();
            foreach(var c in cm)
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
            foreach (var i in laws)
            {
                if (i.ID == d.ID)
                {
                    l = true;
                }
            }

            if (l)
            {
                throw new ArgumentException();
            }
            laws.Add(d);
            d.parliament = this;
        }

        public void Vote(Congressman cm, bool b, string ID)
        {
            bool found = false;
            DraftLaw elem= null;
            foreach (var i in laws)
            {
                if (i.ID == ID)
                {
                    found = true;
                    elem = i;
                }
            }
            if (!found) {
                throw new MissingMemberException();
            }

            if (elem.cmen.Contains(cm))
            {
                throw new ArgumentException();
            }

            elem.cmen.Add(cm);
            elem.votes.Add(b);
        }

        public List<string> ValidLaws()
        {
            List<string> vl = new List<string>();
            foreach (var i in laws)
            {
                if (i.IsValid())
                {
                    vl.Add(i.ID);
                }
               
            }

            return vl;
        }

        public int AbstainCount()
        {
            int c = 0;
            foreach(var cm  in cmen)
            {
                int abstains = 0;
                foreach (var l in laws)
                {
                    if (!l.cmen.Contains(cm))
                    {
                        abstains++;
                    }
                }
                if (abstains > 2)
                {
                    c++;
                }
            }
            return c;
        }

        public void Reject()
        {
            for (int i = laws.Count - 1; i >= 0; i--)
            {
                var l = laws[i];
                if (cmen.Count == l.cmen.Count && (!l.IsValid()))
                {
                    laws.Remove(l);
                }

            }
        }

        public void Establish(Party p)
        {
            bool l = false;
            foreach(var pa in parties)
            {
                if (pa.name == p.name)
                {
                    l = true;
                }
            }

            if (l)
            {
                throw new ArgumentException();
            }
            parties.Add(p);
        }

        public bool AbstainParty()
        {
            foreach(var p in parties)
            {
                if(p.cmen.Count > 0)
                {
                    foreach(var d in laws)
                    {
                        if (d.Abstain(p))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

    }





    public class Congressman{

        public string name;
        public Parliament parliament;
        public Party party;
        public Congressman(string n) { 
            this.name = n;
        }


        public void Vote(bool vote, string ID)
        {
            if (parliament== null)
            {
                throw new ArgumentNullException();
            }

            parliament.Vote(this, vote, ID);
        }

        public void Enter(Party p)
        {
            if (party != null || p == null)
            {
                throw new InvalidOperationException();
            }
            party = p;
            p.cmen.Add(this);
        }


        public void Leave() { 
            if (party == null)
            {
                throw new InvalidOperationException();
            }
            party.cmen.Remove(this);
            party = null;
        }

    }
}
