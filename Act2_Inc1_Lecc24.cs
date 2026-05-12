internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese número base: ");
        int num = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine(num * i); 
        }
    }
}