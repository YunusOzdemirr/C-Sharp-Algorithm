using System;
using System;
using System.Threading;

namespace Algorithm.Algorithms
{
    public static class DayAlgorithm
    {
        public static bool Stop = false;


        public static void Day()
        {

            int gun = 0, hafta = 0, ay = 0, yıl = 0;
            string sonuc = "";

            for (int i = 0; i > -1; i++)
            {
                //string line = Console.ReadLine();
                //if (string.IsNullOrEmpty(line))
                //    gun++;
                if (Stop == true)
                {
                    Console.Clear();
                    sonuc = "Gün :" + gun + "\nHafta :" + hafta + "\nAy :" + ay + "\nYıl :" + yıl;
                    Console.WriteLine("Gün :{0} Hafta :{1} Ay :{2} Yıl :{3}", gun, hafta, ay, yıl);
                    break;
                }
                gun++;
                if (gun % 7 == 0)
                {
                    hafta++;
                }
                if (gun % 30 == 0)
                {
                    ay++;
                }
                if (gun % 365 == 0)
                {
                    yıl++;
                }
                Thread th = new Thread(isStoped); th.Start();
                Console.WriteLine("GGün :{0} Hafta :{1} Ay :{2} Yıl :{3}", gun, hafta, ay, yıl);
            }
        }
        private static void isStoped()
        {
            var text = Console.ReadLine();
            if (text == "stop") ;
            Stop = true;
        }
    }
}