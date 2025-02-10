using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tourist_Exam
{
    public abstract class Wonder
    {
        public int x{ get; private set; }
        public int y{ get; private set; }
        public int interest{ get; private set; }
        public int built { get; private set; }

        private Guide guide;

        protected Wonder(int x,int y,int i,int b) 
        {
            this.x = x;
            this.y = y;
            this.interest= i;
            this.built = b;
            this.guide = null;
        }

        public void setGuide(Guide g)
        {
            if(this.guide == null)
                this.guide = new Guide(g.name,g.GetTalkative());
            else this.guide = g;
        }

        public abstract string GetType();
        public int ExpectedTime()
        {
            int g = 0;
            if (guide == null)
            {
                g = 1;
            }
            else
            {
                g = 1 + guide.GetTalkative();
            }

            return Factor() * interest * g;
        }

        protected abstract int Factor();

        private int Distance(Wonder w1,Wonder w2) 
        { 
        
            return Math.Abs(w1.x - w2.x) + Math.Abs(w1.y-w2.y);
        
        }


        public int Farthest(List<Wonder> ws)
        {
            if (ws.Count == 0)
            {
                throw new Exception("Array is Empty");
            }

            int max = 0;

            for (int j = 0; j < ws.Count; j++)
            {
                if (this.x != ws[j].x || this.y != ws[j].y ||this.built != ws[j].built || this.interest != ws[j].interest)
                {
                    if (max < Distance(this, ws[j]))
                    {
                        max = Distance(this, ws[j]);
                    }
                }
            }






            return max;
        }



    }


    public class Cathedral : Wonder
    {
        public Cathedral(int x, int y, int i, int b) : base(x, y, i, b) { }

        public override string GetType()
        {
            return "cath";
        }

        protected override int Factor()
        {
            return (2023 - this.built) + 5;
        }

    }

    public class Museum : Wonder
    {
        public Museum(int x,int y,int i,int b) : base(x, y, i, b) { }
        public override string GetType() { return "mus"; }
        protected override int Factor() { return (10000 / ((this.x * this.x) + (this.y * this.y) + 1)); }

    }


    public class Castle : Wonder
    {
        public Castle(int x,int y,int i,int b) : base(x, y, i, b) { }

        public override string GetType()
        {

            return "cast";
        
        }

        protected override int Factor()
        {
            return (2023 - this.built) * 2;
        }


    }






}
