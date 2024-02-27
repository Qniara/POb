using Microsoft.SqlServer.Server;
using System;
using System.Data.SqlTypes;

namespace ConsoleApp1.Classes
{
    internal class Person
    {
        //statyczne pole które przechowywuje liczbe obiektów klasy Person
        public static int Counter = 0;

        //właściwości
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public float Height { get; set; }

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
        //Konstruktor domyśly jest bezparamaetrowyadnego. Jeli klasa nie ma żadnego
        //konstruktora to konstruktor domyślny jest wywoływany przy tworzeniu obiektu.
        //Inicjuje on wszystkie pola do ich wartości domyślnych. Jeśli zdefiniujemy jakiś
        //konstruktor prametryczny to nie otrzymamy automatycznie konstruktora domyślnego.

        //Dodać konstruktor domyślny
        public Person()
        {
            Console.WriteLine("Konstruktor domysny klasy Person");
            Name = "BRUDNY";
            Surname = "KIBEL";
            Counter++;
        }
        //Konstrutor parametryczny ma co najmniej jeden parametr. Służy do inicjowania pól
        //obiektu zgodnie z wartościami podanymi przy tworzeniu obiektu. Możemy mieć wiele
        //konstruktorów parametrycznych, o ile różnią się liczbą lub typemparametrów.

        //Konstruktor parametryczny z jednym parametrem
        public Person(string name)
        {
            Console.WriteLine("Konstruktor parametryczny z jednym parametrem\r\n        public Person(string name)");
            Name = name;
            Counter++;
        }

        //Konstruktor parametryczny z dwoma parametrami
        public Person(string name, string surname)
        {
            Console.WriteLine("Konstruktor parametryczny z dwoma parametrami");
            Name = name;
            Surname = surname;
            Counter++;
        }

        //Konstruktor parametryczny z trzema parametrami
        public Person(string name, string surname, int age)
        {
            Console.WriteLine("Konstruktor parametryczny z dwoma parametrami");
            Name = name;
            Surname = surname;
            Age = age;
            Counter++;
        }

        //Konstruktor parametryzcny z czterema paramterami
        //this służy do wywołania innego konstruktora tej samej klasy, czyli konstruktora 
        //parametrycznego z trzema parametrami. Dzięki temu konstruktor z czterema
        //parametrami ni emusi inicjować pól Name, Surname, Age, a może skupić się nadodaniu
        //pola Height. Jest to sposób na uniknięcie powtarzania kodu i zapewnienie spojnści
        //danych.
        public Person(string name, string surname, int age, float height)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Height = height;
            Counter++;
        }
        public string GetData()
        {
            return $"Imie i nazwisko:{Name} {Surname}";
        }
    }
}
