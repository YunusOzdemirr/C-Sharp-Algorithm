using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Algorithm.Algorithms;

namespace Algorithm
{
    public class Program
    {
        static void Main(string[] args)
        {
            //5??aaaaaaaaaaaaaaaaaaa?5?5
            //mbbv???????????4??????ddsdsdcc9?
            var result = QuestionMarks.QuestionsMarks("mbbv???????????4??????ddsdsdcc9?");
            Console.WriteLine(result);
            Console.Read();
        }
    }
}