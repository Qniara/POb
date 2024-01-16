using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Szyper_16_01_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Napisz program, który wczytuje z klawiatury liczbę n, a następnie n imion i
            //wieków osób.
            // Użyj tablicy, aby przechować wczytane imiona i wieki.
            // Użyj listy, aby przechować tylko te imiona, które zaczynają się na literę A.
            // Użyj słownika, aby przechować pary(imie, wiek) dla wszystkich osób, których
            //wiek jest większy niż 18 lat.
            // Wypisz na ekranie zawartość tablicy, listy i słownika.
            int n = ReadInt("Podaj liczbe osob: ", 0, int.MaxValue);
            string[] names = new string[n];
            int[] ages = new int[n];
            for(int i = 0; i < n; i++)
            {
                names[i] = ReadString($"Podaj imie osoby {i + 1}: ");
                ages[i] = ReadInt($"Podaj wiek osoby {i + 1}:", 0, 150);
            }
            List<string> nameStartsWithA=names.Where(e=>e.StartsWith("A", StringComparison.OrdinalIgnoreCase)).ToList();
            Console.WriteLine("\nWyswietlenie tablicy imion i wiekow: ");
            PrintArray(names, ages);
            Console.WriteLine("\nWyswietlanie imion na A: ");
            PrintArray(nameStartsWithA);
            Dictionary<string, int> adults = new Dictionary<string, int>();
            for(int i=0; i < names.Length; i++)
            {
                if (ages[i] >= 18)
                {
                    adults.Add(names[i], ages[i]);
                }
            }
            Console.WriteLine("\nSlownik osob pelnoletnich: ");
            PrintDictionary(adults);
            Console.ReadKey();
        }

        private static void PrintDictionary(Dictionary<string, int> adults)
        {
            for(int i = 0; i < adults.Count; i++)
            {
                Console.WriteLine();
            }
        }

        private static void PrintArray(List<string> nameStartsWithA)
        {
            foreach(var name in nameStartsWithA)
            {
                Console.WriteLine(name);
            }
        }
        private static void PrintArray(string[] names, int[] ages)
        {
            for(int i= 0; i < names.Length; i++)
            {
                Console.WriteLine($"{names[i]} - {ages[i]}");
            }
        }

        static int ReadInt(string prompt, int low, int high)
        {
            int result;
            bool valid;
            do
            {
                Console.WriteLine(prompt);
                valid = int.TryParse(Console.ReadLine(), out result) && result >= low && result <= high;
                if (!valid)
                {
                    Console.WriteLine($"Podaj liczby z zakresu od {low} do {high}: ");
                }
            } while (!valid);
            return result;
        }
        static string ReadString(string prompt)
        {
            string result;
            do
            {
                Console.Write(prompt);
                result = Console.ReadLine();
                if (string.IsNullOrEmpty(result))
                {
                    Console.WriteLine("Podaj nie pusty ciag zanków: ");
                }
            }while (string.IsNullOrEmpty(result));
            return result;
        }
    }
}


------------------------------------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szyper_16_01_2024_2
{
    internal class Program
    {
        class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public float Height { get; set; }
            public float Weight { get; set; }
        }
        static void Main(string[] args)
        {
            Person KurtCobain = new Person();
            //Obiekt klasy person posiada walsciwoszi i metody (dopytac starego)
        }
    }
}
