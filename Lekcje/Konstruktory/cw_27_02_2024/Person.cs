using System;

namespace ConsoleApp1.Classes
{
    internal class Person
    {
        //statyczne pole które przechowywuje liczbe obiektów klasy Person
        public static int Counter = 0;

        //właściwości
        public string Name { get; set; }
        public string Surname { get; set; }

        //konstruktor statyczny jest wywoływany automatycznie aby zainicjować klase
        //przed utworzeniem 1 instanji. Konstruktor statyczny jest wywoływany
        //tylko raz przed pierwszym użyciem typu. Nie może mieć parametrów ani
        //modyfikatorów dostępu. Służy do inicjowania pól statycznych lub wykonywania
        //innych operacji statycznych. (wykonywanie dowolnego kodu który jest związany
        //z klasą a nie z jej obiektami np. ustawienie
        static Person()
        {
            Console.WriteLine("Statyczny konstruktor klasy Person");
            Counter++;
        }
    }
}
