using System;
using System.Text;

namespace Algorithm.Algorithms
{
    public static class SplitAlgorithm
    {
        public static void Split()
        {
            #region Split
            string text = "Hello World!" +
               "Selam ke" +

               "nabersin ke" +

               "deneme ke";

            string[] textSplit = text.Split("\n");
            // string[] textSplit = text.Split(" ");
            Console.WriteLine(textSplit);
            Console.WriteLine(text.Split(","));
            Console.WriteLine(String.Join(Environment.NewLine, textSplit));
            // Console.WriteLine(Encoding.Default.GetString(textSplit));
            // Console.WriteLine(Encoding.UTF8.GetString(textSplit));
            foreach (var item in textSplit)
            {
                Console.WriteLine(item);
            }

            char[] delims = new[] { '\r', '\n' };

            // string message = @"*SCOR,OM,861522046166469,L1,0,0,1623230143,0#";
            // string[] words = message.Split(delims, StringSplitOptions.TrimEntries);



            // char[] delims = new[] { '\r', '\n' };
            // string[] strings = message.Split(delims, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine(String.Join(',', strings));

            //string[] stringg = message.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            // Console.WriteLine(String.Join(',', stringg));

            string[] words = text.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words)
            {
                Console.Write($"{word},");
            }
            Console.WriteLine(String.Join(',', words));
            // string[] stringg = text.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            // Console.WriteLine(String.Join(',', words));

            #endregion
        }
    }
}