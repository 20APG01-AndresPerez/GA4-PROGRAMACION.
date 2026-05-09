internal class Program
{
    private static void Main(string[] args)
    {
        int totmonedas = 0;
        int monedas= 0;

        while (totmonedas < 350)
        {
            Console.WriteLine("Ingrese las monedas que tiene: ");
            totmonedas= Convert.ToInt32(Console.ReadLine());

            totmonedas = totmonedas + monedas;

            if (totmonedas >= 350)
            {
                Console.WriteLine("Lograste avanzar al nivel 5");
            }
            else
            {
                Console.WriteLine("Monedas Insuficientes");
            }
        }
    }
}