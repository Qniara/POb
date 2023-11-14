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
        static int CreateArray()
        {
            Console.WriteLine("Podaj rozmiar: ");
            int size = int.Parse(Console.ReadLine());
            return size;
        }
        //funkcja statyczna, która ustawia elementy tablicy SetArray()
        static void SetArray(int[] T)
        {
            int size = T.Length;
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Podaj liczbe: ");
                int x = int.Parse(Console.ReadLine());
                T[i] = x;
            }
        }
        //funkcja statyczna, która wyświetla zawartość tablicy DisplayArray()
        static void DisplayArray(int[] T)
        {
            for(int i=0;i < T.Length;i++)
            {
                Console.Write(T[i] + " ");
            }
        }
        static void Main(string[] args)
        {

            int[] T= new int[CreateArray()];
            SetArray(T);
            DisplayArray(T);
        }
    }
}
