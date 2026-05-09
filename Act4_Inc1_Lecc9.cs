internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        int resultado;
        int i = 1;

        Console.WriteLine("Digite un numero: ");
        num= Convert.ToInt32(Console.ReadLine());

        while (i<=10)
        {
            resultado = num * i;
            Console.WriteLine(+num+" x "+i+ " = "+ resultado );
            i = i + 1;
        }

    }
}