using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
    public class Author : Person
    {
        public List<Book> BookList { get; set; }
        public Author(string firstName, string lastName) : base(firstName, lastName)
        {
            BookList = new List<Book>();
        }
        public void AddBook(Book book)
        {
            BookList.Add(book);
        }
    }
    public  class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public int PublicationYear { get; set; }
        public Book(string title, Author author, int publicationYear)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
        }
    }
    public class Reader : Person
    {
        public List<Book> BorrowedBookList { get; set;}
        public Reader(string  firstName, string lastName) : base (firstName, lastName)
        {
            BorrowedBookList = new List<Book>();
        }
        public void AddBook(Book book)
        {
            BorrowedBookList.Add(book);
            Console.WriteLine($"Czytelnik {FirstName} {LastName} wyporzyczyl ksiazke {book.Title}.");
        }
    }
    public class Library : Reader
    {
        public List<Book> BookList { get; set;}
        public List<Reader> ReaderList { get; set;}
        public Library(List<Book> bookList, List<Reader> readerList)
        {
            BookList = bookList;
            ReaderList = readerList;
        }
        public void AddBook(Book book)
        {
            BookList.Add(book);

        }
        public void AddReader(Reader reader)
        {
            ReaderList.Add(reader);
        }
        public void BorrowBook(Book book, Reader reader)
        {
            BorrowedBookList.Add(book);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author("Pan", "Tadeusz");
            Book book = new Book("Adam Mickiewicz", author, 1834);
        }
    }
}
