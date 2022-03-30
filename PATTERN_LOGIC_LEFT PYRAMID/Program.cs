using System;

namespace PATTERN_LOGIC_LEFT_PYRAMID
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=5; i++)
            {
                for (int j = 1; j<=i; j++)
                    Console.Write(j);
                Console.WriteLine();


            }
            for (int l = 6; l >= 1; l--)
            {
                for (int k = 1; k <= l; k++)
                    Console.Write(k);
                Console.WriteLine();



            }
           
            
            Console.WriteLine();




        }
    }
}
