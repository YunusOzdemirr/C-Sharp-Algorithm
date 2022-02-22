using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Algorithm.Algorithms
{
    public static class EncodeDecodeAlgortihm
    {
        public static void EncodeDecode()
        {
            string key = Console.ReadLine();
            byte[] utf8Bytes = Encoding.UTF8.GetBytes(key);
            foreach (var item in utf8Bytes)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------");
            string message = Encoding.UTF8.GetString(utf8Bytes);
            Console.WriteLine(Encoding.Default.GetString(utf8Bytes));
            foreach (var item in message)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            //byte[] win1252Bytes = Encoding.Convert(Encoding.UTF8, Encoding.GetEncoding("Windows-1252"), utf8Bytes);
            //string sConvertedString = Encoding.UTF8.GetString(win1252Bytes);
            //Console.WriteLine(sConvertedString);
            Console.WriteLine("Incoming: " + message);
            Console.Read();

            UTF8Encoding utf8 = new UTF8Encoding();
            String unicodeString = "masavÃ¤g";
            // Encode the string.
            Byte[] encodedBytes = utf8.GetBytes(unicodeString);
            // Decode bytes back to string.
            String decodedString = utf8.GetString(encodedBytes);
            Console.WriteLine(decodedString);
            Console.ReadLine();
            var text = "/Users/yunus/Projects/Algorithm/";
            Encode(text);
            Decode(text);
            static void Encode(string path)
            {
                byte[] bytes;
                using (var sr = new StreamReader(path))
                {
                    var text = sr.ReadToEnd();
                    bytes = Encoding.UTF8.GetBytes(text);
                }
                using (var sw = new StreamWriter(path))
                {
                    foreach (byte b in bytes)
                    {
                        sw.WriteLine(b);
                    }
                }
            }
            static void Decode(string path)
            {
                var data = new List<byte>();
                using (var sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                        data.Add(Byte.Parse(line));
                }
                using (var sw = new StreamWriter(path))
                {
                    sw.Write(Encoding.UTF8.GetString(data.ToArray()));
                }
            }
        }
    }
}