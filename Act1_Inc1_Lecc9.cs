internal class Program
{
    private static void Main(string[] args)
    {
        int pesotot, pesoman, cantman;
        pesotot = 0;
        pesoman = 0;
        cantman = 0;
        while (pesotot<1000)
        {
            Console.WriteLine("Digite el peso de las manzanas: ");
            pesoman= Convert.ToInt32(Console.ReadLine());

            pesotot = pesotot + pesoman;
            cantman++;

            Console.WriteLine("El peso que llevas es: "+pesotot+" y la cantidad que llevas es: "+cantman);
        }
        Console.WriteLine("Llegaste al limite de peso");
        Console.WriteLine("En total te llevaste "+cantman+" manzanas");
    }
}