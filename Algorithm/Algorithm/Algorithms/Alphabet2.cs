using System;
using System.Diagnostics;
using System.Linq;

namespace Algorithm.Algorithms;

public static class Alphabet2
{
    static string[] alphabet = { "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "İ", "I", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z" };
    public static void Run()
    {
        var timer = new Stopwatch();
        timer.Start();
        var value = alphabet.First();
        for (int i = 0; ; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                var letter = alphabet[j];
                if (value.Length > 1)
                {
                    value = value.Remove(value.Length - 1);
                    value += letter;
                    //Console.WriteLine(value);
                }
                if (j == alphabet.Length - 1)
                {
                    if (value.Length == 1)
                        value = letter;
                    var newValue = Calculate(value);
                    value = newValue;
                }
                if (value.Length == 1)
                {
                    value = letter;
                    //Console.WriteLine(letter);
                }
            }
            if (value == "DZAAAA")
            {
                timer.Stop();
                Console.WriteLine(timer.Elapsed);
                break;
            }
        }

    }

    private static string Calculate(string value)
    {
        var returnArray = value.ToCharArray();
        var lastItemAlphabetLastIndex = alphabet[alphabet.Length - 1][0];
        var lastItemOnAlphabet = alphabet[alphabet.Length - 1];
        for (int i = 0; i <= value.Length - 1; i++)
        {
            var index = Array.IndexOf(alphabet, value[i].ToString());
            if (alphabet[index] == lastItemOnAlphabet)
            {
                //AAZ -> ABA
                if (value.Length == 1)
                {
                    returnArray[i] = alphabet[0][0];
                    var newValue = new string(returnArray);
                    newValue += returnArray[i];
                    return newValue;
                }
                else if (returnArray.All(a => a == lastItemAlphabetLastIndex))
                {
                    var newValue = string.Empty;
                    for (int g = 0; g <= returnArray.Length; g++)
                    {
                        newValue += alphabet[0];
                    }
                    return newValue;
                }
                else
                {
                    if (i == 0) continue;
                    var beforeIndex = returnArray[i - 1];
                    var lastIndex = Array.IndexOf(alphabet, beforeIndex.ToString());
                    if (alphabet.Length == lastIndex + 1)
                    {
                        continue;
                    }
                    var leftChars = value.Length - i - 1;
                    if (leftChars != 0)
                    {
                        var correctIndexCount = 0;

                        for (int k = 1; k <= leftChars; k++)
                        {
                            if (returnArray[i + k] == lastItemAlphabetLastIndex)
                            {
                                correctIndexCount++;
                            }
                            else
                            {
                                break;
                            }
                        }

                        if (correctIndexCount == leftChars)
                        {
                            returnArray[i - 1] = alphabet[lastIndex + 1][0];
                            for (int k = 1; k <= leftChars + 1; k++)
                            {
                                returnArray[i - 1 + k] = alphabet[0][0];
                            }
                            break;
                        }
                    }
                    else
                    {
                        //Parent Increase
                        returnArray[i - 1] = alphabet[lastIndex + 1][0];
                        //Last Item Set To First Index
                        returnArray[i] = alphabet[0][0];
                    }
                }
            }
        }
        return new string(returnArray);
    }
}
