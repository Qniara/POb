using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_19_09_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kathrine Pearce <3");
            //Console.Clear(); -> czyści ekran
            //Console.ReadKey(); -> podanie jaki klawisz ma być kliknięty aby
            //zakończyć wyświetlanie konsoli

            //TYPY DANYCH
            /*
             * int 16, 32, 64
             * byte -> zmienna liczbowa o wartości od 0 do 255
             * sbyte - > zmienna liczbowa o wartości od -128 do 127
             * short -> zmienna liczbowa o wartości od -32768 do 32767
             * int -> zmienna liczbowa o wartości od -2147483648 do 2147483647
             */

            int i = 27; //deklaracja zmiennej
            int j = 10; //deklaracja z inicjalozacją
            System.Int32 x = 10;
            Console.WriteLine("Zmienna j wynosi {0}, zmienna x wynosi {1}", j, x);
            Console.WriteLine($"Zmienna i wynosi {i}, \nzmienna j wynosi {j}");

            byte b = 27;
            sbyte sb = -10;
            short s = -27;
        }
    }
}
