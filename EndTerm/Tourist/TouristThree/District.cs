using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace endtermpractice
{
    public class District
    {
        public string name { get; }
        public List<Wonder> ws = new List<Wonder>();

        /*public List<Wonder> GETws()
        {
            return ws;
        }*/

        public District(string n , List<Wonder>wss)
        {
            name = n;
            foreach (Wonder w in wss)
            {
                foreach (Wonder a in ws)
                {
                    if (w == a)
                    {
                        throw new Exception();
                    }
                   
                }
                ws.Add(w);
            }

        }

        public int MaxDistance()
        {
            if (ws.Count == 0)
            {
                throw new Exception ();
            }

            int max = 0;
            foreach (Wonder w in ws)
            {
                if (w.Farthest(ws) > max)
                {
                    max = w.Farthest(ws);
                }
            }
            
            return max;
            
        }
    }
}
