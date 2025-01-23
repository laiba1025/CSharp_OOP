using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartan
{
    public class Competition
    {
        private List<Category> cat = new List<Category>();
        private List<Result> res = new List<Result>();

        private int year;
        private String place;

        public Competition(int y, string p, List<Category> c)
        {
            if (c.Count() == 0 || y <= 2000) throw new Exception();
            year = y;
            place = p;
            cat = c;
        }

        public Category PopularCat()
        {
            int ind = 0;
            int MAX = 0;
            
            for (int e = 0; e < cat.Count; e++)
            {
                int SUM = 0;
                foreach ( Result e2 in res)
                {
                  
                    if (e2.Cat().Type() == cat[e].Type())
                    {
                        SUM++;
                    }

                    if (MAX < SUM)
                    {
                        MAX = SUM;
                        ind = e;
                    }
                }
            }
            return cat[ind];
        }


        public void Score(int min, int sec, int num, Category c)
        {
            bool l2 = false;
            bool l3 = false;
            foreach (Category e in cat)
            {
                if (e == c)
                {
                    l2 = true;
                }
            }
            if (!l2) { throw new Exception(); }
            foreach (Result e in res)
            {
                if (e.Cat() == c && e.ID() == num)
                {
                    l3 = true;
                }
            }
            if (l3) throw new Exception();

            res.Add(new Result(min, sec, num, c));
        }

        public (bool, int) Winner(Category c)
        {
            bool l = false;
            int ind = 0;
            int min = 0;
            for (int e = 0; e < res.Count(); e++)
            {
                int temp = res[e].Min()*60 + res[e].Sec();
                if (l && res[e].Cat() == c)
                {
                    if (min > temp)
                    {
                        ind = e;
                    }
                }
                if (!l && res[e].Cat() == c)
                {
                    l = true;
                    min = temp;
                    ind = e;
                }
            }
            if (!l && res.Count == 0) return (false, 0);
            else return (l, res[ind].ID());
        }
    }
}
