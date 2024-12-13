using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab1
{
    internal class two
    {
        public class Employee {
            public virtual double salary => 20000;
        }

        public class Programmer : Employee {
            public virtual double bonus => 10000;
        }

        public class Developer : Programmer {
            public double overtime = 5000;
        }

        public class seniorDeveloper : Developer {
            public string experience = "5 years";
            public override double salary => base.salary + 20000;
            public override double bonus => base.bonus + 10000;
        }

        public class juniorDeveloper : Developer
        {
            public string experience = "2 years";
            public override double salary => base.salary + 5000;
        }

        interface ICanFly
        {
            bool CanFly { get; }
        }

        interface ICanWalk
        {
            bool CanWalk { get; }
        }

        public class Ostrich : ICanFly, ICanWalk
        {
            public bool CanFly => false; 
            public bool CanWalk => true; 
        }

    }
    class Student
    {
        public string Name = "";
        public string Address = "";
        public Student()
        {
            Name = "Byakuya";
            Address = "Gotei 6";
            Console.WriteLine("This is Default Constructor");
            Console.WriteLine($"Name: {Name} \nAddress: {Address}");
        }

        static Student()
        {
            Console.WriteLine("This is Static Constructor");
        }

        private Student(string name)
        {
            Console.WriteLine("This is Private Constructor");
            Console.WriteLine($"Name: {name}");
        }

        public Student(string name, string address)
        {
            Name = name;
            Address = address;
            Console.WriteLine("This is Parameterized Constructor");
            Console.WriteLine($"Name: {Name} \nAddress: {Address}");
            Student obj = new Student("Aizen");
        }

        public Student(Student st)
        {
            Name = st.Name;
            Address = st.Address;
            Student obj = new Student();
            Console.WriteLine("This is Copy Constructor");
        }
    }

    class Parent
    {
        public int age = 30;
        public void show()
        {
            Console.Write("This is Parent age: ");
        }
    }

    class Child : Parent
    {
        public int age = 10;
        
        public new void show()
        {
            base.show();
            Console.WriteLine(base.age);
        }
    }

    class Parent1
    {
        public int age = 30;

        public virtual void show() 
        {
            Console.Write("This is Parent age: ");
        }
    }

    class Child1 : Parent1
    {
        public int age = 10;

        public override void show() 
        {
            base.show(); 
            Console.WriteLine(base.age);
        }
    }
}
