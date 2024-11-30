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
    internal class Program
    {
        public static void Main(string[] args)
        {
           Programmer obj = new Programmer();
           Console.WriteLine(obj.salary);
           Console.WriteLine(obj.bonus);


          Employee emp = new Employee();
          Console.WriteLine(emp.salary) ; 

         }
        
    }
}
