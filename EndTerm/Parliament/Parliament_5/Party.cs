using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH_Parlament
{
    public class Party
    {
        public string name;
        public List<Congressman> cmen;

        public Party(string name, Parliament p)
        {
            cmen = new List<Congressman>();
            this.name = name;
            this.cmen = new();
            p.Establish(this);
        }
    }
}
