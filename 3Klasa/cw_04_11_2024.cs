using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace cw_04_11_2024
{
	class Book : IComparable<Book>
	{
		public string title;
		public string author;
		public int YearOfPublication;
		public double price;
		public int CompareTo(Book other)
		{
			if (other == null) return 1;
			return price.CompareTo(other.price);
		}
		public override string ToString()
		{
			return $"{title}, {author}, {YearOfPublication}, {price} zl";
		}
		public Book(string title, string author, int yearOfPublication, double price)
		{
			this.title = title;
			this.author = author;
			this.YearOfPublication = yearOfPublication;
			this.price = price;
		}
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Book> books = new List<Book>();
			books.Add(new Book("Hobbit", "Nowak", 1937, 44.99));
			books.Add(new Book("Hobbit2", "Pawlak", 2000, 149.99));
			books.Add(new Book("Hobbit3", "Arbuz", 2000, 14.99));
			books.Add(new Book("Hobbit4", "Arbuz", 1948, 9.99));
			Console.WriteLine("Lista ksiazek: ");
			foreach (Book book in books)
			{
				Console.WriteLine(book.ToString());
			}
			books.Sort();
			Console.WriteLine("\nLista ksiazek wedlug ceny:");
			foreach (Book book in books)
			{
				Console.WriteLine(book.ToString());
			}
			Console.WriteLine("\nPosortowane wedlug daty publikacji: ");
			var sortedByYear = books.OrderBy(b => b.YearOfPublication);
			foreach(Book book in sortedByYear)
			{
				Console.WriteLine(book.ToString());
			}
			Console.WriteLine("\nPosortowane wedlug autora: ");
			var sortedByAuthor = books.OrderBy(b => b.author);
			foreach(Book book in sortedByAuthor)
			{
				Console.WriteLine(book.ToString());
			}
			Console.WriteLine("\nPosortowane wedlug tytulu: ");
			var sortedByTitle = books.OrderBy(b => b.title);
			foreach(Book book in sortedByTitle)
			{
				Console.WriteLine(book.ToString());
			}
			Console.WriteLine("Sortowanie wedlug ceny nie rosnaca a nasteonie wedlug roku od najstarszej ksiazki: ");
			var sortedByPriceAndYear = books.OrderByDescending(b => b.price).ThenBy(b=>b.YearOfPublication);

			Console.ReadKey();
		}
	}
}
