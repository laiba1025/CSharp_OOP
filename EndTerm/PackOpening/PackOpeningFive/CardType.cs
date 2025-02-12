using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackOpening
{
    public interface CardType
    {
        public int BoostStats(Defender def)
        {
            return 0;
        }
        public int BoostStats(Attacker att)
        {
            return 0;
        }
        public int BoostStats(Midfielder mid)
        {
            return 0;
        }


    }
    public class None: CardType
    {
        public static None instance;

        public static None Instance()
        {
            if (instance == null)
            {
                instance = new None();
            }
            return instance;
        }
        public int BoostStats(Defender def)
        {
            return 0;
        }
        public int BoostStats(Attacker att)
        {
            return 0;
        }
        public int BoostStats(Midfielder mid)
        {
            return 0;
        }

    }
    public class POTW : CardType
    {
        public static POTW instance;

        public static POTW Instance()
        {
            if (instance == null)
            {
                instance = new POTW();
            }
            return instance;
        }
        public int BoostStats(Defender def)
        {
            return 4;
        }
        public int BoostStats(Attacker att)
        {
            return 2;
        }
        public int BoostStats(Midfielder mid)
        {
            return 3;
        }

    }
    public class POTY : CardType
    {
        public static POTY instance;

        public static POTY Instance()
        {
            if (instance == null)
            {
                instance = new POTY();
            }
            return instance;
        }
        public int BoostStats(Defender def)
        {
            return 4;
        }
        public int BoostStats(Attacker att)
        {
            return 7;
        }
        public int BoostStats(Midfielder mid)
        {
            return 6;
        }

    }
}
