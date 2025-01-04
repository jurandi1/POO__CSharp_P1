using System.Globalization;
using System.Net;
using System.Runtime.ConstrainedExecution;

internal class Program
{
    private static void Main(string[] args)
    {
//        Problema Exemplo
//        Fazer um programa para ler as medidas dos lados de dois triângulos X e Y(suponha medidas
//        válidas). Em seguida, mostrar o valor das áreas dos dois triângulos e dizer qual dos dois triângulos
//        possui a maior área.
//        Calcular a área de um triângulo a partir das medidas de seus lados a, b e c com a
//        (fórmula de Heron):
        
        Triangulo x, y;
        
        x = new Triangulo();
        y = new Triangulo();


        Console.WriteLine("Entre com as medidas do triângulo X:");
        x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Entre com as medidas do triângulo Y:");
        y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double areaX = x.Area();

        double areaY = y.Area();


        Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

        if (areaX > areaY)
        {
            Console.WriteLine("Maior área é a X");
        }
        else if (areaY == areaX)
        {
            Console.WriteLine("Áreas X e Y são iguais");
        }else
        {
            Console.WriteLine("Maior área é a Y");
        }
    }
}