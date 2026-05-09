internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        int i = 1;
        int factorial = 1;

        Console.WriteLine("Digite un numero: ");
        num = Convert.ToInt32(Console.ReadLine());

        do
        {
            factorial = factorial * i;
            i = i + 1;

        } while (i <= num);

        Console.WriteLine("El factorial es: " + factorial);
    }
}