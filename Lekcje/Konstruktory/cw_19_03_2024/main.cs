using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace cw_19_03_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime x = new DateTime(1994, 04, 05);
            Samochod perpetummobile = new Samochod("BEEMWU", "NIEWIEM", 1967, 50, false, x, StatusSamochodu.zabytkowy);
            perpetummobile.ShowInformation();
            Console.WriteLine(perpetummobile.ObliczWiekSamochodu());
        }
    }
}
