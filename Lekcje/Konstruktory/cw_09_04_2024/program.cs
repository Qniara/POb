using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_09_04_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Ferrari", 300);
            Car car2 = new Car("Porsche", 280);
            Car car3 = new Car("Lamborghini", 320);

            car1.StartRace();
            car2.StartRace();
            car3.StartRace();
            car2 = null;
            GC.Collect();
        }
    }
}
