using ConsoleApp1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("John");
            Person p2 = new Person("Freddie", "Mercury");
            Person p3 = new Person("Kurt", "Cobain", 27);
            Person p3 = new Person("Kurt", "Cobain", 27, 177);
            //wyswietalnie wartosci walsciwosci
            Console.WriteLine(p1.GetData());
            Console.WriteLine(p2.GetData());
            Console.WriteLine(p3.GetData());
            //wyświetlanie liczby obiektów klasy Person
            Console.WriteLine($"Liczba obiektów klasy Person: {Person.Counter}");
        }
    }
}
