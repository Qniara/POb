using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pob_cw_pupciasne
{
    internal class Program
    {
        //funkcja statyczna, która pozwala wprowadzić rozmiar tablicy i nazwę - CreateArray()
        public static int[] CreateArray()
        {
            Console.WriteLine("Podaj nazwe tablicy: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Podaj rozmiar tablicy {name}: ");
            int size = int.Parse(Console.ReadLine());
            int[] T = new int[size];
            return T;
        }
        //funkcja statyczna, która ustawia elementy tablicy SetArray()
        public static void SetArray(int[] T)
        {
            for(int i=0;i<T.Length;i++)
            {
                Console.WriteLine($"Podaj {i} element tablicy: ");
                T[i] = int.Parse(Console.ReadLine());
            }
        }
        //funkcja statyczna, która wyświetla zawartość tablicy DisplayArray()
        public static void DisplayArray(int[] T)
        {
            for(int i = 0; i < T.Length; i++)
            {
                Console.Write(T[i]+ " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //int[] T= CreateArray();
            //SetArray(T);
            //DisplayArray(T);

            //Napisz program, który pobiera od użytkownika 5 liczb całkowitych i zapisuje je w tablicy.Następnie program
            //wyświetla sumę wszystkich elementów tablicy. W celu zabezpieczenia programu przed niepoprawnymi danymi
            //wejściowymi, użyliśmy metody int.TryParse(), która pozwala na sprawdzenie, czy wprowadzona wartość jest
            //liczbą całkowitą.Jeśli użytkownik wprowadzi niepoprawną wartość, program wyświetli stosowny komunikat i
            //poprosi o ponowne wprowadzenie liczby.
            //int suma = 0;
            //int n = 0;
            //int[] T = new int[5];
            //int i = 0;
            //while(i!=5)
            //{
            //    Console.WriteLine($"Podaj {i} element tablicy: ");
            //    while (!int.TryParse(Console.ReadLine(), out n)){
            //        Console.WriteLine("Nie pyskuj bębnie tylko daj liczbe: ");
            //    }
            //    T[i] = n;
            //    suma = suma + n;
            //    i++;
            //}
            //Console.WriteLine($"Suma elementow tablicy to: " + suma);

            //Napisz program, który pobiera od użytkownika 5 liczb całkowitych i zapisuje je w tablicy, a następnie wyświetla
            //sumę wszystkich elementów tablicy.Zadeklaruj tablicę o rozmiarze 5 i nazwij ją numbers. Użyj pętli for, aby
            //pobrać od użytkownika 5 liczb całkowitych i zapisać je w tablicy numbers. Wyświetl na ekranie komunikat, który
            //prosi użytkownika o podanie kolejnej liczby całkowitej i użyj metody GetIntegerFromUser(), aby ją pobrać i
            //zweryfikować. Zdefiniuj metodę GetIntegerFromUser(), która przyjmuje od użytkownika liczbę całkowitą i zwraca
            //ją. Jeśli użytkownik wprowadzi niepoprawną wartość, metoda wyświetli stosowny komunikat i poprosi o ponowne
            //wprowadzenie liczby. Użyj metody int.TryParse(), aby sprawdzić, czy wprowadzona wartość jest poprawną liczbą
            //całkowitą i przypisać ją do zmiennej input. Zdefiniuj metodę CalculateSum(int[] numbers), która przyjmuje
            //tablicę liczb całkowitych i zwraca ich sumę. Użyj pętli foreach, aby dodać do sumy każdy element tablicy numbers
            //i zwrócić sumę. Wywołaj metodę CalculateSum(numbers) i przypisz jej wynik do zmiennej sum. Wyświetl na ekranie
            //komunikat, który pokazuje sumę podanych liczb.
            int suma = 0;
            int n = 0;
            int[] T = new int[5];
            int[] numbers = new int[5];
            int i = 0;
            while (i != 5)
            {
                Console.WriteLine($"Podaj {i} element tablicy: ");
                while (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Nie pyskuj bębnie tylko daj liczbe: ");
                }
                T[i] = n;
                suma = suma + n;
                i++;
            }
            Console.WriteLine($"Suma elementow tablicy to: " + suma);
            for (int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine($"Podaj {j} element tablicy: ");
                numbers[j] = GetIntegerFromUser();
            }
            int sum = CalculateSum(numbers);
            Console.WriteLine($"Suma elementow tablicy numbers to: {sum}.");
        }
        public static int GetIntegerFromUser()
        {
            int n = 0;
            while(!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Nie cwaniakuj tylko liczbe dawaj ");
            }
            return n;
        }
        public static int CalculateSum(int[] numbers)
        {
            int suma = 0;
            for (int i = 0; i < numbers.Length; i++) 
            {
                suma = suma + numbers[i];
            }
            return suma;
        }
    }
}
