internal class Program
{
    private static void Main(string[] args)
    {
        int num1, num2, menor, mayor, i;

        Console.WriteLine("Ingrese el primer numero: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        if (num1 < num2)
        {
            menor = num1;
            mayor = num2;
        }
        else
        {
            menor = num2;
            mayor = num1;
        }
        i = menor;
        do
        {
            if (i % 4 == 0)
            {
                Console.WriteLine(i);
            }
            i++;
        } while (i <= mayor);
    }
}