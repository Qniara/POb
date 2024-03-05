using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_05_03_2024.Classes
{
    enum Kind
    {
        Ptak,
        Ryba,
        Gad,
        Plaz,
        Ssak
    }
    internal class Animal
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsMammal { get; set; }
        public Kind Kind { get; set; }
        public Animal(string name)
        {
            Name = name;
            BirthDate = DateTime.MinValue; //domyślna data urodzenia
            IsMammal = true;
            Kind = Kind.Ssak;
        }
        public Animal(string name, DateTime birthDate):this(name)
        {
            BirthDate = birthDate;
        }
        public Animal(string name, DateTime birthDate, bool isMammal, Kind kind):this(name, birthDate)
        {
            Kind = kind;
        }
        //Metoda opisujaca zwierze
        public string Describe()
        {
            string description = $"Nazwa zwierzecia: {Name}\nData urodzenia: {BirthDate.ToShortDateString()} r.";
            if (IsMammal==true) description += "\nZwierze jest ssakiem.";
            else description += "\nZwierze nie jest ssakiem.";
            return description;
        }
        public void ShowAge()
        {
            int age=DateTime.Now.Year-BirthDate.Year;
            Console.WriteLine($"Wiek {Name} to: {age}");
        }
    }
}
