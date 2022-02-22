using System;
using System.Collections.Generic;

namespace Algorithm.Algorithms
{
    public static class TeamAlgorithm
    {
        public static void TeamAlgorithmCheck()
        {
            Random random = new Random();
            List<string> Players = new List<string>();
            Console.Write("Takımsayısı : ");
            int teamCount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Takımboyutu : ");
            int teamSize = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= Convert.ToInt32(teamSize * teamCount); i++)
            {
                Console.Write(i + ". Oyuncu ismini girin :");
                string oyuncu = Console.ReadLine();
                Players.Add(oyuncu);
            }
            for (int sayi = 1; sayi <= teamCount; sayi++)
            {
                Console.Write(sayi + ". Takım = ");
                for (int boyut = 1; boyut <= teamSize; boyut++)
                {
                    int seç = random.Next(Players.Count);
                    Console.Write(Players[seç]);
                    if (boyut != teamSize)
                        Console.Write(", ");
                    Players.Remove(Players[seç]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}