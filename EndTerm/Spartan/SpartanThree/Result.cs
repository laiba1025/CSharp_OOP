using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartanPractice
{
    public class Result
    {
        private Category cat;
        private int min;
        private int sec;
        private int id;

        public int GetMin() { return min; }
        public int GetSec() { return sec; }
        public int GetId() { return id; }

        public Result(int m , int s, int ID, Category c)
        {
            if (m <= 0 || s < 0 || s > 59 || ID <= 0) throw new ArgumentException();
            this.min = m;
            this.sec = s;   
            this.id = ID;   
            this.cat = c;
        }

        public Category Cat() { return cat; }

        public int ID () { return id; } 

        public int Min() { return min; }    
        public int Sec() { return sec; }

    }
}
