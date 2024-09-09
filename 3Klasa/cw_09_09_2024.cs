using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
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
        public class  Rectangle : Shape
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
				return width * height;
			}
			public override float CalculatePerimeter()
			{
				return 2 * (height + width);
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
				return (float)(2 * Math.PI * radius);
			}
		}
        static void Main(string[] args)
		{
			while(true)
			{
				Console.WriteLine("1. Prostokąt");
				Console.WriteLine("2. Koło");
				Console.WriteLine("3. Trójkąt");
				Console.WriteLine("4. Trapez");
				Console.WriteLine("5. Kula");
				Console.WriteLine("6. Wyjście");
				Console.Write("Wybiarz kształt do obliczenia: ");
				int choice = int.Parse(Console.ReadLine());
				switch (choice)
				{
					case 1:
						Rectangle rect = new Rectangle();
						Console.Write("Podaj szerokosc: ");
						float RectWidth = float.Parse(Console.ReadLine());
						Console.WriteLine();
						Console.Write("Podaj wysokość: ");
						float rectHight = float.Parse(Console.ReadLine());
						rect.SetDimension(RectWidth, rectHight);
						Console.WriteLine("Powierzchnia prostokąta {0}", rect.CalculateArea());
						Console.WriteLine("Obwód prostokąta {0}", rect.CalculatePerimeter());
						Console.ReadKey();
						Console.Clear();
						break;
					case 2:
						float cricRadius = GetValidInput("Podaj promien: ");
						Circle circ = new Circle(circRadius);
						Console.WriteLine("Powierzchnia kola {0}", circ.CalculateArea());
						Console.WriteLine("Obwód kola {0}", circ.CalculatePerimeter());
						Console.ReadKey();
						Console.Clear();
						break;
					case 3:
						break;
					case 4:
						break;
					case 5:
						break;
					case 6:
						return;
					default:
						Console.WriteLine("Nieprawidłowy wybór spróboj ponownie.");
						break;
				}
			}
		}
		private static float GetValidInput(string prompt)
		{
			float result;
			while (true)
			{
				Console.Write(prompt);
				if (float.TryParse(Console.ReadLine(), out result) && result>0)
				{
					return result;
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Nieprawidlowe dane");
					Console.ResetColor();
				}
			}
		}
	}
}
