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
                    Console.WriteLine("\nDziekujemy za skorzystanie z programu.\n");
                    break;
                default:
                    Console.WriteLine("Niepoprawny klaiwsz.");
                    ShowMainMenu(animals);
                    break;
            }
        }
        private static void RemoveAnimal(List<Animal> animals)
        {
            Console.Clear();
            if (animals.Count == 0)
            {
                Console.WriteLine("Na liscie nie zadnego zwierzecia.");
            }
            else
            {
                Console.WriteLine("1. Usuń wszystkie zwierzeta");
                Console.WriteLine("2. Usuń jedno zwierzę");
                Console.Write("Wybierz jedna z opcji: ");
                string choice = Console.ReadLine();
                switch(choice)
                {
                    case "1":
                        animals.Clear();
                        if (animls.Count == 0)
                        {
                            Console.WriteLine("\nUsunieto wszystkie zwierzeta.\n");
                        }
                        break;
                    case "2":
                        ShowAnimalList(animals);
                        Console.Write("Numer zwierzecia ktore chce usunac uzytkownik: ");
                        int index = int.Parse(Console.ReadLine());
                        if(index >=0 && index < animals.Count)
                        {
                            animals.RemoveAt(index);
                            Console.WriteLine("Usunieto zwierze.");
                        }
                        else
                        {
                            Console.WriteLine("Podano niepoprany numer");
                        }
                        break;
                    default:
                        Console.WriteLine("Niepoprawna opcja");
                        RemoveAnimal(animals);
                        break;
                }
            }
        }

        private static void ShowAnimalDeatails(List<Animal> animals)
        {
            Console.Clear();
            if (animals.Count == 0)
            {
                Console.WriteLine("Na liscie nie zadnego zwierzecia.");
            }
            else
            {
                for(int i = 0; i < animals.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + animals[i].Name);
                }
                Console.WriteLine("\nPodaj numer zwierzecia ktorego szczegoly chcesz zobaczyc.");
                int index = int.Parse(Console.ReadLine()) - 1;
                if(index>=0 && index < animals.Count)
                {
                    Animal animal = animals[index];
                    Console.WriteLine("Szczegolny na temat zwierzecia: ");
                    Console.WriteLine(animal.Describe());
                    animal.ShowAge();
                    //Console.WriteLine("Imie: " + animal.Name);
                    //Console.WriteLine("Data urodzenia: " + animal.BirthDate.ToShortDateString());
                    //Console.WriteLine("Czy jest ssakiem: " + animal.IsMammal);
                    //Console.WriteLine("Rodzaj: " + animal.Kind);
                }
                else
                {
                    Console.WriteLine("Niepoprawny numer, sproboj ponownie.");
                }
                Console.WriteLine("\nWcisnij dowolny klawisz aby wrocic do menu glownego.\n");
                Console.ReadKey();
                ShowMainMenu(animals);
            }
        }
        private static void ShowAnimalList(List<Animal> animals)
        {
            Console.Clear();
            if (animals.Count == 0)
            {
                Console.WriteLine("Na liscie nie zadnego zwierzecia.");
            }
            else
            {
                Console.WriteLine("Lista zwierzat: ");
                for(int i = 1; i <= animals.Count; i++)
                {
                    Console.WriteLine(i + ". " + animals[i-1].Name);
                }
            }
            Console.WriteLine("Wcisnij dowolny klawisz aby wrocic do menu głównego.");
            Console.ReadKey();
            ShowMainMenu(animals);
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
