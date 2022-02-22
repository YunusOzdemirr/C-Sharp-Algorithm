using System;

namespace Algorithm.Algorithms
{
    public static class TwoNumberSumAlgorithm
    {

        public static void TwoNumberSum()
        {
        TryAgainForX:
            Console.WriteLine("Bir x sayısı giriniz 1'in altında ve 1000'in üzerinde olmasın");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x.GetType() != typeof(int))
            {
                Console.WriteLine("Lütfen bir sayı giriniz.");
                goto TryAgainForX;
            }
            else if (x > 1000 || x < 0)
            {
                Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
                goto TryAgainForX;
            }

        TryAgainForY:
            Console.WriteLine("Bir y sayısı giriniz 1'in altında ve 1000'in üzerinde olmasın");
            int y = Convert.ToInt32(Console.ReadLine());

            if (y.GetType() != typeof(int))
            {

                Console.WriteLine("Lütfen bir sayı giriniz.");
                goto TryAgainForY;
            }
            else if (y > 1000 || y < 1)
            {
                Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
                goto TryAgainForY;
            }

            Console.WriteLine(x + y);

        }
    }
}
