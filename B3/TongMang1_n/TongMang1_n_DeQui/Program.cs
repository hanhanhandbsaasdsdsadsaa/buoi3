using System;

namespace TongMang1_n_DeQui
{
    class Program
    {
        static int SumArrayRecursive(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            return n + SumArrayRecursive(n - 1);
        }

        static int SumArray(int n)
        {
            return SumArrayRecursive(n);
        }

        static void Main(string[] args)
        {
            int n = 10; 

            int result = SumArray(n);
            Console.WriteLine(result);
        }
    }
}
