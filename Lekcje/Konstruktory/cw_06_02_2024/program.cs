using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_06_02_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Kurt","Cobain");
            Console.WriteLine(p1.Firstname + " " + p1.Lastname);
        }
    }
}
