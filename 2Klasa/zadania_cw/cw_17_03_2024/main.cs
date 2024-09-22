using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_17_03_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            ShowMainMenu(animals);
        }
        static void ShowMainMenu(List<Animal> animals)
        {
            Console.Clear();
            Console.WriteLine("1. Dodaj zwierze");
            Console.WriteLine("2. Wyswietl szczegoly dotyczace zwierzecia");
            Console.WriteLine("3. Wyswietl liste zwierzat");
            Console.WriteLine("4. Usun zwierze");
            Console.WriteLine("5.Wyjdz z programu");
            Console.Write("Wybierz numer: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    CreateAnimal(animals);
                    ShowMainMenu(animals);
                    break;
                case "2":
                    ShowAnimalDetails(animals);
                    ShowMainMenu(animals);
                    break;
                case "3":
                    ShowAnimalList(animals);
                    ShowMainMenu(animals);
                    break;
                case "4":
                    DeleteAnimal(animals);
                    ShowMainMenu(animals);
                    break;
                case "5":
                    Console.WriteLine("\nDziekujemy za skorzytsanie z programu.\n");
                    break;
                default:
                    Console.WriteLine("\nWprowadzono niepoprawne dane.\n");
                    Console.ReadKey();
                    ShowMainMenu(animals);
                    break;
            }
        }
        static void ShowAnimalList(List<Animal> animals)
        {
            throw new NotImplementedException();
        }

        static void ShowAnimalDetails(List<Animal> animals)
        {
            throw new NotImplementedException();
        }

        static void CreateAnimal(List<Animal> animals)
        {
            Console.Clear();
            Animal a = new Animal();
            Console.Write("Podaj imie: ");
            string name = Console.ReadLine();
            a.Name = name;
            Console.Write("Podaj wiek: ");
            int age = int.Parse(Console.ReadLine());
            a.Age = age;
            Console.Write("Napisz rodzaj: ");
            Kind kind = (Kind)Enum.Parse(typeof(Kind), Console.ReadLine());
            a.Kind = kind;
            animals.Add(a);
            Console.WriteLine("Dodano nowe zwierze o nazwie: " + a.Name);
        }
        static void DeleteAnimal(List<Animal> animals)
        {
            throw new NotImplementedException();
        }
    }
}
