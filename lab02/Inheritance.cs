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
    internal class Employee
    {
        public double salary = 40000;
    }
    class Programmer : Employee
    {
        public double bonus = 5000;
    }
    class Developer : Employee
    {
        public double salary2 = 600000;
    }
}