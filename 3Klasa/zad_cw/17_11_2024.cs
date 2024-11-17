using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dupa
{
    public class Book: IComparable<Book>
    {
        public string title;
        public int price;
        public int CompareTo(Book other)
        {
            if (other == null) return 1;
            return price.CompareTo(other.price);
        }
        public Book(string title, int price)
        {
            this.title = title;
            this.price = price;
        }
        public override string ToString()
        {
            return $"{title}, {price} zl";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            Book book1 = new Book("dupa", 15);
            Book book2 = new Book("pupa", 10);
            Book book3 = new Book("kupa", 20);

            books.Add(book1);
            books.Add(book2);
            books.Add(book3);

            int n = 0;
            foreach(Book book in books)
            {
                n++;
                Console.WriteLine($"{n}. " + book.ToString());
            }

            Console.WriteLine("\nPosortowane wedlug ceny: ");
            books.Sort();
            n = 0;
            foreach (Book book in books)
            {
                n++;
                Console.WriteLine($"{n}. " + book.ToString());
            }

            Console.WriteLine("\nPosortowane wedlug tytulu: ");
            var titlesort = books.OrderBy(b => b.title);
            n = 0;
            foreach(Book book in titlesort)
            {
                n++;
                Console.WriteLine($"{n}. " + book.ToString());
            }

            Console.WriteLine("\nPosortowane wedlug ceny a potem od tytulu desc");
            var pricetitlesort = books.OrderByDescending(b => b.price).ThenBy(b=>b.title);
            n = 0;
            foreach(Book book in pricetitlesort)
            {
                n++;
                Console.WriteLine($"{n}. " + book.ToString());
            }
        }
    }
}
