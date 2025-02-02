using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Algorithm.Algorithms
{
    public static class Alphabet
    {
        static string[] alfabe = { "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "İ", "I", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z" };
        public static void AlphabetCheck()
        {
            var timer = new Stopwatch();
            timer.Start();
            List<string> değerler = new List<string>();
            int konsoltemizlesayac = 0;
            for (int harf = 0; alfabe.Length > harf; harf++)
            {
                değerler.Add(alfabe[harf]);
                // Console.WriteLine(alfabe[harf]);
            }
            for (int a = 1; a < 1000; a++)
            {
                for (int b = 1; b < a; b++)
                {
                    List<string> yenidegerler = new List<string>();
                    foreach (string değer in değerler)
                    {
                        for (int harf = 0; alfabe.Length > harf; harf++)
                        {
                            string sonuç = değer + alfabe[harf];
                            yenidegerler.Add(sonuç);
                            if (sonuç == "DZAAAA")
                            {
                                timer.Stop();
                                Console.WriteLine(timer.Elapsed);
                                break;
                            }
                            konsoltemizlesayac++;
                            if (konsoltemizlesayac >= 99999)
                            {
                                //Console.Clear();
                                konsoltemizlesayac = 0;
                            }
                        }
                    }
                    değerler = yenidegerler;
                }
            }
        }
    }
}