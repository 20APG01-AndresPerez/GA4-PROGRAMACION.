internal class Program
{
    private static void Main(string[] args)
    {
        int num1;
        int num2;
        int menor;
        int mayor;
        int i;
        int suma;

        Console.WriteLine("Digite el primer numero entero: ");
        num1= Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite el segundo numero entero: ");
        num2= Convert.ToInt32(Console.ReadLine());

        if (num1 < num2)
        {
            menor = num1;
            mayor = num2;
        }
        else
        {
            mayor = num1;
            menor = num2;
        }

        i = menor;
        suma = 0;

        do
        {
            suma = suma + i;
            i = i + 1;
        }while (i <= mayor);

        Console.WriteLine("La suma de los dos numeros enteros es: "+suma);
    }
}