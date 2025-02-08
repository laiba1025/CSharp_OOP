using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmiralFive
{
    public abstract class Ship
    {
        public int armor;
        public int shield;
        public int damage;
        public Ship(int armor, int shield, int damage)
        {
            if (armor < 0 || shield < 0 || damage < 0)
            {
                throw new ArgumentException(" error");
            }
            this.armor = armor;
            this.shield = shield;
            this.damage = damage;
        }
        public abstract void Attack(Ship opponent);
        public void TakeDamage(int damage)
        {
            if (shield > 0)
            {
                if (shield - damage < 0)
                {
                    damage = damage - shield;
                    shield = 0;
                }
                else
                {
                    shield = shield - damage;
                    return;
                }
            }
            armor = armor - damage;

        }

        public int Damage() { return damage; }
        public int Armor() { return armor; }
        public int Shield() { return shield; }

        public abstract string Type();
    }

    public class StarDestroyer : Ship
    {
        public int reactorPower;
        public StarDestroyer(int reactor, int armor, int shield, int damage) : base(armor, shield, damage)
        {
            if (reactor < 0)
            {
                throw new ArgumentException("error");
            }
            this.reactorPower = reactor;
            this.armor = armor;
            this.shield = shield;
            this.damage = damage;
        }

        public override void Attack(Ship opponent)
        {
            int newDamage = this.damage * reactorPower;
            //name = null; 
            if (opponent is StarCruiser)
            {
                opponent.TakeDamage(newDamage * 2);
            }
            else
            {
                opponent.TakeDamage(newDamage);
            }

        }
        public override string Type()
        {
            return "StarD";
        }
    }
    public class StarCruiser : Ship
    {
        // public int reactorPower; 
        public StarCruiser(int armor, int shield, int damage) : base(armor, shield, damage)
        {

            //this.reactorPower = reactor; 
            this.armor = armor;
            this.shield = shield;
            this.damage = damage;
        }

        public override void Attack(Ship opponent)
        {
            //// to be handle 

            if (opponent is Corvette)
            {
                opponent.TakeDamage(this.damage * 2);
            }
            else
            {
                opponent.TakeDamage(this.damage);
            }

        }
        public override string Type()
        {
            return "StarC";
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

            if (opponent is StarDestroyer)
            {
                opponent.TakeDamage(this.damage * 3);
            }
            else
            {
                opponent.TakeDamage(this.damage);
            }

        }
        public override string Type()
        {
            return "CONV";
        }
    }
}

namespace AdmiralFive
{
    public enum Fraction
    {
        Republic, Separatists
    }
}
