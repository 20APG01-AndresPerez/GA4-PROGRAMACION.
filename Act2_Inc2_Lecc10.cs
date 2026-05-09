internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        int i = 2;

        Console.WriteLine("Digite un numero: ");
        num= Convert.ToInt32(Console.ReadLine());

        for (i =2;i <= num; i = i + 2)
        {
            Console.WriteLine(i);
        }
    }
}