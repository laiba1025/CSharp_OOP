using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartanFive
{
    public interface Category
    {
        public virtual String Type()
        {
            return "";
        }
    }

    public class Sprint : Category
    { 
        public static Sprint instance ;

        public static Sprint Instance()
        {
            if (instance == null)
            {
                instance = new Sprint();
            }
            return instance;    
        }
        public String Type()
        {
            return "sprint";
        }
    }
    public class Super : Category
    {
        public static Super instance;

        public static Super Instance()
        {
            if (instance == null)
            {
                instance = new Super();
            }
            return instance;
        }
        public String Type()
        {
            return "super";
        }
    }

    public class Beast : Category
    {
        public static Beast instance;

        public static Beast Instance()
        {
            if (instance == null)
            {
                instance = new Beast();
            }
            return instance;
        }
        public String Type()
        {
            return "beast";
        }
    }
}
