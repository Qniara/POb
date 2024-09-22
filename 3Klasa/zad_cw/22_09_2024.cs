using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_09_2024
{
    public class Shape
    {
        public virtual float CalculateArea()
        {
            return 0;
        }
    }
    class Rectangle : Shape
    {
        float width;
        float height;
        public override float CalculateArea()
        {
            return this.width * this.height;
        }
        public Rectangle(float width, float height)
        {
            this.width = width;
            this.height = height;
        }
    }
    public class Kwadrat : Shape
    {
        float width;
        public override float CalculateArea()
        {
            return this.width * this.width;
        }
        public Kwadrat(float width)
        {
            this.width = width;
        }
    }
    internal class Program
    {
        public static void ShowMenu()
        {
            Console.WriteLine("Wybierz numer: ");
            Console.WriteLine("1. Prostokat");
            Console.WriteLine("2. Kwadrat");
            Console.WriteLine("3. Wyjscie z programu");
            Console.Write("Podaj numer: ");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.Write("Podaj szerokosc: ");
                    float width = float.Parse(Console.ReadLine());
                    Console.Write("Podaj wysokosc: ");
                    float height = float.Parse(Console.ReadLine());
                    Rectangle rect = new Rectangle(width, height);
                    Console.WriteLine("Pole: {0}", rect.CalculateArea());
                    Console.ReadKey();
                    Console.Clear();
                    ShowMenu();
                    break;
                case 2:
                    Console.Write("Podaj szerokosc: ");
                    float width1 = float.Parse(Console.ReadLine());
                    Kwadrat kwadrat = new Kwadrat(width1);
                    Console.WriteLine("Pole: {0}", kwadrat.CalculateArea());
                    Console.ReadKey();
                    Console.Clear();
                    ShowMenu(); 
                    break;
                case 3:
                    Console.WriteLine("Koniec");
                    break;
                default:
                    Console.WriteLine("Podano nie poprawny numer.");
                    Console.ReadKey();
                    Console.Clear();
                    ShowMenu();
                    break;
            }
        }
        static void Main(string[] args)
        {
            ShowMenu();
        }
    }
}
