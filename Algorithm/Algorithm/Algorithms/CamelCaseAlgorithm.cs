using System;
using System.Text;

namespace Algorithm.Algorithms
{
    public static class CamelCaseAlgorithm
    {
        public static void CamelCase()
        {
            // string liness = @"a b c d-e-f%g";
            string liness = @"cats AND*Dogs-are Awesome";
            char[] delims = new[] { '-', '_', '%', ' ', '*' };
            string[] words = liness.Split(delims, StringSplitOptions.TrimEntries);
            for (int k = 0; k < words.Length; k++)
            {
                if (k == 0)
                {
                    words[k] = words[k].ToLower();
                }
                //Console.WriteLine(words[k][0]);
                if (k != 0)
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    words[k] = stringBuilder.Append(words[k].Substring(0, 1).ToUpper()).Append(words[k].Substring(1).ToLower()).ToString();
                }
                Console.Write(words[k]);

            }
            Console.ReadLine();
        }

        public static void CamelCaseBruteForce()
        {
            // string liness = @"a b c d-e-f%g";
            string liness = @"cats AND*Dogs-are Awesome";
            char[] delims = new[] { '-', '_', '%', ' ', '*' };
            string[] words = liness.Split(delims, StringSplitOptions.TrimEntries);
            for (int k = 0; k < words.Length; k++)
            {
                char[] charArray = words[k].ToCharArray();
                //charArray[0] = Char.ToUpper(charArray[0]);
                //for (int i = 1; i < charArray.Length; i++)
                //{
                //    charArray[i] = Char.ToLower(charArray[i]);
                //    //words[k][i] = words[k][i].ToString().ToLower();
                //}
                //words[k] = charArray[k].ToString();
                if (k == 0)
                {
                    Console.Write($"{charArray[0]}");
                    for (int i = 1; i < charArray.Length; i++)
                    {
                        Console.Write($"{charArray[i].ToString().ToLower()}");
                    }
                }
                else
                {
                    Console.Write($"{charArray[0].ToString().ToUpper()}");
                    for (int i = 1; i < charArray.Length; i++)
                    {
                        Console.Write($"{charArray[i].ToString().ToLower()}");
                    }
                }

            }



            foreach (var word in words)
            {
                words[0].Substring(0, 1);
                Console.WriteLine(words[0].Substring(0, 1));

                Console.WriteLine(word);
                // if (wordArray[0] == 'a')
                // {
                //     Console.Write($"{wordArray[0]}");
                // }
            }


            Console.ReadLine();

        }
    }
}