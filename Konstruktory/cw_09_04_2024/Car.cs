using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_09_04_2024
{
    internal class Car
    {
        private string name;
        private double speed;
        public Car(string name, double speed)
        {
            this.name = name;
            this.speed = speed;
        }
        ~Car()
        {
            Console.WriteLine($"Samochod {name} zostal znieszczoy");
        }
        public void StartRace()
        {
            Console.WriteLine($"Samochod {name} rozpoczął wyścig");
        }
    }
}
