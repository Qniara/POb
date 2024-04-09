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
                Console.Clear();
                Console.WriteLine("Menu symulatora jazdy samochodem: ");
                Console.WriteLine("1. Dodaj samochod");
                Console.WriteLine("2. Wyswietl liste samochodow");
                Console.WriteLine("3. Jedz samochodem");
                Console.WriteLine("4. Symuluj losowe uszkodzenie");
                Console.WriteLine("5. Zezlomuj samochod");
                Console.WriteLine("6. Wyjscie");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Podaj marke: ");
                        string brand = Console.ReadLine();
                        Console.Write("Podaj model: ");
                        string model = Console.ReadLine();
                        Car newcar = new Car(brand, model);
                        cars.Add(newcar);
                        cardic[cars.Count] = newcar;
                        Console.WriteLine($"Dodano samochod {brand} {model}");
                        break;
                    case 2:
                        Console.WriteLine("Lista samochodow: ");
                        foreach (Car car in cars)
                        {
                            Console.WriteLine($"{car.Brand} {car.Model}");
                        }
                        break;
                    case 3:
                        Console.Write("Podaj numer samochodu do jazdy: ");
                        int carNumber = int.Parse(Console.ReadLine());
                        if (cardic.TryGetValue(carNumber, out Car selectedCar))
                        {
                            selectedCar.Drive();
                        }
                        else
                        {
                            Console.WriteLine("\nNiepoprawny numer samochodu");
                        }
                        break;
                    case 4:
                        Console.Write("Podaj numer samochodu do uszkodzenia: ");
                        int damagedCarNumber = int.Parse(Console.ReadLine());
                        if(cardic.TryGetValue(damagedCarNumber, out Car damagedCar))
                        {
                            damagedCar.SimulateRandomDamage();
                        }
                        else
                        {
                            Console.WriteLine("Nieprawidlowy numer samochodu");
                        }
                        break;
                    case 5:
                        Console.Write("Podaj numer samochodu do zezlomowania");
                        int scrappedCarNumber = int.Parse(Console.ReadLine());
                        if(cardic.TryGetValue(scrappedCarNumber, out Car scrappedCar))
                        {
                            scrappedCar = null;
                            GC.Collect();
                            Console.WriteLine($"Samochod {scrappedCar} zostal zezlomowany");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Zamykanie symulatora.");
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
