using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourist_Exam
{
    public class Guide
    {
        public string name { get; private set; }
        public int talkative;


        public Guide(string name, int talkative)
        {
            this.name = name;
            this.talkative = talkative;
        }

        public int GetTalkative()
        {
            return this.talkative;
        }

    }
}
