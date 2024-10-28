namespace Set1Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdu valoarea lui n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introdu valoarea lui k: ");
            int k = Convert.ToInt32(Console.ReadLine());

            if( k != 0)
            {
                if (n%k == 0)
                {
                    Console.WriteLine($"Numarul {n} este dibizibil cu {k}");
                }
                else
                {
                    Console.WriteLine($"Numarul {n} nu este divizibil cu {k}");
                }
            }
            else
            {
                Console.WriteLine("Impartirea la 0 nu este posibila");
            }
        }
    }
}
