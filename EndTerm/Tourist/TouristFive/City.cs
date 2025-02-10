using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourist_Exam
{
    public class City
    {
        public List<District> ds { get; private set; }

        public City(List<District> ds) 
        {
            this.ds = new List<District>();

           foreach(District d in ds) 
           { 
                if(!this.ds.Contains(d))
                {
                    this.ds.Add(d);
                }
           }       
        }

        public District WhichDistrict(Wonder w)
        {
            for(int i=0;i<this.ds.Count;i++) 
            { 
                for(int j = 0; j < this.ds[i].ws.Count;j++) 
                { 
                    if(w.x == ds[i].ws[j].x && w.y == ds[i].ws[j].y && w.interest == ds[i].ws[j].interest && w.built == ds[i].ws[j].built) 
                    {
                        District d = new District(ds[i].ws,ds[i].name);
                        return d;
                    }
                
                }
            
            }

            throw new Exception("Wonder does not find");
        }

        public District MaxTotalTime()
        {
            int index = 0;
            int max = 0;

            for(int i=0;i<ds.Count;i++)
            {
                if(max < ds[i].TotalTime())
                {
                    max = ds[i].TotalTime();
                    index = i;
                }
            }

            return new District(ds[index].ws , ds[index].name);
        }

        public bool CathedralEverywhere()
        {
            bool ans = true;
            for(int i=0;i<ds.Count;i++) 
            {
                ans = ans && (ds[i].Cathedrals() > 0);
            }

            return ans;
        }

    }
}
