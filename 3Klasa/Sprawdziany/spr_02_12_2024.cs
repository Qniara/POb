using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	public class Car
	{
		public string marka;
		public string model;
		public int rokProdukcji;
		public Car(string marka, string model, int rokProdukcji)
		{
			this.marka = marka;
			this.model = model;
			this.rokProdukcji = rokProdukcji;
		}
	}
	public class Person
	{
		public string imie;
		public string nazwikso;
	}
	public class Client : Person
	{
		List<Car> RentedCarsList;
		void RentCar(Client client ,Car car)
		{
			RentedCarsList.Add(car);
			RentedCarsList.Remove(car);
		}
		public Client(string imie, nazwisko imie)
		{
			this.imie = imie;
			this nazwisko = nazwisko;
		}
	}
	class CarRental
	{
		List <Car> CarsList;
		List <Client> CLientsList;
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			void Menu()
			{
				Console.Clear();
				Console.WriteLine("1. Dodawanie samochodu");
				Console.WriteLine("2. Dodawanie klientow");
				Console.WriteLine("3. Wypożyczanie samochodow");
				Console.WriteLine("4. Wyswietlanie informacji");
				Console.Write("Podaj numer:");
				int choice = int.Parse(Console.ReadLine());
				switch (choice)
				{
					case 1:
						Console.Clear();
						Console.Write("Podaj marke: ");
						string marka = Console.ReadLine();
						Console.Write("\nPodaj model: ");
						string model = Console.ReadLine();
						Console.Write("\nPodaj rok produkcji: ");
						int rok = int.Parse(Console.ReadLine());
						Car car = new Car(marka, model, rok);
						Console.WriteLine("Dodanio Samochod.");
						Console.ReadKey();
						Menu();
						break;
					case 2:
						Console.Clear();
						Console.Write("Podaj imie: ");
						string imie = Console.ReadLine();
						Console.Write("\nPodaj nazwisko: ");
						string nazwisko = Console.ReadLine();
						Client client = new Client(imie, nazwisko);
						Console.ReadKey();
						Menu();
						break;
				}
			}
		}
	}
}
