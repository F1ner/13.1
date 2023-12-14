using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy_Siglov13._1_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            computer.Model=Console.ReadLine();
            computer.Ram=int.Parse(Console.ReadLine());
            computer.Hdd=int.Parse(Console.ReadLine());
            Computer computer1 = new Computer();
            computer1.Model = Console.ReadLine();
            computer1.Ram = int.Parse(Console.ReadLine());
            computer1.Hdd = int.Parse(Console.ReadLine());
            Console.WriteLine($"{computer.ToString()}\n{computer1.ToString()}");
            Console.ReadKey();
        }
    }
}
