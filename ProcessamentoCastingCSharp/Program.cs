using System;

namespace ProcessamentoCastingCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            double y;

            x = 5;
            y = 2 * x;
            
            System.Console.WriteLine(y); // print de um double sem casas decimais
            System.Console.WriteLine(y.ToString("F2"));

            double b1, b2, h, area;
            
            b1 = 6.0;
            b2 = 8.0; 
            h = 5.0;
            area = (b1 +b2)/ 2 * h; 
            System.Console.WriteLine(area.ToString("F2"));

            int a, b;
            double resultado;
            a = 5;
            b = 2;
            resultado = a / b;
            
            System.Console.WriteLine(resultado); // vai imprimir a parte inteira da divisao
            
            resultado = (double)a / b; //imprime o resultado da divisao real

            System.Console.WriteLine(resultado);

            double c;
            int d;

            c = 2.5;
            d = (int)c; // despreza a parte decimal e recebe a inteira

            System.Console.WriteLine(c);
            System.Console.WriteLine(d);

        }
    }
}
