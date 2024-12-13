using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab1.two;


namespace Lab1
{
    internal class Program
    {
        public void helloWorld()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("HelloWorld");
            }
        }

        public void oddEven()
        {
            Console.Write("\nEnter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is even number\n");
            }
            else
            {
                Console.WriteLine($"{num} is odd number\n");
            }
        }

        public void addSum()
        {
            Console.Write("Enter 1st number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
        }

        public void threeDim()
        {
            int[,,] arr = new int[2, 3, 4] {
                { {1,2,3,4},{5,6,7,8},{9,0,1,2} },
                { {2,1,0,9},{8,7,6,5},{4,3,2,1} },
            };

            Console.WriteLine("\n3D Array: ");

            for (int i = 0;i < 2;i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for(int k = 0; k < 4; k++)
                    {
                        Console.Write($"{arr[i, j, k]}  ");
                    }
                    Console.WriteLine();
                }  
                Console.WriteLine() ;
            }
        }

        public void jagArr()
        {
            int[][][] jarr = new int[2][][]
            {
                new int[2][]
                {
                    new int[2] { 1, 2 },
                    new int[1] { 3 }
                },
                new int[1][]
                {
                    new int[2] { 2, 5 }
                }
            };

            Console.WriteLine("Jagged Array: ");
            for (int i = 0; i < jarr.Length; i++)
            {
                for(int j = 0; j < jarr[i].Length; j++)
                {
                    for(int k = 0; k < jarr[i][j].Length; k++)
                    {
                        Console.Write(jarr[i][j][k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            /*Program obj = new Program();
             obj.helloWorld();
             obj.oddEven();
             obj.addSum();
             obj.threeDim();
             obj.jagArr();*/

            /*one.staticClass.display();

            one.labStruct lab = new one.labStruct();

            lab.nameFunction();

            lab.outFunction(out int oA, out int oB, out int oC);
            Console.WriteLine($"outA = {oA}, outB = {oB}, outC = {oC}\n");

            int x = 14;
            lab.refFunction(ref x);
            Console.WriteLine($"updated x after referencing : {x}\n");

            lab.myStructFunction();

            lab.enumFunction();*/

            //Inheritance

            /*seniorDeveloper senior = new seniorDeveloper();
            juniorDeveloper junior = new juniorDeveloper();

            Console.WriteLine("Heirarchical,Multi-Level & Hybrid Inheritance:");

            Console.WriteLine("Senior Developer Details:");
            Console.WriteLine($"Salary: {senior.salary}");
            Console.WriteLine($"Bonus: {senior.bonus}");
            Console.WriteLine($"Overtime: {senior.overtime}");
            Console.WriteLine($"Experience: {senior.experience}");

            Console.WriteLine("\nJunior Developer Details:");
            Console.WriteLine($"Salary: {junior.salary}");
            Console.WriteLine($"Bonus: {junior.bonus}");
            Console.WriteLine($"Overtime: {junior.overtime}");
            Console.WriteLine($"Experience: {junior.experience}");

            Console.WriteLine("\nMultiple Inheritance: ");

            Ostrich ostrich = new Ostrich();

            Console.WriteLine($"Can Ostrich fly? {ostrich.CanFly}");
            Console.WriteLine($"Can Ostrich walk? {ostrich.CanWalk}\n");

            //Constructor

            Student st1 = new Student("Urahara", "Gotei 12");
            Student st2 = new Student(st1);
            Console.WriteLine($"Copied Name: {st2.Name} \nCopied Address: {st2.Address}");

            //Hiding

            Parent parent = new Parent();
            parent.show();

            Child child = new Child();
            child.show(); 

            Parent parChild = new Child();
            parChild.show();

            //Override

            Parent1 parent1 = new Parent1();
            parent1.show(); 

            Child1 child1 = new Child1();
            child1.show(); 

            Parent1 parChild1 = new Child1();
            parChild1.show();*/

            try
            {
                throw new myException("This is my exception");
            }
            catch (myException ex) {
                Console.WriteLine(ex.Message);            
            }
            try
            {
                throw new DivideByZeroException("Divided by zero");
            }
            catch (DivideByZeroException ex) { 
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally Block");
            }

            Teacher teach = new Teacher();
            teach.select();
            teach.update();
            teach.show();
            teach.create();
            teach.delete();
        }
    }
}
