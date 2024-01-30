using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_30_01_2024
{
    internal class Parking
    {
        private string Name { get; set; }
        private string[] Cars { get; set; }
        public void AddCar(string name)
        {
            
        }
        public void RemoveCar(int number)
        {

        }
        public void ShowCars()
        {
            foreach( var car in Cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
