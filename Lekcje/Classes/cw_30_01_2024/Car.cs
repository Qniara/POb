using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_30_01_2024
{
    enum Color
    {
        Red,
        Green,
        Blue,
        White,
        Black,
        Pink
    }
    internal class Car
    {
        private string Brand { get; set; }
        private string Model { get; set; }
        private Color Color { get; set; }
        private int Year { get; set; }
        public void ShowInformation()
        {
            Console.WriteLine($"This is {Brand} {Model} from {Year}, color {Color}");
        }
    }
}
