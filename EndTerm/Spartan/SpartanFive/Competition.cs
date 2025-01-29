using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartanFive
{
    public class Competition
    {
        public int year { get; private set; }
        public String place { get; private set; }

        public List<Competitor> competitors { get; private set; }    = new List<Competitor>();  
        public List<Category> cat { get; private set; }  = new List<Category>();    
        public List<Result> res { get; private set; } = new List<Result> { };

        public Competition(int y, String p, List<Category> c)
        {
            if (c.Count() == 0 || y <= 2000) throw new ArgumentException();
            this.year = y;
            this.place = p;
            this.cat = c;
            this.res = new List<Result>();

        }

        public void Register(Competitor c)
        {
            for (int e = 0; e < competitors.Count(); e++)
            {
                if (competitors[e].ID() == c.ID())
                {
                    throw new ArgumentException();  
                }
            }
            competitors.Add(c);
            c.SetCompetition(this);
            
        }
        public Category PopularCat()
        {
            int max = 0;
            Category? c = cat[0];
            for (int e = 0;e < cat.Count();e++) 
            {
                int Sum = 0;
                for (int e2 = 0; e2 < res.Count(); e2++)
                {
                    if (res[e2].Cat().Type() == cat[e].Type())
                    {

                        Sum++;
                    }
                }
                if (Sum > max) 
                {
                    max = Sum;
                    c = cat[e];
                }

            }
            return c;
        }
        public void Score(int min, int sec, int num, Category c)
        {
            bool l = false;
            bool l2 = false;
            bool l3 = false;    
            Competitor elem = competitors[0];
            for (int e = 0; e < competitors.Count; e++)
            {
                if (competitors[e].ID() == num)
                {
                    l = true;   
                    elem = competitors[e];  
                }
                
            }
            if (!l) throw new Exception();
            for (int e = 0; e < cat.Count(); e++)
            {
                if (cat[e] == c)
                {
                    l2 = true;  
                }
                
            }
            if (!l2)
            {
                throw new Exception();
            }
            for (int e = 0; e < res.Count(); e++)
            {
                if (res[e].Cat() == c && res[e].Comp().ID() == num)
                {
                    l3 = true;  
                }
               
            }
            if (l3)
            {
                throw new Exception();
            }

            res.Add(new Result(min, sec, elem, c));
        }
        public (bool, Competitor) Winner(Category c, bool man)
        {
            int min = int.MaxValue;
            //int ind = 0;
            bool l = false;
            Competitor? elem = competitors[0];

            for (int e = 0; e < res.Count(); e++)
            {
                /*if (l && res[e].Cat() == c && res[e].Comp().Man() == man)
                {
                    if (res[e].Min() * 60 + res[e].Sec() < min)
                    {
                        min = res[e].Min() * 60 + res[e].Sec();
                        //ind = e;    
                    }
                }*/
                if (res[e].Cat() == c && res[e].Comp().Man() == man)
                {
                    if (res[e].Min() * 60 + res[e].Sec() < min)
                    {
                        min = res[e].Min() * 60 + res[e].Sec();
                        //ind = e;
                        l = true;
                        elem = res[e].Comp();
                    }
                       
                }
            }
            return (l, elem);
        }


    }
}
