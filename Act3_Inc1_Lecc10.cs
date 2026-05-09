internal class Program
{
    private static void Main(string[] args)
    {
        int num, i, contador, suma;

        suma = 0;

        for (num = 1; num <= 22; num++)
        {
            contador = 0;

            for (i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    contador++;
                }
            }

            if (contador == 2)
            {
                suma = suma + num;
            }
        }

        Console.WriteLine("La suma de los numeros primos entre 1 y 22 es: " + suma);
    }
}