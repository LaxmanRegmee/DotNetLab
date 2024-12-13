using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab1
{
    internal class one
    {
        public static class staticClass
        {
            public static void display()
            {
                Console.WriteLine("This is a Static Class\n");
            }
        }
        struct myStruct
        {
            public string Name;
            public string Address;
            public void structFunction()
            {
                Console.WriteLine("This is a Struct Function\n");
            }
        }

        enum weekDays
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        internal class labStruct
        {

            public void nameFunction(string a = "Luffy", string b = "Zoro", string c = "Sanji")
            {
                Console.WriteLine($"{a} {b} {c}\n");
            }

            public void refFunction(ref int a)
            {
                a = 9;
            }
            public void outFunction(out int a, out int b, out int c)
            {
                a = 6;
                b = 9;
                c = a * b;
                Console.WriteLine($"{a} * {b} = {c}");
            }

            public void enumFunction()
            {
                Console.WriteLine((int)weekDays.Tuesday);
                Console.WriteLine(weekDays.Wednesday);
                Console.WriteLine((weekDays)4);

            }

            public void myStructFunction()
            {
                myStruct st = new myStruct();
                st.Name = "Ark Himmel";
                st.Address = "Void Realm\n";

                Console.WriteLine("Name: " + st.Name);
                Console.WriteLine("Address: " + st.Address);

                st.structFunction();
            }

        }
    }
}
