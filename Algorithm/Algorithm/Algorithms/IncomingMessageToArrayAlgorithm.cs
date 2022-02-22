using System;

namespace Algorithm.Algorithms
{
    public static class IncomingMessageToArrayAlgorithm
    {
        //Girilen texti arraya çevirip belirlenen kelimeleri çekmesi
        public static void IncomingMessageToArray()
        {
            string value = "";
            Console.WriteLine("Texti giriniz");
            string line = Console.ReadLine();
            Console.WriteLine("Seçilecek karakterleri giriniz");
            string words = Console.ReadLine();
            for (int i = 0; i < line.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (line[i] == words[j])
                    {
                        if (!value.Contains(line[i]))
                        {
                            value += line[i];
                        }
                    }
                }
            }
            Console.WriteLine(value);
        }
    }
}