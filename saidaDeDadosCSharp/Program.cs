using System;

namespace saidaDeDadosCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); // com quebra de linha
            Console.Write("Hello World!"); // sem quebra de linha

            System.Console.WriteLine("Bom dia !");
            System.Console.WriteLine("Boa Noite !"); 

            int x, y;
            
            x = 10;
            y = 20;
            
            System.Console.WriteLine(x);
            System.Console.WriteLine(y);       

            double z;

            z = 2.3456;

            System.Console.WriteLine(z.ToString("2F")); // formatando o double para 2 casas decimais


            int idade = 32;
            double salario = 4000.8;
            string nome = "Maria Silva";
            char sexo = 'F';

            System.Console.WriteLine("A funcionaria " + nome + ", sexo " + sexo + ", ganha " + salario.ToString("2F") + " e tem " + idade + " anos");
        }
    }
}
