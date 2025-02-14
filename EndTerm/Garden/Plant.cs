using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    public abstract class Plant
    {
        protected int ripeningTime;
        public int RipeningTime { get => ripeningTime; }
        public virtual bool IsVegetable() { return false; }
        protected Plant(int ripeningTime)
        {
            this.ripeningTime = ripeningTime;
        }
    }
    public abstract class Vegetable : Plant
    {
        public override bool IsVegetable() { return true; }
        protected Vegetable(int ripeningTime) : base(ripeningTime)
        {
        }
    }
    public abstract class Flower : Plant
    {
        protected Flower(int ripeningTime) : base(ripeningTime)
        {
        }
    }

    public class Potato : Vegetable
    {
        private static Potato instance = new Potato();
        private Potato() : base(3)
        {
        }
        public static Potato GetInstance() { return instance; }
    }
    public class Peas : Vegetable
    {
        private static Peas instance = new Peas();
        private Peas() : base(4)
        {
        }
        public static Peas GetInstance() { return instance; }
    }
    public class Onion : Vegetable
    {
        private static Onion instance = new Onion();
        private Onion() : base(5)
        {
        }
        public static Onion GetInstance() { return instance; }
    }
    public class Tulip : Flower
    {
        private static Tulip instance = new Tulip();
        private Tulip() : base(3)
        {
        }
        public static Tulip GetInstance() { return instance; }
    }
    public class Carnation : Flower
    {
        private static Carnation instance = new Carnation();
        private Carnation() : base(4)
        {
        }
        public static Carnation GetInstance() { return instance; }
    }
    public class Rose : Flower
    {
        private static Rose instance = new Rose();
        private Rose() : base(5)
        {
        }
        public static Rose GetInstance() { return instance; }
    }
}