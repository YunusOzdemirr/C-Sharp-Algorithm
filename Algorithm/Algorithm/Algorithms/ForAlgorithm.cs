using System;

namespace Algorithm.Algorithms
{
    public static class ForAlgorithm
    {
        public static void For()
        {
            // see https://aka.ms/new-console-template for more information
            string a = "#";
            for (int i = 0; i <= 6; i++)
            {
                Console.WriteLine(a);
                if (i == 6)
                {
                    for (int j = 5; j > i; j--)
                    {
                        Console.Write(a);
                    }
                }
            }
            Console.Read();

            int k = 1;
            for (int i = 1; i <= 7; i++)
            {

                for (int j = 0; j < k; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                if (i <= 3)
                    k++;
                else
                    k--;
            }
            Console.ReadKey();
        }
    }
}