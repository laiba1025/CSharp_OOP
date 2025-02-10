using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourist_Exam
{
    public class District
    {
        public string name{ get; private set; }
        public List<Wonder> ws { get; private set; }

        public District(List <Wonder> ws , string n)
        {
            this.ws = new List<Wonder>();
            this.ws.Add(ws[0]);

            for (int i = 1; i < ws.Count; i++) 
            {
                if (this.ws.Contains(ws[i]))
                {
                    throw new Exception($"{ws[i]} already exists!");
                }
                else
                {
                    this.ws.Add(ws[i]);
                }
            }

            this.name = n;

        }

        public int MaxDistance()
        {
            if(ws.Count == 0)
            {
                throw new Exception();
            }
            else
            {
                int max = ws[0].Farthest(this.ws);
                for(int i=1;i< ws.Count; i++)
                {
                    if(max < ws[i].Farthest(this.ws))
                    {
                        max = ws[i].Farthest(this.ws);
                    }
                }
                return max;
            }
        }

        public int Cathedrals()
        {
            int count = 0;
            for(int i=0;i<ws.Count;i++)
            {
                if (ws[i].GetType() == "cath")
                {
                    count++;
                }
            }

            return count;
        }


        public int TotalTime()
        {
            int total = 0;

            for(int i=0;i< ws.Count;i++)
            {
                total += ws[i].ExpectedTime();
            }

            return total;
        }
    }
}
