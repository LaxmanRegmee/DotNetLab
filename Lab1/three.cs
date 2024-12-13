using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class myException : Exception
    {
        public myException(string msg) : base(msg)
        {
        }
    }

    abstract class abstractTest
    {
        public abstract void show();
        public abstract void select();
        public void delete()
        {
            Console.WriteLine("This is delete method");
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
            Console.WriteLine("Abstract Show Method");
        }
        public override void select()
        {
            Console.WriteLine("Abstract Select Method");
        }
        public void create()
        {
            Console.WriteLine("Interface Create Method");
        }
        public void update()
        {
            Console.WriteLine("Interface Update Method");
        }
    }
}
