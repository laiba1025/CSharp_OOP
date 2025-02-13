using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackOpening
{
    public abstract class Card
    {
        public int cost;
        public int defense;
        public int passes;
        public int shots;
        public Player player;
        public Card(int c, int d, int p, int s, Player pl)
        {
            if (c < 0 || d < 0 || p < 0 || s < 0)
            {
                throw new Exception();
            }
            cost = c;
            defense = d;
            passes = p;
            shots = s;
            player = pl;

        }

        public abstract int Rating();


        public abstract string GetType();
       
        public Player GetPlayer()
        {
            return player;
        }
        public int Cost()
        {
            return cost;
        }


    }

    public class Defender : Card
    {
        public Defender(int c, int d, int p, int s, Player pl) : base(c, d, p, s, pl)
        {
        }

        public override string GetType()
        {
            return "defender";
        }
        public override int Rating()
        {
            return defense;
        }

    }

    public class Attacker : Card
    {
        public Attacker(int c, int d, int p, int s, Player pl) : base(c, d, p, s, pl)
        {
        }

        public override string GetType()
        {
            return "attacker";
        }
        public override int Rating()
        {
            return shots;
        }


    }


    public class Midfielder : Card
    {
        public Midfielder(int c, int d, int p, int s, Player pl) : base(c, d, p, s, pl)
        {
        }

        public override string GetType()
        {
            return "midfielder";
        }
        public override int Rating()
        {
            return passes;
        }


    }
}
