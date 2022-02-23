using System;

namespace Algorithms
{
    public static class BinarySearch
    {
        public static int BinarySearchAlgorithm(int[] arr, int x)
        {
            int l = 0, r = arr.Length - 1;
            while (l <= r)
            {
                //    = 0+(4-0)/2  == 2
                //    = 3+(4-3)/2 ==3
                //    = 0+(29-0)/2==14
                int m = l + (r - l) / 2;
                int abc = (l + r) / 2;
                // m= 5+(10-5)/2
                //m=5+5/2
                //m=5+2.5
                //ortasını alıyor m değeri ortanca değer

                //x değeri ortanca değer mi kontrol et
                if (arr[m] == x)
                    return m;

                // x ortanca değerden büyükse, sol yarıyı görmezden gelir
                if (arr[m] < x)
                    l = m + 1;

                // x ortanca değerden küçükse, sağ yarıyı görmezden gelir
                else
                    r = m - 1;
            }

            // x değeri dizide bulunamadıysa -1 değerini döner
            return -1;
        }
        static void testBinary()
        {
            int[] arr = { 1, 3, 5, 7, 9, 11, 49, 56, 64, 73, 41, 51, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 31, 32, 33, 34, 35, 36 };
            int n = arr.Length;
            int x = 1;
            int result = BinarySearch.BinarySearchAlgorithm(arr, x);
            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at "
                                   + "index " + result);
        }
    }

}