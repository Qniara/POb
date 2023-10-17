namespace cw_17._10._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            if (double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("")
            }
        }
    }
}
