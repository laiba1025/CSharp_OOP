using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    public class Parcel
    {
        private Plant? planted = null;
        private int plantingDate;
        public Plant? Planted { get => planted; }
        public int PlantingDate {  get => plantingDate;}
        public void Plant(Plant p, int date) {
            if (planted == null)
            {
                planted = p;
                plantingDate = date;
            }
            else {
                throw new InvalidOperationException();
            }
        }
    }
}
