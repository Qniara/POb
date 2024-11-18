using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp9
{
    interface ICar
    {
        void StartEngine();
        void Drive();
    }
    abstract class Car : ICar
    {
        public string Brand;
        public string Model;
        public int Year;
        public string Owner;

        public Car(string brand, string model, int year, string owner)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Owner = owner;
        }
        public Car() { }
        public void StartEngine()
        {
            Console.WriteLine($"\n{Brand} {Model} uruchamia silnik");
        }
        public abstract void Drive();
    }
    class ElectricCar : Car
    {
        public ElectricCar(string brand, string model, int year, string owner)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Owner = owner;
        }

        public override void Drive()
        {
            Console.WriteLine("\nJazda na elektrycznosci!");
        }
    }
    class GasolineCar : Car
    {
        public GasolineCar(string brand, string model, int year, string owner)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Owner = owner;
        }

        public override void Drive()
        {
            Console.WriteLine("\nJazda na benzynie");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            ElectricCar car1 = new ElectricCar("Tesla", "Model S", 2020, "Jan Kowalski");
            GasolineCar car2 = new GasolineCar("Ford", "Mustang", 2018, "Anna Nowak");
            ElectricCar car3 = new ElectricCar("Nissan", "Leaf", 2019, "Piotr Wiśniewski");
            GasolineCar car4 = new GasolineCar("BMW", "X5", 2017, "Katarzyna Zielińska");

            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);
            cars.Add(car4);

            DisplayMenu();

            //car1.StartEngine();
            //car1.Drive();
            //car2.StartEngine();
            //car2.Drive();
            //car3.StartEngine();
            //car3.Drive();
            //car4.StartEngine();
            //car4.Drive();

            //Console.WriteLine("\n");

            //foreach(Car car in cars)
            //{
            //    car.StartEngine();
            //    car.Drive();
            //}
            void DisplayMenu()
            {
                Console.WriteLine("Wybierz opcje: ");
                Console.WriteLine("1. Sortowanie wedlug wlasciciela");
                Console.WriteLine("2. Sortowanie wedlug roku produkcji");
                Console.WriteLine("3. Sortowanie wedlug marki");
                Console.WriteLine("4. Sortowanie wedlug modelu");
                Console.WriteLine("5. Wyjscie");
                Console.Write("\nOpcja: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Sort1();
                        Console.ReadKey();
                        Console.Clear();
                        DisplayMenu();
                        break;
                    case 2:
                        Sort2();
                        Console.ReadKey();
                        Console.Clear();
                        DisplayMenu();
                        break;
                    case 3:
                        Sort3();
                        Console.ReadKey();
                        Console.Clear();
                        DisplayMenu();
                        break;
                    case 4:
                        Sort4();
                        Console.ReadKey();
                        Console.Clear();
                        DisplayMenu();
                        break;
                    case 5:
                        Console.WriteLine("Koniec programu.");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("\nPodano nie poprawna opcje.");
                        Console.ReadKey();
                        Console.Clear();
                        DisplayMenu();
                        break;
                }
            }
            void Sort1()
            {
                Console.WriteLine("\nPosrotowane alfabetycznie wedlug wlasciciela: ");
                var wlasciciel = cars.OrderBy(b => b.Owner);
                foreach (Car car in cars)
                {
                    Console.WriteLine($"{car.Brand} {car.Model} {car.Year} {car.Owner}");
                }
            }
            void Sort2()
            {
                Console.WriteLine("\nPosrotowane rosnoco wedlug roku produkcji: ");
                var rok = cars.OrderBy(b => b.Year);
                foreach (Car car in cars)
                {
                    Console.WriteLine($"{car.Brand} {car.Model} {car.Year} {car.Owner}");
                }
            }
            void Sort3()
            {
                Console.WriteLine("\nPosrotowane alfabetycznie wedlug marki: ");
                var marka = cars.OrderBy(b => b.Brand);
                foreach(Car car in cars)
                {
                    Console.WriteLine($"{car.Brand} {car.Model} {car.Year} {car.Owner}");
                }
            }
            void Sort4()
            {
                Console.WriteLine("\nPosrotowane alfabetycznie wedlug modelu: ");
                var model = cars.OrderBy(b => b.Model);
                foreach (Car car in cars)
                {
                    Console.WriteLine($"{car.Brand} {car.Model} {car.Year} {car.Owner}");
                }
            }
        }
    }
}
