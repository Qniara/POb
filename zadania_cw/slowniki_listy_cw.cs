using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace szyper_sloniki_cw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, int> boki = new Dictionary<int, int>();
            //List<int> pola = new List<int>();
            //Random r = new Random();
            //for (int i = 0; i < 5; i++)
            //{
            //    boki.Add(r.Next(1, 10), r.Next(1, 10));
            //}
            //foreach (KeyValuePair<int, int> item in boki)
            //{
            //    pola.Add(item.Key * item.Value);
            //}
            //foreach (KeyValuePair<int, int> j in boki)
            //{
            //    Console.WriteLine(j.Key + " " + j.Value);
            //}
            //foreach (int i in pola)
            //{
            //    Console.WriteLine(i + " ");
            //}

            Dictionary<int, int> boki = new Dictionary<int, int>();
            List<int> pola = new List<int>();
            Random r = new Random();
            int[,] Wyniki = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                boki.Add(r.Next(1, 10), r.Next(1, 10));
            }
            int x = 0;
            int y = 0;
            foreach (KeyValuePair<int, int> i in boki)
            {
                pola.Add(i.Key * i.Value);

                if (y == 0)
                {
                    Wyniki[x, y] = i.Key;
                }
                if (y == 1)
                {
                    Wyniki[x, y] = i.Value;
                }
                if (y == 2)
                {
                    Wyniki[x, y] = pola[x];
                    x++;
                }

                y++;

                if (y > 2)
                {
                    y = 0;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(Wyniki[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
