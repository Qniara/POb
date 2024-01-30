using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using szyper_16_01_2024_2.Classes;

namespace szyper_16_01_2024_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person KurtCobain = new Person();
            //KurtCobain.FirstName = "Kurt";
            KurtCobain.LastName = "Cobain";
            KurtCobain.Height = 178;
            KurtCobain.Age = 27;
            KurtCobain.SetFirstName("Kurt");
            Console.WriteLine("Imie: "+KurtCobain.FirstName);
            Console.WriteLine("Nazwisko: " + KurtCobain.LastName);
            Console.WriteLine("Wzrost: " + KurtCobain.Height);
            Console.WriteLine("Wiek: " + KurtCobain.Age);

            Teacher t1 = new Teacher();
            t1.Subjects = new List<string> { "Math", "IT", "History" };
            foreach (var subject in t1.Subjects)
            {
                Console.WriteLine(subject);
            }
            Console.WriteLine(string.Join(", ",t1.Subjects));
            KurtCobain.Adress = new Adress();
            KurtCobain.Adress.City = "Seatlle";
            KurtCobain.Adress.Street = "Tahiti";
            KurtCobain.Adress.HouseNumber = 226;
            KurtCobain.Adress.Street = "GoDamnPlan";
            Console.WriteLine(KurtCobain.Adress.GetAdress());

            //KurtCobain.DateOfBirth = DateTime.Now;
            //Console.WriteLine(KurtCobain.DateOfBirth);//Aktualna godzina

            //KurtCobain.DateOfBirth = DateTime();
            //Console.WriteLine(KurtCobain.DateOfBirth); //01.01.0001 00:00

            KurtCobain.DateOfBirth = new DateTime(1967, 02, 20, 12, 0, 0);
            Console.WriteLine("Data urodzenia: "+ KurtCobain.DateOfBirth.ToLongDateString());

            Console.Clear();
            Person FreddieMercury = new Person();
            FreddieMercury.Gender = Gender.male;
            FreddieMercury.Permission = Permission.admin;
            Console.WriteLine($"{FreddieMercury.Gender}\n{FreddieMercury.Permission}");
            
            Console.ReadKey();
        }
    }
}
