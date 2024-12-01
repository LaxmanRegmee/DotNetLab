using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace normal
{
    internal class Program
    {
           public void HelloWorld()         
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("Hello world");
                    }
                }
                public void TakeNum()
                {
                    Console.WriteLine("give me a number :");
                    int num = Convert.ToInt32(Console.ReadLine());
                    if (num % 2 == 0)
                    {
                        Console.WriteLine($"{num} is even number");
                    }
                    else
                    {
                        Console.WriteLine($"{num}is odd number");
                    }
                }
                public void AddNum()
                {
                    Console.WriteLine("give me a number a :");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("give me a number b :");
                    int b = Convert.ToInt32(Console.ReadLine());
                    int sum = a + b;
                    Console.WriteLine($"sum of {a} and {b} is {sum}");

                }
                public void ThreeD()
                {
                    int[,,] arr = new int[2, 3, 4]
                    {
                        {{1,2,3,4},{5,6,8,9},{ 2,4,5,7,} },
                        {{10,11,12,13},{14,15,16,17},{1,0,01,1 } },
                    };
                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        { 
                            for (int k = 0; k < 4; k++)
                            {
                                Console.Write($"{arr[i, j, k]}  ");
                            }
                            Console.WriteLine();
                        }

                    }
                }
                public void JaggedArr()
                {
                    int[][][] jarry = new int[2][][]
                    {
                        new int[2][]
                        {
                            new int [2]{1,2},
                            new int [3]{3,6,8},
                        },
                        new int[1][]
                        {
                            new int[2]{4,5 },

                        }
                    };
                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0;j < jarry[i].Length; j++)
                        {
                            for (int k = 0;k < jarry[i][j].Length; k++)
                            {
                                Console.Write($"{ jarry[i][j][k]}  ");
                            }
                            Console.WriteLine();
                        }
                    }
                }

        //lab 02


        public static void Main(string[] args)
        {
            Program obj = new Program();
            // obj.HelloWorld();
            // obj.TakeNum();
            // obj.AddNum();
            // obj.ThreeD();
            obj.JaggedArr();

           
        //    class obj = new xerxes();


    }
        
    }
}