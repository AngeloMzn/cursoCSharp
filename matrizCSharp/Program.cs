using System;

namespace matrizCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            
            Console.WriteLine("Digite o numero de linhas da matriz:");
            m = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o numero de colunas da matriz:");
            n = int.Parse(Console.ReadLine());
            
            int[,] mat = new int[m, n]; // a parte int[,] define que é uma matriz de 2 dimensões

            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    System.Console.WriteLine("digite o elemento " + "[" + i + "]" + "[" + j + "]:");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }
                
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    System.Console.WriteLine("elemento " + "[" + i + "]" + "[" + j + "]:" + mat[i, j]);
                }
            }
        }
    }
}
