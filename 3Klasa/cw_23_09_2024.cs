using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static _1_dziedziczenie.Program;

namespace _1_dziedziczenie
{
    internal class Program
    {
        public class Shape
        {
            public virtual float CalculateArea()
            {
                return 0;
            }

            public virtual float CalculatePerimeter()
            {
                return 0;
            }
        }

        public class Rectangle : Shape
        {
            private float width;
            private float height;

            public void SetDimension(float w, float h)
            {
                width = w;
                height = h;
            }

            public override float CalculateArea()
            {
                //return base.CalculateArea();//0
                return width * height;
            }

            public override float CalculatePerimeter()
            {
                return 2 * (width + height);
            }
        }

        public class Circle : Shape
        {
            private float radius;

            public Circle(float r)
            {
                radius = r;
            }

            public void SetRadius(float r)
            {
                radius = r;
            }

            public override float CalculateArea()
            {
                return (float)Math.Round((Math.PI * radius * radius), 2);
            }

            public override float CalculatePerimeter()
            {
                return (float)Math.Round((2 * Math.PI * radius), 2);
            }
        }
        public class Triangle : Shape
        {
            public float sideA;
            public float sideB;
            public float sideC;
            public Triangle(float sideA, float sideB, float sideC)
            {
                this.sideA=sideA;
                this.sideB=sideB;
                this.sideC=sideC;
            }
            public override float CalculateArea()
            {
                float s = (sideA + sideB + sideC) / 2;
                return s;
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Prostokąt");
                Console.WriteLine("2. Koło");
                Console.WriteLine("3. Trójkąt");
                Console.WriteLine("4. Trapez");
                Console.WriteLine("5. Kula");
                Console.WriteLine("6. Wyjście");
                Console.Write("Wybierz kształt do obliczenia:");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Rectangle rect = new Rectangle();
                        Console.Write("Podaj szerokość:");
                        float rectWith = float.Parse(Console.ReadLine());
                        Console.Write("Podaj wysokość:");
                        float rectHeight = float.Parse(Console.ReadLine());
                        rect.SetDimension(rectWith, rectHeight);
                        Console.WriteLine("Powierzchnia prostokąta: {0}", rect.CalculateArea());
                        Console.WriteLine("Obwód prostokąta: {0}", rect.CalculatePerimeter());
                        break;
                    case 2:
                        float circRadius = GetValidInput("Podaj promień:");
                        Circle circ = new Circle(circRadius);
                        Console.WriteLine("Powierzchnia koła: {0}", circ.CalculateArea());
                        Console.WriteLine("Obwód koła: {0}", circ.CalculatePerimeter());
                        break;
                    case 3:
                        float sideA, sideB, sideC;
                        do
                        {
                            sideA = GetValidInput("Podaj dlugosc boku A: ");
                            sideB = GetValidInput("Podaj dlugosc boku B: ");
                            sideC = GetValidInput("Podaj dlugosc boku C: ");
                            if(IsValidTriangle(sideA, sideB, sideC))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nNieprawidlowe dane. Sproboj ponownie.\n");
                                Console.ResetColor();
                            }
                        }
                        while (!IsValidTriangle(sideA, sideB, sideC));
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                        break;

                }
            }
        }

        private static bool IsValidTriangle(float sideA, float sideB, float sideC)
        {
            return (sideA + sideB > sideC) && (sideC + sideA > sideB) && (sideB + sideC > sideA);
        }

        private static float GetValidInput(string prompt)
        {
            float result;
            while (true)
            {
                Console.Write(prompt);
                if (float.TryParse(Console.ReadLine(), out result) && result > 0)
                {
                    return result;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nieprawidłowe dane. Spróbuj ponownie.");
                    Console.ResetColor();
                }
            }
        }
    }
}

