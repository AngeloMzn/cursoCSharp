using System;

namespace vetoresCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("digite o tamanho do vetor: ");
            n = int.Parse(Console.ReadLine());

            double[] vet = new double[n]; // criação do vetor na memoria

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine());

            }

            for(int i = 0; i < n; i++)
            {
                System.Console.WriteLine(vet[i].ToString("F2"));

            }
           




        }
    }
}
