using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parliament
{
    public class Congressman
    {
        public String name;
        public Parliament parliament;

        public Congressman(String n) 
        {
            this.name = n;  
        }

        public void Vote(bool vote, String ID)
        {
            if (parliament == null)
            {
                throw new ArgumentNullException();
            }
            parliament.Vote(this, vote, ID);
        }
    }
}
