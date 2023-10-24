using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defekacja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TRY CATCH
            try
            {
                Console.WriteLine("Podaj dwie liczby\n");
                Console.WriteLine("Podaj a: ");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj y:");
                double y = double.Parse(Console.ReadLine());
                Console.WriteLine($"{x}/{y}={x / y:F3}");
            }catch(Exception ex)
            {
                Console.WriteLine($"Blad: {ex.Message}");
            }
        }
    }
}
