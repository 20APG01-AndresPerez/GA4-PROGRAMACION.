internal class Program
{
    private static void Main(string[] args)
    {
        int cont = 0, suma = 0;
        for (int n = 2; n <= 100; n++)
        {
            int divisores = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0) divisores++;
            }
            if (divisores == 2)
            {
                cont++;
                suma += n;
            }
        }
        Console.WriteLine("Cantidad: " + cont + " Suma: " + suma);
    }
}