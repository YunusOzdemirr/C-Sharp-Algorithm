using System.Linq;

namespace Algorithm.Algorithms;

public static class LongestWord
{
    public static string LongestWords(string sen)
    {
        string longestWord = string.Empty;
        string[] words = sen.Split(" ");
        string[] punctuations = new string[] { ",", "!", "&","/",":","[","~" };
        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];

            if (punctuations.Any(a => a.Any(b => word.Contains(b))))
            {
                for (int j = 0; j < word.Length-1; j++)
                {
                    char punctuation = word[j];
                    if (punctuations.Any(a => a.Any(b => b == punctuation)))
                    {
                        word = word.Remove(j);
                    }
                }
            }

            if (word.Length > longestWord.Length)
                longestWord = word;
        }

        return longestWord;
    }
}