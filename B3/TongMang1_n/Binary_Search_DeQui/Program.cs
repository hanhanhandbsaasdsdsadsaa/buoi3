using System;

namespace Binary_Search_DeQui
{
    class Program
    {
        static int BinarySearch(int[] arr, int target, int left, int right)
        {
           
            if (left > right)
                return -1;

            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
                return mid;

            if (arr[mid] > target)
                return BinarySearch(arr, target, left, mid - 1);

            return BinarySearch(arr, target, mid + 1, right);
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 7, 11, 13, 15 };
            int target = 5;

            int index = BinarySearch(arr, target, 0, arr.Length - 1);

            if (index == -1)
                Console.WriteLine("Khong thay " + target + " trong mang");
            else
                Console.WriteLine(+ target + "duoc tim thay o vị trí " + index );
        }
    }
}
