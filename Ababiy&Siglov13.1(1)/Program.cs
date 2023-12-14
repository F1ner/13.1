using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy_Siglov13._1_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Иванов", 3);
            Student student2 = new Student("", -7);
            string f = Console.ReadLine();
            int k= int.Parse(Console.ReadLine());
            Student student1 = new Student(f,k);
            
            Console.WriteLine($"{student.ToString()}\n{student2.ToString()}\n{student1.ToString()}");
            Console.ReadKey();
        }
    }
}
