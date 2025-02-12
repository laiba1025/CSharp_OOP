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
        public int defence;
        public int passes;
        public int shots;
        public Player player;
        public CardType type;

        public Card(int c, int d, int p, int s, Player pl,CardType t )
        {
            if(c < 0 || d < 0  || p < 0|| s < 0 )
            {
                throw new Exception();
            }
            cost = c;
            defence = d;
            passes = p;
            shots = s;
            player = pl;
            type = t;
        }

        public abstract int Rating();
        public abstract string GetType();
        public Player GetPlayer() { return player; }
        public int Cost() { return cost; }
        public CardType Type() { return type; }
    }

    public class Defender : Card
    {
        public Defender (int c, int d, int p, int s , Player pl, CardType t): base (c, d, p, s, pl,t)
        {
            var a = type.BoostStats(this);
            cost = cost + a;
            defence = defence + a;

        }

        public override int Rating() { return defence;}
        public override string GetType() { return "defender"; }
    }
    public class Attacker : Card
    {
        public Attacker(int c, int d, int p, int s, Player pl , CardType t) : base(c, d, p, s, pl, t)
        {
            var a = type.BoostStats(this);
            cost = cost + a;
            shots = shots + a;


        }

        public override int Rating() { return shots; }
        public override string GetType() { return "attacker"; }
    }
    public class Midfielder : Card
    {
        public Midfielder(int c, int d, int p, int s, Player pl, CardType t) : base(c, d, p, s, pl, t )
        {
            var a = type.BoostStats(this);
            cost = cost + a;
            passes = passes+ a;


        }

        public override int Rating() { return passes; }
        public override string GetType() { return "midfielder"; }
    }
}
