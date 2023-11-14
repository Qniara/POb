using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_14_11_2023
{
    internal class Program
    {
        //funkcja statyczna, która pozwala wprowadzić rozmiar tablicy i nazwę - CreateArray()
        public static int[] CreateArray(string name)
        {
            Console.WriteLine($"Podaj rozmiar {name}: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            return array;
        }
        //funkcja statyczna, która ustawia elementy tablicy SetArray()
        public static void SetArray(int[] T)
        {
            for (int i = 0; i < T.Length; i++)
            {
                Console.WriteLine("Podaj liczbe: ");
                T[i] = int.Parse(Console.ReadLine());
            }
        }
        //funkcja statyczna, która wyświetla zawartość tablicy DisplayArray()
        public static void DisplayArray(int[] T)
        {
            for (int i = 0; i < T.Length; i++)
            {
                Console.Write(T[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            int[] tabA = CreateArray("tabA");
            SetArray(tabA);
            DisplayArray(tabA);
        }
    }
}
