using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szyper_16_01_2024_2.Classes
{
    internal class Person
    {
        public string FirstName { get; private set; }
        //public string LastNam
        //e { private get; set; }            
        public string LastName { get; set; }
        public float Height { get; set; }
        public float Age { get; set; }
        public Adress Adress { get; set; }
        public Adress HouseNumber { get; set; }
        public Adress City { get; set; }
        public Adress Street { get; set; }
        public DateTime DateOfBirth { get; set; }

        public void SetFirstName(string name)
        {
            FirstName = name;
        }
        //public string GetLastName()
        //{
        //    return LastName;
        //}
    }
}
