using System;

namespace Algorithm.Algorithms
{
    public static class RefOutAlgorithm
    {
        public static void Ref()
        {

            //ref olmadan

            int originalValue = 43;

            Console.WriteLine("ChangeMethod'dan önce: " + originalValue);//Output 43

            ChangeMethod(1, 3, originalValue);

            Console.WriteLine("ChangeMethod'dan sonra: " + originalValue); //Output 43

            static void ChangeMethod(int x, int y, int i)
            {
                i = i + x + y;//43
            }

            // ref ile
            int originalValueWithRef = 43;

            Console.WriteLine("ChangeMethod'dan önce: " + originalValueWithRef);//Output 43


            ChangeMethodWithRef(1, 3, ref originalValueWithRef);

            Console.WriteLine("ChangeMethod'dan sonra: " + originalValueWithRef); //Output 47

            static void ChangeMethodWithRef(int x, int y, ref int i)
            {
                i = i + x + y;//47
            }

            //çıktı ise şöyle oluyor
            //ChangeMethod'dan önce: 43
            //ChangeMethod'dan sonra: 43
            //ChangeMethod'dan önce: 43
            //ChangeMethod'dan sonra: 47
        }
    }
}