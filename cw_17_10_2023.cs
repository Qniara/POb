namespace cw_17._10._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double a;
            //Console.WriteLine("Podaj a: ");
            //if (double.TryParse(Console.ReadLine(), out a))
            //{
            //    Console.WriteLine(a);
            //}
            //else
            //{
            //    Console.WriteLine("Błędne dane");
            //}

            Console.WriteLine("Podaj a: ");
            double a;
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Wpisz prawidłowe dane.");
            }

        }
    }
}
