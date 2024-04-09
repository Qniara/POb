using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_09_04_2024_2
{
    internal class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public bool IsDamaged { get; set; }
        public Car(string brand, string model)
        {
            Brand = brand;
            Model = model;
            IsDamaged = false;
        }
        ~Car()
        {
            Console.WriteLine($"Samochod {Brand} {Model} jest zezlomowany");
        }
        public void Drive()
        {
            if( IsDamaged )
            {

            }
            else
            {
                Console.WriteLine($"Samochod {Brand} {Model} porusza sie");
            }
        }
        public void SimulateRandomDamage()
        {
            Random r= new Random();
            int damageType = r.Next(1, 4);
            switch (damageType)
            {
                case 1:
                    Console.WriteLine("Samochod ma przebita opone");
                    break;
                case 2:
                    Console.WriteLine("Samochod ma uszkodzony silnik");
                    break;
                case 3:
                    Console.WriteLine("Samochod ma zepsute swiatlo");
                    break;
            }
        }
    }
}
