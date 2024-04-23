using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_23_04_2024
{
    internal class Program
    {
        public class Vehicle
        {
            public string Brand { get; set; }
            public string Model { get; set; }
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
            public int NumberOfDoors { get; set; }
            public override void StartEngine()
            {
                base.StartEngine(); //przeciazenie
                Console.WriteLine("Silnik samochodu uruchomiony"); //przyslanianie
            }
            public override void StopEngine()
            {
                Console.WriteLine("Silnik zatrzymany");
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
        }
    }
}
