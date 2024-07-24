using System;

namespace TongMang1_n_KhongDeQui
{
    class Program
    {
        static int SumArray(int n)
        {
            if (n == 1)
                return 1;
            int mid = n / 2;
            int left = 0;
            int right = 0;
            for (int i = 1; i <= mid; i++)
            {
                left += i;
            }

            for (int i = mid + 1; i <= n; i++)
            {
                right += i;
            }

            return left + right;
        }

        static void Main(string[] args)
        {
            int n = 10;
            int result = SumArray(n);
            Console.WriteLine(result); 
        }
    }
}
