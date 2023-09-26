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
             * byte -> wartości od 0 do 255 (8 bitów = 1 bajt
             * sbyte - > wartości od -128 do 127
             * short -> wartości od -32768 do 32767 (16 bitów = 2 bajty)
             * ushort -> wartości od 0 do 65535 (16 bitów = 2 bajty)
             * int -> wartości od -2147483648 do 2147483647 (32 bity = 4 bajty)
             * uint -> (64 bity = 8 bajtów)
             * long -> wartości od -9223372036854775808 do 9223372036854775807 (64 bity = 8 bajtów)
             * ulong -> wartości od 0 do 18446744073709551615 (64 bity = 8 bajtów)
             * bool -> true / false
             * char -> znaki od U+0000 do U+FFFF (16-bitowy znak z tablicy Unicode)
             * string
             * float -> wartości od -3,4*10^38 do 3,4 *10^38 (32 bity = 4 bajty)
             * double -> to samo co float ale 64 bity
             * decimal -> to samo co float ale 128 bitów
             */

            //int i = 27; //deklaracja zmiennej
            //int j = 10; //deklaracja z inicjalozacją
            //System.Int32 x = 10;
            //Console.WriteLine("Zmienna j wynosi {0}, zmienna x wynosi {1}", j, x);
            //Console.WriteLine($"Zmienna i wynosi {i}, \nzmienna j wynosi {j}");

            //byte b = 27;
            //sbyte sb = -10;
            //short s = -27;

            //int a = 10;
            //int32 b = 10;
            //System.Int32 c = 10;

            //long l = 10L;//suffix L
            //ulong ul = 10UL;//suffix UL

            //float f = 10.5F;//suffix F

            //ZAPIS SYSTEMOW LICZBOWYCH
            //Binarny
            //Console.WriteLine(0b1011); //11 [10]
            //Oktalny
            //Console.WriteLine(011); //11
            //int io = Convert.ToInt32("12", 8);
            //Console.WriteLine(io); //2*8^0+1*8^1 = 2+8 = 10 [10]
            //heksadecymalny
            //Console.WriteLine(0xA1); //A*16^1+1*16^0 = 10*16+1*1 = 161 [10]

            //ZAKRES TYPÓW DANYCH
            //Console.WriteLine(byte.MinValue);
            //Console.WriteLine(byte.MaxValue);
        }
    }
}
