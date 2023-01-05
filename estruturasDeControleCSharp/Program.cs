using System;

namespace estruturasDeControleCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int b, a;
            a = 5;

            if(a >= 5)
            {
                b = 10;
            }
            else
            {
                b = 6;
            }
            System.Console.WriteLine(b);

            while(a != 0)
            {
                a--;
                System.Console.WriteLine(a);
            }

            for(int i = 0; i < b; i++ )
            {
                System.Console.WriteLine(i);
            }

        }
    }
}
