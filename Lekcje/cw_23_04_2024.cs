using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cw_23_04_2024
{
    internal class Program
    {
        public enum TypPaliwa
        {
            petrol, diesel, electric
        }
        public class Vehicle
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public double Fuel { get; private set; }
            public TypPaliwa FuelType { get; protected set; }
            public ushort Speed { get; set; }
            public virtual void StartEngine()
            {
                Console.WriteLine("Engine started");
            }
            public virtual void StopEngine()
            {
                Console.WriteLine("Engine stopped");
            }
            public void Refuel(double amount)
            {
                Fuel += amount;
                Console.WriteLine();
            }
        }
        public class Car : Vehicle
        {
            public int NumberOfDoors { get; set; }
            public int CurrentGear { get; set; }
            public int MaxGear { get; set; }
            public bool IsAutomatic { get; set; }
            public override void StartEngine()
            {
                //base.StartEngine(); //przeciazenie
                Console.WriteLine("Silnik samochodu uruchomiony"); //przyslanianie
            }
            public override void StopEngine()
            {
                Console.WriteLine("Silnik zatrzymany");
            }
            public void ChangeGear(byte gear)
            {
                if(!IsAutomatic)
                {
                    if(gear<0 || gear > MaxGear)
                    {
                        Console.WriteLine("Nieprawidlowy bieg");
                    }
                    else
                    {
                        CurrentGear = gear;
                        Console.WriteLine($"Zmiana biegu na {gear}");
                    }
                }
                else
                {
                    Console.WriteLine("\nTen samochod ma automata");
                }
            }
            public void AutomaticGearChange(int speed)
            {
                if(IsAutomatic)
                {
                    if (speed < 20) CurrentGear = 1;
                    if (speed > 20 && speed < 40) CurrentGear = 3;
                    else CurrentGear = 3;
                    Console.WriteLine($"Automatyczna zmiana biegow na {CurrentGear} dla predkosci {speed}.");
                }
                else
                {
                    Console.WriteLine("Manualna skrzynia biegow");
                }
            }
        }
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle();
            v.Brand = "Toster";
            v.StartEngine();

            Car car = new Car();
            car.Brand = "Fiat";
            Console.WriteLine(car.Brand);
            car.NumberOfDoors = 4;

            Car car1 = new Car { Brand="Toyota", Model="Avensis", NumberOfDoors= 4, FuelType = TypPaliwa.petrol};
        }
    }
}
