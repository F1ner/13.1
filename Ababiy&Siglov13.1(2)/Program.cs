using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy_Siglov13._1_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Avto avto = new Avto("bmw","red",10);
            Avto avto1 = new Avto("audi", "green", 45);
            Console.WriteLine($"{ avto.ToString()}\n{avto1.ToString()}");
            Console.ReadKey();

        }
    }
}
