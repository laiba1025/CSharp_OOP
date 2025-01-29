using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartanFive
{
    public class Competitor
    {
        public int id { get; private set; }
        public string name { get; private set; }
        public bool man { get; private set;  }
        public Competition competition { get; private set; }    

        public Competitor (int id, string n, bool m)
        {
            if (id < 0) throw new Exception();
            this.id = id;
            this.name = n;
            this.man = m;
        }
        public int ID ()
        { return id; }
        public bool Man()
        { return man; }
        public bool IsWinner(Category c)
        {
           bool l = false;
           Competitor? comp = null;
            (l,comp) =competition.Winner(c, man);

            return (l && comp == this);
        }
        public void SetCompetition(Competition c)
        {
            competition = c;
        }
    }
}
