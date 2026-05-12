internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese un número: ");
        int n = int.Parse(Console.ReadLine());

        int i = 1; 

        while (i <= 10) 
        {
            Console.WriteLine(n + " x " + i + " = " + (n * i));

            i++; // 3. Incremento (¡Importante para evitar un ciclo infinito!)
        }
    }
}