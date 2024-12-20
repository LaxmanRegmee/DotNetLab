using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{

    abstract class abstractTest
    {
        public abstract void show();
        public abstract void select();
        public void delete()
        {
            Console.WriteLine("this is delete method");
        }
    }

    interface ITest
    {
        void create();
        void update();
    }

    internal class Teacher : abstractTest, ITest
    {
        public override void show()
        {
            Console.WriteLine("abstract show method");
        }
        public override void select()
        {
            Console.WriteLine("abstract select method");
        }
        public void create()
        {
            Console.WriteLine("interface create method");
        }
        public void update()
        {
            Console.WriteLine("interface update method");
        }
    }
}
