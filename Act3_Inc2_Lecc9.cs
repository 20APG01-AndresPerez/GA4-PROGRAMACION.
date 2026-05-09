internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        int i = 1;
        int contador = 0;

        Console.WriteLine("Digite un numero: ");
        num= Convert.ToInt32(Console.ReadLine());

        while (i<=num)
        {
            if (num %i == 0)
            {
                contador++; 
            }
            i = i + 1;
        }
        if (contador == 2)
        {
            Console.WriteLine("El numero es primo");
        }
        else
        {
            Console.WriteLine("El numero no es primo");
        }
    }
}