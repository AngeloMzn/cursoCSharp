using System;

namespace entradaDeDadosCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();

            /*  para ler os outros tipos

            int x = int.Parse(console.ReadLine());
            double x = double.Parse(console.ReadLine());
            char x = char.Parse(console.ReadLine());

            */

            double salario1, salario2;
            string nome1, nome2;
            int idade;
            char sexo;

            System.Console.WriteLine("digite o nome da primeira pessoa: ");
            nome1 = Console.ReadLine();
           
            System.Console.WriteLine("digite o salario da primeira pessoa: ");
            salario1 = double.Parse(Console.ReadLine());

            System.Console.WriteLine("digite o nome da segunda pessoa: ");
            nome2 = Console.ReadLine();
           
            System.Console.WriteLine("digite o salario da segunda pessoa: ");
            salario2 = double.Parse(Console.ReadLine());

            System.Console.WriteLine("digite a idade: ");
            idade = int.Parse(Console.ReadLine());

            System.Console.WriteLine("digite o sexo: ");
            sexo = char.Parse(Console.ReadLine());

            System.Console.WriteLine("Os funcionarios " + nome1 + " e " + nome2 + ", de salarios " + salario1.ToString("F2") + " e " + salario2.ToString("F2") + ", respectivamente, são do sexo " + sexo + " e tem " + idade + "anos de idade");


        
        }
    }
}
