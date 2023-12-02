using System;
using System.Linq;
using Org.BouncyCastle.Asn1.Pkcs;

namespace Algorithm.Algorithms;

public class NameValidationAlgorithm
{
    //^ Operatörü : Satır başının istenilen ifadeyle başlamasını sağlar.
    /*
        + En az bir kez veya daha fazla tekrarlı kullanım
        - Aralık belirtmede kullanılır
        * Hiç olmayabilir veya birden fazla tekrarlı kullanım
        [ Karakter kümesi açma
        ] Karakter kümesi kapama
        { Tekrar sayısı kümesi açma
        } Tekrar sayısı kümesi kapama
        ^ Tersi, negatifi anlamındadır
        \ Kaçış karakteri
        ? Opsiyonel (0 veya 1 kez tekrarlı) kullanım
        . Boşluk olmayan tüm karakterler
        $ Satır sonu
     */
    public static string[] numbers = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
    public static string[] bannedChars = new string[] { "!", "$", "#", "/", "?" };

    public static string CodelandUsernameValidation(string str)
    {
        var isIncludeNumber = numbers.Any(a => a.Any(b => str.StartsWith(b)));
        var isIncludeWrongChars = bannedChars.Any(a => a.Any(b => str.Contains(b)));
        var lastCharacter = str[str.Length - 1] == '_';
        if (str.Length < 4 || str.Length > 25
                           || isIncludeNumber
                           || isIncludeWrongChars
                           || lastCharacter)
        {
            return "false";
        }

        // code goes here  
        return "true";
    }
}