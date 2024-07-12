using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //between value types and reference types-->boxing(implicit) and unboxing(explicit)
            int p = 41;
            Object obj1 = p;
            Console.WriteLine("Boxing i.e. value type to reference type : " + obj1);//implicit

            Object obj2 = 97;
            int q = (int)obj2;
            Console.WriteLine("Unboxing i.e. reference type to value type : " + obj2);//explicit
        }
    }
}
