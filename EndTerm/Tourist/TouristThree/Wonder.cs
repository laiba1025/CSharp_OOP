using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace endtermpractice
{
    public abstract  class Wonder
    {
        public int X;
        public int Y;
        public int built;
        public int level;
        public Wonder(int X, int Y, int i, int b)
        {
            this.X = X;
            this.Y = Y;
            this.level = i;
            this.built = b;
           
        }
        public abstract string Gettype();


        public virtual int ExpectedTime()
        {
            
            return level * factor();

        }

        public abstract int factor();
        public int Farthest(List<Wonder> ws)
        {
            int max = 0;
            if (ws.Count == 0)
            {
                throw new Exception();
            }
            
            foreach (Wonder w in ws)
            {
                if (Distance(w,this) > max)
                {
                    max = Distance(w,this);
                }
            }
            return max;

        }


        public int Distance(Wonder w1 , Wonder w2)
        {
            return Math.Abs(w1.X - w2.X) + Math.Abs(w1.Y - w2.Y);
        }
    }


    public class Museum : Wonder
    {
        public Museum(int X, int Y, int i, int b) : base(X, Y, i, b)
        {

        }
        /* public override int timespent()
         {
             return 4;

         }*/
        public override string Gettype()
        {
            return ("mus");
        }
        public override int factor ()
        {
            return (1000/(X*X+Y*Y+1));
        }
    }

    public class Cathedral : Wonder 
    {
        public Cathedral(int X, int Y, int i, int b) :base (X, Y, i, b)
        {

        }

        public override string Gettype()
        {
            return ("cath");
        }
        public override int factor()
        {
            return ((2023 - built) + 5);
        }

    }

    public class Castle : Wonder
    {
        public Castle(int X, int Y, int i, int b) :base (X, Y, i, b)
        {

        }
        public override string Gettype()
        {
            return ("cast");
        }
        public override int factor()
        {
            return ((2023 - built) *2);
        }
    }

}
