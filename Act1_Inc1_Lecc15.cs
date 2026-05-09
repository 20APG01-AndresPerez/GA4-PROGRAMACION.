internal class Program
{
    private static void Main(string[] args)
    {
        int opcion, contNi, contAdu, totNi, totAdu, totGen;

        contAdu = 0;
        contNi = 0;
        totNi = 0;
        totAdu = 0;

        do
        {
            Console.WriteLine("1. Niño");
            Console.WriteLine("2. Adulto");
            Console.WriteLine("3. Salir");

            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                contNi = contNi + 1;
                totNi = totNi + 10;
            }
            else
            {
                if (opcion == 2)
                {
                    contAdu = contAdu + 1;
                    totAdu = totAdu + 15;
                }
            }

        } while (opcion != 3);

        totGen = totNi + totAdu;

        Console.WriteLine("Cantidad de niños: " + contNi);
        Console.WriteLine("Cantidad de adultos: " + contAdu);

        Console.WriteLine("Total niños: Q" + totNi);
        Console.WriteLine("Total adultos: Q" + totAdu);

        Console.WriteLine("Total general: Q" + totGen);
    }
}