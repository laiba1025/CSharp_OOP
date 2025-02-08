using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmiralFive
{
    public class Planet
    {
        public string name;
        public int size;

        public Planet(string name, int size)
        {
            if (size <= 0)
            {
                throw new ArgumentException();
            }
            this.name = name;
            this.size = size;
        }

        public int MaxCapacity() { return size * 2; }

        public string Name() { return name; }
    }


}
