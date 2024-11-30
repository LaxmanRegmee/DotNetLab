using System;
namespace csharpLxmn{
    class MyParent{
        public virtual void Show(){
            Console.WriteLine("this is a parent");
        }
    }
    class MyChild : MyParent{
        public override void Show(){
            Console.WriteLine("this is a child");
        }
    }
}