using cw_05_03_2024.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace cw_05_03_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal("Findusiaty");
            a.BirthDate = new DateTime(2016, 09, 27);
            Console.WriteLine(a.Describe());
            a.ShowAge();
            Console.WriteLine();
            Animal a2 = new Animal("Basislaw");
            a2.BirthDate = new DateTime(2018, 05, 10);
            Console.WriteLine(a2.Describe());
            a2.ShowAge();
            Console.WriteLine();
            Animal a3 = new Animal("Papuga");
            a3.BirthDate = new DateTime(2020, 08, 10);
            Console.WriteLine(a3.Describe());
            a3.ShowAge();

            Console.ReadKey();
        }
    }
}
