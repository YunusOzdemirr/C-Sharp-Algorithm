using System;
using System.Collections.Generic;

namespace Algorithm.Algorithms
{
    public static class PlayersAlgorithm
    {
        public static void Algorithm()
        {
            Random random = new Random();
            List<int> players = new List<int>();
            Console.Write("Takımsayısı : ");
            int teamCount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Takımboyutu : ");
            int teamSize = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Convert.ToInt32(teamCount * teamSize); i++)
            {
            tekrarla:
                var karakter = random.Next(teamSize * teamCount);
                if (players.Contains(karakter))
                {
                    Console.WriteLine("Bu sayi zaten mevcut");
                    goto tekrarla;
                }
                else
                {
                    players.Add(karakter);
                }
            }
            for (int j = 0; j < teamCount; j++)
            {
                Console.Write(j + ". Ekip = ");
                for (int k = 0; k < teamSize; k++)
                {
                    int sonuc = random.Next(players.Count);
                    Console.Write(players[sonuc] + ", ");
                    players.Remove(players[sonuc]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}