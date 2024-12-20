using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public delegate void Calculation(int a, int b);
    public delegate void Calculate(int a);

    class DelegateTest
    {
        public void Area(int x)
        {
            Console.WriteLine("The Area: " + x);
        }

        public void Add(int x, int y)
        {
            Console.WriteLine($"Addition of {x} and {y} = {x+y}");
        }

        public void Sub(int x, int y)
        {
            Console.WriteLine($"Subtraction of {x} and {y} = {x-y}");
        }
    }

    class Employees
    {
        public string Name { get; set; } 
        public string Address { get; set; }
        public double Salary { get; set; }
    }

    class LinqTest
    {
        public void LinqFunc()
        {
            List<Employees> list = new List<Employees>()
            {
                 new Employees() { Name = "Nishchal Bogati", Address = "Thapagaun", Salary = 25000 },
                 new Employees() { Name = "Saurav Panthi", Address = "Imadol", Salary = 25000 },
                 new Employees() { Name = "Laxman Regmi", Address = "Tinkune", Salary = 25000 },
                 new Employees() { Name = "Scholes Karmacharya", Address = "Satdobato", Salary = 20000 },
                 new Employees() { Name = "Angad Adhikari", Address = "Hattiban", Salary = 20000 },
                 new Employees() { Name = "Astitwo Khadka", Address = "Dhapakhel", Salary = 20000 }
            };

            //var emp = from e in list where e.Salary > 20000 select e;
            var emp = list.FindAll(x => x.Salary < 25000);
            foreach (Employees x in emp)
            {
                Console.WriteLine(x.Name + " " + x.Address + " " + x.Salary);
            }
        }
    }
}
