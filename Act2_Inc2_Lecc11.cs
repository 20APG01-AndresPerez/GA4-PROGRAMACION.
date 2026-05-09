internal class Program
{
    private static void Main(string[] args)
    {
        int num = 1;

        do
        {
            if (num % 2 != 0)
            {
                Console.WriteLine(num);
            }
            num++;
        }while (num <100);
     }
}