using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartanPractice
{
    public interface Category
    {
        public virtual String Type() { return ""; }
    }

    public class Sprint : Category
    {
        private static Sprint instance;
        private static object obj1 = new object();

        public static Sprint Instance()
        {
            if (instance == null)
            {
                lock (obj1) if (instance == null) instance = new Sprint();
            }
            return instance;
        }

        public String Type() { return "sprint"; }

    }

    public class Beast : Category
    {
        private static Beast instance;
        private static object obj1 = new object();

        public static Beast Instance() 
        {
            if (instance == null)
            {
                lock(obj1) if (instance == null)  instance = new Beast();
            }
            return instance ;
        }
        public String Type() { return "beast"; }
    }

    public class Super : Category
    {
        private static Super instance;
        private static object obj1 = new object ();
        public static Super Instance()
        {
            if (instance == null)
            {
                lock(obj1) if (instance == null ) instance = new Super();
            }
            return instance;
        }

        public String Type() { return "super"; }
        
    }






}
