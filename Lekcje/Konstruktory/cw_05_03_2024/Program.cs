using cw_05_03_2024.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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
            Animal a3 = new Animal("Papuga", new DateTime(2020, 08, 10), false, Kind.Ptak);
            Console.WriteLine(a3.Describe());
            a3.ShowAge();

            //Tworzenie listy zwierzat
            List<Animal> animals = new List<Animal>();
            //Wyswietlanie menu
            ShowMainMenu(animals);
        }

        private static void ShowMainMenu(List<Animal> animals)
        {
            Console.Clear();
            Console.WriteLine("Witaj w programie do zarzadzania zwierzetami.\n");
            Console.WriteLine("1.Dodaj zwierze.");
            Console.WriteLine("2.Pokaz liste zwierzat.");
            Console.WriteLine("3.Pokaz szczegoly zwierzat.");
            Console.WriteLine("4.Usun zwierze.");
            Console.WriteLine("5.Zakoncz program.\n");
            Console.Write("Wybierz jedna z opcji: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddNewAnimal(animals);
                    break;
                case "2":
                    ShowAnimalList(animals);
                    break;
                case "3":
                    ShowAnimalDeatails(animals);
                    break;
                case "4":
                    RemoveAnimal(animals);
                    break;
                case "5":
                    Console.WriteLine("Dziekujemy za skorzystanie z programu.");
                    break;
                default:
                    Console.WriteLine("Niepoprawny klaiwsz.");
                    ShowMainMenu(animals);
                    break;
            }
        }
        private static void RemoveAnimal(List<Animal> animals)
        {
            Console.WriteLine("Usuwanie zwierzecia.");
        }

        private static void ShowAnimalDeatails(List<Animal> animals)
        {
            Console.WriteLine("Szegoly na temat zwierzecia.");
        }

        private static void ShowAnimalList(List<Animal> animals)
        {
            Console.WriteLine("Lista zwierzat.");
        }

        private static void AddNewAnimal(List<Animal> animals)
        {
            Console.Clear();
            Console.Write("Podaj nazwe zwierzecia: ");
            string name = Console.ReadLine();
            Console.Write("Podaj date urodzenia (RRRR-MM--DD): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Czy zwierze jest ssakiem (tak/nie): ");
            bool isMammal = Console.ReadLine().ToLower() == "tak";
            Console.Write("Podaj rodzaj zwierzecia (Ptak, Ryba, Plaz, Ssak, Gad): ");
            Kind kind = (Kind)Enum.Parse(typeof(Kind), Console.ReadLine());
            Animal animal = new Animal(name, birthDate, isMammal, kind);
            animals.Add(animal);
            Console.WriteLine($"Dodano nowe zwierze: {name}");
            Console.WriteLine("Nacisnij dowolny klaiwsz aby wrocic do menu.");
            Console.ReadKey();
            ShowMainMenu(animals);
        }
    }
}
