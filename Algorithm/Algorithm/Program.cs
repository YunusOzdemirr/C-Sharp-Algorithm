using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Algorithm
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region algoritma 1
            //List<char> chars = new List<char> { A, B, C, Ç, D, E, F, G, Ğ, H, İ, I, J, K, L, M, N, O, Ö, P, R, S, Ş, T, U, Ü, V, Y, Z };
            //, D = 132, E = 621, F = 901, G = 762, H = 123, I = 192, J = 382, K = 864, L = 875, M = 653, N = 520, O = 981, P = 766, R = 123, S = 991, T = 556, U = 412, V = 767, Y = 121, Z = 732 };
            #region version1
            //Console.Write("İsminizi yazınız : ");
            //string name = Console.ReadLine().ToUpper();
            //Dictionary<string, int> disc = new Dictionary<string, int>();
            //disc.Add("A", 125);
            //disc.Add("B", 354);
            //disc.Add("C", 464);
            //disc.Add("D", 123);
            //disc.Add("E", 435);
            //disc.Add("F", 453);
            //disc.Add("G", 542);
            //disc.Add("H", 790);
            //disc.Add("I", 451);
            //disc.Add("İ", 234);
            //disc.Add("J", 158);
            //disc.Add("K", 875);
            //disc.Add("L", 567);
            //disc.Add("M", 167);
            //disc.Add("N", 531);
            //disc.Add("O", 421);
            //disc.Add("Ö", 976);
            //disc.Add("P", 170);
            //disc.Add("R", 658);
            //disc.Add("S", 710);
            //disc.Add("Ş", 624);
            //disc.Add("T", 814);
            //disc.Add("U", 106);
            //disc.Add("Ü", 528);
            //disc.Add("V", 952);
            //disc.Add("Y", 733);
            //disc.Add("Z", 273);
            //string value = "";
            //for (int i = 0; i < name.Length; i++)
            //{
            //    foreach (var item in disc)
            //    {
            //        if (item.Key == name[i].ToString())
            //        {
            //            value += item.Value.ToString();
            //        }
            //    }
            //}



            //string letter = " ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ";

            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name.Length);
            //    for (int j = 0; j < letter.Length; j++)
            //    {
            //        if (name[i] == letter[j])
            //        {
            //            Console.Write(120 + j*2);
            //        }
            //    }
            //}
            #region deneme foreach
            //foreach (var item in disc)
            //{
            //    foreach (var harf in name)
            //    {
            //        if (item.Key == harf.ToString())
            //        {
            //            Console.WriteLine(item.Key == Convert.ToString(harf.ToString()));
            //            value += item.Value;
            //            Console.WriteLine(value);

            //        }
            //    }
            //}
            #endregion
            #endregion
            //Console.WriteLine(value);
            #region MyRegion
            //string letter = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ";

            //for (int i = 0; i < name.Length; i++)
            //{
            //    for (int j = 0; j < letter.Length; j++)
            //    {
            //        if (name[i] == letter[j])
            //        {
            //            Console.Write(120 + j);
            //        }
            //    }
            //}
            //for (int i = 0; i < name.Length; i++)
            //{
            //    if (letter[i] == name[i])
            //    {
            //        Console.WriteLine();
            //    }
            //}
            #endregion
            #region version2
            //Console.Write("İsminizi yazınız : ");
            //string name2 = Console.ReadLine().ToUpper();
            //#region MyRegion
            //Dictionary<string, int> disc2 = new Dictionary<string, int>();
            //disc.Add("A", 125);
            //disc.Add("B", 354);
            //disc.Add("C", 464);
            //disc.Add("D", 123);
            //disc.Add("E", 435);
            //disc.Add("F", 453);
            //disc.Add("G", 542);
            //disc.Add("H", 790);
            //disc.Add("I", 451);
            //disc.Add("İ", 234);
            //disc.Add("J", 158);
            //disc.Add("K", 875);
            //disc.Add("L", 567);
            //disc.Add("M", 167);
            //disc.Add("N", 531);
            //disc.Add("O", 421);
            //disc.Add("Ö", 976);
            //disc.Add("P", 170);
            //disc.Add("R", 658);
            //disc.Add("S", 710);
            //disc.Add("Ş", 624);
            //disc.Add("T", 814);
            //disc.Add("U", 106);
            //disc.Add("Ü", 528);
            //disc.Add("V", 952);
            //disc.Add("Y", 733);
            //disc.Add("Z", 273);
            //#endregion
            //int value2 = 0;
            //foreach (var item in disc)
            //{
            //    foreach (var harf in name)
            //    {
            //        if (item.Key == harf.ToString())
            //        {
            //            Console.WriteLine(item.Key);
            //            value2 += item.Value;
            //            Console.WriteLine(value);
            //            value2 = 0;
            //        }
            //    }
            //}
            //Console.ReadLine();

            #endregion

            #endregion

            #region algoritma2
            //int sayac = 0;
            //int sayac2 = 0;
            //string[] array = new string[29] { "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "İ", "I", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z" };

            //for (int k = 0; k < array.Length; k++)
            //{
            //    sayac++;
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        sayac2++;
            //        for (int j = 0; j < array.Length; j++)
            //        {
            //            if (array.Length != array.Length)
            //            {
            //                Console.WriteLine(array[sayac] + array[sayac2] + array[j]);
            //            }
            //        }
            //    }
            //}

            //int hafıza = 1;
            //string[] harfler = { "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "İ", "I", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z" };
            //int[] sayilar = new int[hafıza];
            //int hatırla = 0;
            //for (; ; )
            //{
            //    for (int b = sayilar.Length - 1; b <= 0; b--)
            //    {
            //        if (hatırla == 1)
            //        {
            //            hatırla = 0;
            //            sayilar[b] += 1;
            //            break;
            //        }
            //        if (sayilar[0] == 29)
            //        {
            //            hafıza++;
            //            sayilar = new int[hafıza];
            //            break;
            //        }
            //        if (sayilar[b] == 29)
            //        {
            //            hatırla = 1;
            //            sayilar[b] = 0;
            //        }
            //    }
            //    for (int c = 0; c < sayilar.Length; c++)
            //    {
            //        Console.Write(harfler[c]);
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region algoritma 3
            //int sayi2=0;
            //Console.WriteLine("Bir sayı giriniz");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i <= sayi1; i++)
            //{
            //    sayi2 += i;
            //}
            //Console.WriteLine(sayi2);
            #endregion

            #region algoritma4
            //string[] alfabe = { "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "İ", "I", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z" };
            //List<string> değerler = new List<string>();
            //int konsoltemizlesayac = 0;
            //for (int harf = 0; alfabe.Length > harf; harf++)
            //{
            //    değerler.Add(alfabe[harf]);
            //    Console.WriteLine(alfabe[harf]);
            //}
            //for (int a = 1; ; a++)
            //{
            //    for (int b = 1; b < a; b++)
            //    {
            //        List<string> yenidegerler = new List<string>();
            //        foreach (string değer in değerler)
            //        {
            //            for (int harf = 0; alfabe.Length > harf; harf++)
            //            {
            //                string sonuç = değer + alfabe[harf];
            //                yenidegerler.Add(sonuç);
            //                Console.WriteLine(sonuç);
            //                konsoltemizlesayac++;
            //                if (konsoltemizlesayac >= 99999)
            //                {
            //                    Console.Clear();
            //                    konsoltemizlesayac = 0;
            //                }
            //            }
            //        }
            //        değerler = yenidegerler;
            //    }
            //}
            #endregion

            #region algoritma5
            //Random rastgele = new Random();
            //List<string> Oyuncular = new List<string>();
            //Console.Write("Takımsayısı : ");
            //int takımsayısı = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Takımboyutu : ");
            //int takımboyutu = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= Convert.ToInt32(takımsayısı * takımboyutu); i++)
            //{
            //    Console.Write(i + ". Oyuncu ismini girin :");
            //    string oyuncu = Console.ReadLine();
            //    Oyuncular.Add(oyuncu);
            //}
            //for (int sayı = 1; sayı <= takımsayısı; sayı++)
            //{
            //    Console.Write(sayı + ". Takım = ");
            //    for (int boyut = 1; boyut <= takımboyutu; boyut++)
            //    {
            //        int seç = rastgele.Next(Oyuncular.Count);
            //        Console.Write(Oyuncular[seç]);
            //        if (boyut != takımboyutu)
            //            Console.Write(", ");
            //        Oyuncular.Remove(Oyuncular[seç]);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();
            #endregion

            #region algoritma 6
            //Random random = new Random();
            //List<int> karakterler = new List<int>();
            //Console.Write("Takımsayısı : ");
            //int ekipSayisi = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Takımboyutu : ");
            //int ekipBoyutu = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < Convert.ToInt32(ekipSayisi * ekipBoyutu); i++)
            //{
            //tekrarla:
            //    var karakter = random.Next(ekipBoyutu * ekipSayisi);
            //    if (karakterler.Contains(karakter))
            //    {
            //        Console.WriteLine("Bu sayi zaten mevcut");
            //        goto tekrarla;
            //    }
            //    else
            //    {
            //        karakterler.Add(karakter);
            //    }
            //}
            //for (int j = 0; j < ekipSayisi; j++)
            //{
            //    Console.Write(j + ". Ekip = ");
            //    for (int k = 0; k < ekipBoyutu; k++)
            //    {
            //        int sonuc = random.Next(karakterler.Count);
            //        Console.Write(karakterler[sonuc] + ", ");
            //        karakterler.Remove(karakterler[sonuc]);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();
            #endregion

            #region Encoding Decoding
            //string key = Console.ReadLine();
            //byte[] utf8Bytes = Encoding.UTF8.GetBytes(key);
            //foreach (var item in utf8Bytes)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("------------------------");
            //string message = Encoding.UTF8.GetString(utf8Bytes);
            //Console.WriteLine(Encoding.Default.GetString(utf8Bytes));
            //foreach (var item in message)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine();
            ////byte[] win1252Bytes = Encoding.Convert(Encoding.UTF8, Encoding.GetEncoding("Windows-1252"), utf8Bytes);
            ////string sConvertedString = Encoding.UTF8.GetString(win1252Bytes);
            ////Console.WriteLine(sConvertedString);
            //Console.WriteLine("Incoming: " + message);
            //Console.Read();

            //UTF8Encoding utf8 = new UTF8Encoding();
            //String unicodeString = "masavÃ¤g";
            //// Encode the string.
            //Byte[] encodedBytes = utf8.GetBytes(unicodeString);
            //// Decode bytes back to string.
            //String decodedString = utf8.GetString(encodedBytes);
            //Console.WriteLine(decodedString);
            //Console.ReadLine();
            //var text = "/Users/yunus/Projects/Algorithm/";
            //Encode(text);
            //Decode(text);
            //static void Encode(string path)
            //{
            //    byte[] bytes;
            //    using (var sr = new StreamReader(path))
            //    {
            //        var text = sr.ReadToEnd();
            //        bytes = Encoding.UTF8.GetBytes(text);
            //    }
            //    using (var sw = new StreamWriter(path))
            //    {
            //        foreach (byte b in bytes)
            //        {
            //            sw.WriteLine(b);
            //        }
            //    }
            //}
            //static void Decode(string path)
            //{
            //    var data = new List<byte>();
            //    using (var sr = new StreamReader(path))
            //    {
            //        string line;
            //        while ((line = sr.ReadLine()) != null)
            //            data.Add(Byte.Parse(line));
            //    }
            //    using (var sw = new StreamWriter(path))
            //    {
            //        sw.Write(Encoding.UTF8.GetString(data.ToArray()));
            //    }
            //}
            #endregion

            #region Split
            //string text = "Hello World!" +
            //    "Selam ke" +

            //    "nabersin ke" +

            //    "deneme ke";

            //string[] textSplit = text.Split("\n");
            //Console.WriteLine(textSplit);
            ////Console.WriteLine(text.Split(","));
            ////Console.WriteLine(String.Join(Environment.NewLine, textSplit));
            ////Console.WriteLine(Encoding.Default.GetString(textSplit));
            ////Console.WriteLine(Encoding.UTF8.GetString(textSplit));
            //foreach (var item in textSplit)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine();

            //if len(messageArray) > 4 and messageArray[0] == "*SCOR" and messageArray[1] == "ID":
            //                        imei = messageArray[2]
            //                        inst = messageArray[3]
            //                        oper = messageArray[4]
            //            string lines = @"Split
            //This
            //String";

            //bu satırda aynı işlevi görüyor
            // char[] delims = new[] { '\r', '\n' };
            //string[] words = liness.Split(delims, StringSplitOptions.TrimEntries);

            string liness = @"Incoming: POST /?Key=Split%0AThis%0AString%22 HTTP/1.1
User-Agent: PostmanRuntime/7.28.2
Accept: */*
Postman-Token: b349fea9-ead3-4d38-ba20-de1c94a9da6b
Host: ec2-54-93-235-248.eu-central-1.compute.amazonaws.com:9680
Accept-Encoding: gzip, deflate, br
Connection: keep-alive
Content-Length: 0";


            
            string[] words = liness.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words)
            {
                Console.WriteLine($"{word},");
            }

            Console.ReadLine();
            #endregion

        }
    }
}

