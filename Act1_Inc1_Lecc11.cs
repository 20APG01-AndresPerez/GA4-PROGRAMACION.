internal class Program
{
    private static void Main(string[] args)
    {
        int cupodis;


        do
        {
            Console.WriteLine("Ingrese el numero de carro de estacionamiento: ");
            cupodis = Convert.ToInt32(Console.ReadLine());
        }while (cupodis < 250);
        
        if (cupodis > 250)
        {
            Console.WriteLine("Ya no hay espacio");
        }
        else
        {
            Console.WriteLine("Espacio Disponible");
        }
        Console.WriteLine("El numero que tiene es: "+cupodis);
    }
}