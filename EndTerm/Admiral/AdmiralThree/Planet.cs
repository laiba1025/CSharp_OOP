using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmiralProject
{
    public class Planet
    {
        public string name;
        public int size;

        public Planet(string name, int size)
        {
            this.name = name;
            if(size == 0)
            {
                throw new Exception();
            }
            this.size = size;   
        }
        public int MaxCapacity()
        {
            return size * 2;
        }
        public string Name()
        {
            return name;
        }
    }
}
