using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace endtermpractice
{
    public class City
    {
        public List<District> ds = new List<District>();
        public City(List<District> dss) 
        {
            foreach (District d in dss)
            {
                foreach (District a in ds)
                {
                    if(d == a)
                    {
                        throw new Exception();  
                    }

                    
                }
                ds.Add(d);

            }

        }

        /* public District WhichDistrict( Wonder w)
         {
             foreach (District d in ds)
             {
                 foreach( Wonder x in d.ws)
                 {
                     if (w == x)
                     {
                         return d;

                     }

                 }


             }
             return null;
         }*/

        public District WhichDistrict(Wonder w)
        {
            foreach (District d in ds)
            {
                foreach (Wonder x in d.ws)
                {
                    if (w == x)
                    {
                        return d;
                        //break;
                    }
                }
            }
            return null;
        }

    }
}
