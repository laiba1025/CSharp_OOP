using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    internal class Garden
    {
        private List<Parcel> parcels;
        public Garden(List<Parcel> parcels)
        {
            this.parcels = parcels;
        }
        public List<int> canHarvest(int date)
        {
            List<int> res = new();
            for (int i = 0; i < parcels.Count; i++)
            {
                Parcel p = parcels[i];
                if (p.Planted != null && date - p.PlantingDate == p.Planted.RipeningTime && p.Planted.IsVegetable())
                {
                    res.Add(i);
                }
            }
            return res;
        }
        public void Plant(Plant p, int i, int date) {
            parcels[i].Plant(p, date);
        }
    }
}
