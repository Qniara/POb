using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defekacja
{
    internal class Program
    {
        static void ErrorColorChange(string command)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Blad: {command}");
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            //TRY CATCH
            bool n = false;
            while (n = true)
            {
                try
                {
                    Console.WriteLine("Podaj dwie liczby\n");
                    Console.WriteLine("Podaj a: ");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj y:");
                    int y = int.Parse(Console.ReadLine());
                    //if (y == 0)
                    //{
                    //    throw new Exception("Nie mozna dzielić przez 0.");
                    //}
                    double result = x / y;
                    Console.Write($"{x}/{y}=");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{result:F3}");
                    Console.ResetColor();
                    n = true; break;
                }
                catch (DivideByZeroException)
                {
                    ErrorColorChange("\nWolno ci dzielic przez zero!!!!!!");
                }
                catch (FormatException)
                {
                    ErrorColorChange("\nBledny format danych... :( ");
                }
                catch (OverflowException)
                {
                    ErrorColorChange("Bledny zakres liczby.\nPodana liczba jest bledna.\nWpisana liczba jest niepoprawna.\n");
                }
                catch (Exception ex)
                {
                    ErrorColorChange($"Blad: {ex.Message}");
                }
            }
        }
    }
}
