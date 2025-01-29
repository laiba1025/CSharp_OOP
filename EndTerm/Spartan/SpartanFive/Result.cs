using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartanFive
{
    public class Result
    {
        public Category cat { get; private set; }
        public Competitor comp { get; private set; }
        public int min { get; private set; }
        public int sec { get; private set; }
        public Result(int m, int s, Competitor c, Category cat)
        {
            if (m <= 0 || s < 0 || s > 59) throw new ArgumentException();
            min = m;
            sec = s;
            this.comp = c;
            this.cat = cat;
        }

        public Category Cat()
        {
            return this.cat;    
        }

        public Competitor Comp()
        {
            return this.comp;
        }
        public int Min() 
        {
            return this.min;    
        }
        public int Sec() 
        {
            return this.sec;    
        }

    }
}
