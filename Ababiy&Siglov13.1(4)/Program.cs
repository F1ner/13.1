using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy_Siglov13._1_4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tovar tovar = new Tovar();
            tovar.Name=Console.ReadLine();
            tovar.Price = int.Parse(Console.ReadLine());
            tovar.Kvo = int.Parse(Console.ReadLine());

            Tovar tovar1 = new Tovar();
            tovar1.Name = Console.ReadLine();
            tovar1.Price = int.Parse(Console.ReadLine());
            tovar1.Kvo = int.Parse(Console.ReadLine());
            Console.WriteLine($"{tovar.ToString()}\n{tovar1.ToString()}");
            Console.ReadLine();
        }
    }
}
