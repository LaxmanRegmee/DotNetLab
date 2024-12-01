using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace csharpLxmn
{
        class Student
        {
            public string Name = "";
            public string Address = "";
            public Student()
            {
                Name = "laxman "; Address = "Kathmandu";
            }//static constructor
            static Student()
            {
                Console.WriteLine("This is a static constructor");
            }
            private Student(string a)
            {

            }
            public Student(string a, string b)
            {
                Name = a; Address = b;
            }
            public Student(Student obj)
            {
                Name = obj.Name; Address = obj.Address;
            }
        }
    }
   