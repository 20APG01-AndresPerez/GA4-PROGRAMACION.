internal class Program
{
    private static void Main(string[] args)
    {
        int cantPrimos = 0, sumaPares = 0;
        for (int i = 300; i >= 1; i--)
        {
            if (i % 2 == 0) sumaPares += i;
            int div = 0;
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0) div++;
            }
            if (div == 2)
            {
                cantPrimos++;
            }
        }
        Console.WriteLine("Primos: " + cantPrimos + " Suma de Pares: " + sumaPares);
    }
}