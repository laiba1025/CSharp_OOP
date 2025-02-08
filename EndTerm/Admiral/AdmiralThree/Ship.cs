using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace AdmiralProject
{
    public abstract class Ship
    {
        public int armor;
        public int shield;
        public int damage;

        public Ship(int armor, int shield, int damage)
        {
            if(armor < 0 || shield < 0 || damage < 0)
            {
                throw new Exception();
            }
            this.armor = armor;
            this.shield = shield;
            this.damage = damage;
        }
        public abstract void Attack(Ship opponent);
        public void TakeDamage(int damage)
        {
            if(shield > 0)
            {
                if(shield - damage < 0)
                {
                    damage = damage - shield;
                    shield = 0;
                }
                else
                {
                    shield = shield - damage;
                    throw new Exception();
                }
            }
            armor = armor - damage;
        }

        public int Damage()
        {
            return damage;
        }
        public int Armor()
        {
            return armor;
        }
        public int Shield()
        {
            return shield;
        }
    }

    public class StarDestroyer : Ship
    {
        public int reactorPower;
        public StarDestroyer(int reactor, int armor, int shield, int damage) : base(armor, shield, damage)
        {
            if(reactor < 0)
            {
                throw new Exception();
            }
            this.reactorPower = reactor;
            this.armor = armor;
            this.shield = shield;
            this.damage = damage;
        }

        public override void Attack(Ship opponent)
        {
           int  newDamage = this.damage * reactorPower;
            if(opponent is StarCruiser)
            {
                opponent.TakeDamage(newDamage);
            }
            else
            {
                opponent.TakeDamage(newDamage);
            }
        }
    }
    public class StarCruiser : Ship
    {
        public StarCruiser(int armor, int shield, int damage) : base(armor, shield, damage)
        {
            this.armor = armor;
            this.shield = shield;
            this.damage = damage;
        }

        public override void Attack(Ship opponent)
        {
            if(opponent is Corvette)
            {
                opponent.TakeDamage(this.damage * 2);
            }
            else
            {
                opponent.TakeDamage(this.damage);
            }
        }
    }
    public class Corvette : Ship
    {
        public Corvette(int armor, int shield, int damage) : base(armor, shield, damage)
        {
            this.armor = armor;
            this.shield = shield;
            this.damage = damage;
        }

        public override void Attack(Ship opponent)
        {
            if(opponent is StarDestroyer)
            {
                opponent.TakeDamage(this.damage * 3);
            }
            else
            {
                opponent.TakeDamage(this.damage);
            }
        }
    }
}
