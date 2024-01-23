using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szyper_16_01_2024_2.Classes
{
    internal class Adress
    {
        public string City { get; set; }
        public string Street { get; set; }
        public float HouseNumber { get; set; }
        public float PostalCode { get; set; }
        public string GetAdress()
        {
            return $"Miasto: {City}, ulica {Street} {HouseNumber}, kod pocztowy {PostalCode}";
        }
    }
}
