using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using static cw_23_04_2024.Program.Car;
using static cw_23_04_2024.Program.Vehicle;

namespace cw_23_04_2024
{
    internal class Program
    {
        public class Vehicle
        {
            public enum FuelType
            {
                Petrol,
                Diesel,
                Electric
            }

            public string Brand { get; set; }
            public string Model { get; set; }
            //public double Fuel { get; private set; }
            public FuelType Fueltype { get; set; }
            public ushort Speed { get; set; }
            public void StartEngine()
            {
                Console.WriteLine("Engine started");
            }
            public void StopEngine()
            {
                Console.WriteLine("Engine stopped");
            }
        }
        public class Car : Vehicle
        {
            public double Fuel { get; private set; }
            public int NumberOfDoors { get; set; }
            public int CurrentGear { get; set; }
            public int MaxGear { get; set; }
            public bool IsAutomatic { get; set; }
            public virtual void StartEngine()
            {
                base.StartEngine(); //przeciazenie
                Console.WriteLine("Silnik samochodu uruchomiony"); //przyslanianie //"chleb pszenny","3.99f", new DataTime = 30.04.24r , true | zad zam - A, C, B, B (chyba xd)
            }
            public virtual void StopEngine()
            {
                Console.WriteLine("Silnik zatrzymany");
            }
            public void Refuel(double amount)
            {
                Fuel += amount;
                Console.WriteLine();
            }
            public void ChangeGear(byte gear)
            {
                if (!IsAutomatic)
                {
                    if (gear < 0 || gear > MaxGear)
                    {
                        Console.WriteLine("\nNieprawidłowy bieg");
                    }
                    else
                    {
                        CurrentGear = gear;
                        Console.WriteLine("\nZmiana biegu na {gear}");
                    }
                }
                else
                {
                    Console.WriteLine("\nSamochód ma automat");
                }
            }
            private void AutomaticGearChange(int speed)
            {
                if (IsAutomatic)
                {
                    if (speed < 20)
                    {
                        CurrentGear = 1;
                    }
                    else if (speed > 20 && speed < 40)
                    {
                        CurrentGear = 2;
                    }
                    else
                    {
                        CurrentGear = 3;
                    }
                    Console.WriteLine("Automatyczna zmiana biegów na {CurrentGear} dla prędkości {speed} km/h");
                }
                else
                {
                    Console.WriteLine("\nManualna skrzynia biegów");
                }
            }
        }
        public class ElectricCar : Car
        {
            public double BatteryCapacity { get; set; }
            public override void StartEngine()
            {
                base.StartEngine();
            }
            public override void StopEngine()
            {
                base.StopEngine();
            }
            public void ChargeBattery(double kwh)
            {
                if (kwh <= 0) Console.WriteLine("\nNie mozna naladowac baterii ujemna wartoscia.");
                else
                {
                    BatteryCapacity = kwh;
                    Console.WriteLine($"Naladowano baterie o {kwh} kwh.");
                }
            }
        }
        public static class AnimationHelper
        {
            public static void ShowProgress(string prefix, string suffix, int delay, int totalsteps)
            {

            }
        }
        static void Main(string[] args)
        {
            ElectricCar tesla = new ElectricCar
            {
                Brand = "Tesla",
                Model = "S",
                NumberOfDoors = 5,
                Fueltype = FuelType.Electric,
                MaxGear = 1,
                IsAutomatic = true,
                BatteryCapacity = 95
            };
            tesla.StartEngine();
            tesla.StopEngine();
            tesla.ChargeBattery(5);

            Vehicle v = new Vehicle();
            v.Brand = "Toster";
            v.StartEngine();

            //Car car = new Car();
            //car.Brand = "Fiat";
            //Console.WriteLine(car.Brand);
            //car.NumberOfDoors = 4;

            //Car car1 = new Car { Brand = "Toyota", Model = "Avensis", NumberOfDoors = 4, FuelType = TypPaliwa.petrol };

            //Vehicle v = new Vehicle();
            //v.Brand = "Toster";
            //v.StartEngine();

            //Car car = new Car();
            //car.Brand = "Fiat";
            //Console.WriteLine(car.Brand);
            //car.NumberOfDoors = 4;

            //Car car1 = new Car { Brand = "Toyota", Model = "Avensis", NumberOfDoors = 4, FuelType = TypPaliwa.petrol };

            //this song is dedicated to all the guns n fucking roses fans that stack with
            //us through all the fucking shit
        }
    }
}
