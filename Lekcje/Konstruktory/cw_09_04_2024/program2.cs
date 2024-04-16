using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cw_09_04_2024_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            Dictionary<int, Car> cardic = new Dictionary<int, Car>();
            while(true)
            {
                DisplayMenu();
                int choice = GetUserInput();
                switch (choice)
                {
                    case 1:
                        AddCar(cars,cardic);
                        Console.ReadKey();
                        break;
                    case 2:
                        DisplayCars(cardic);
                        break;
                    case 3:
                        DriveCar(cardic);
                        break;
                    case 4:
                        DisplayCars(cardic);
                        if (cars.Count != 0)
                        {
                            SimulateDamage(cardic);
                        }
                        break;
                    case 5:
                        DisplayCars(cardic);
                        if(cars.Count != 0)
                        {
                            ScrapCar(cars, cardic);
                        }
                        break;
                    case 6:
                        Console.WriteLine("Zamykanie symulatora.");
                        return;
                    default:
                        break;
                }
                Console.WriteLine("\nNAcisnij dowolny klawisz aby wrocic do menu\n");
                Console.ReadKey();
            }
        }

        private static void ScrapCar(List<Car> cars, Dictionary<int, Car> cardic)
        {
            int carNumber = GetUserInput(cardic);
            Console.WriteLine($"\nSamochod {cardic[carNumber].Brand} {cardic[carNumber].Model} zostal usuniety");
            cars.RemoveAt(carNumber);
            cardic.Remove(carNumber);
            Console.ReadKey();
        }

        private static void SimulateDamage(Dictionary<int, Car> cardic)
        {
            int damagedCarNumber = GetUserInput(cardic);
            Car carToSimulate = cardic[damagedCarNumber];
            carToSimulate.SimulateRandomDamage();
        }

        private static void DriveCar(Dictionary<int, Car> cardic)
        {
            int carNumber = GetUserInput();
            Car carToDrive = cardic[carNumber];
        }

        private static void DisplayCars(Dictionary<int, Car> cardic)
        {
            if (cardic.Count == 0)
            {
                Console.WriteLine("Lista jest pusta jak twoj lep.");
            }
            else
            {
                Console.WriteLine("\nLista samochodow: ");
                foreach (var carEntry in cardic)
                {
                    int key = carEntry.Key;
                    Car car = carEntry.Value;
                    Console.WriteLine($"Klucz: {key}, Marka: {car.Brand}, Model: {car.Model}");
                }
            }
            Console.ReadKey();
        }

        static void AddCar(List<Car> cars, Dictionary<int,Car> cardic)
        {
            Console.Clear();
            Console.Write("Podaj marke: ");
            string brand = Console.ReadLine();
            Console.Write("Podaj model: ");
            string model = Console.ReadLine();
            Car newcar = new Car(brand, model);
            cars.Add(newcar);
            cardic[cars.Count] = newcar;
            Console.WriteLine($"Dodano samochod {brand} {model}");
        }

        static int GetUserInput(Dictionary<int, Car> cardic = null)
        {
            int input;
            while (true)
            {
                Console.Write("\nPodaj wartosc: ");
                if(int.TryParse(Console.ReadLine(), out input))
                {
                    if(cardic==null || cardic.ContainsKey(input))
                    {
                        return input;
                    }
                    Console.WriteLine("\nNumer samochodu nie istnieje w slowniku.\n");
                }
                Console.WriteLine("\nNieprawidlowy format. Sproboj ponownie.\n");
            }
        }

        static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Menu symulatora jazdy samochodem: ");
            Console.WriteLine("1. Dodaj samochod");
            Console.WriteLine("2. Wyswietl liste samochodow");
            Console.WriteLine("3. Jedz samochodem");
            Console.WriteLine("4. Symuluj losowe uszkodzenie");
            Console.WriteLine("5. Zezlomuj samochod");
            Console.WriteLine("6. Wyjscie");
        }
    }
}
