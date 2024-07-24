using System;

namespace Quick_Sort_DeQui
{
    class Program
    {
        static void QuickSortRecursive(int[] arr, int low, int high)
        {
            if (low < high)
            {
                // Chọn một phần tử làm điểm chia
                int pivot = Partition(arr, low, high);

                // Sắp xếp các phần tử ở bên trái pivot
                QuickSortRecursive(arr, low, pivot - 1);

                // Sắp xếp các phần tử ở bên phải pivot
                QuickSortRecursive(arr, pivot + 1, high);
            }
        }

        static int Partition(int[] arr, int low, int high)
        {
            // Chọn phần tử cuối cùng làm pivot
            int pivot = arr[high];

            // Phần tử đánh dấu vị trí của pivot
            int i = (low - 1);

            for (int j = low; j < high; j++)
            {
                // Nếu phần tử hiện tại nhỏ hơn pivot
                if (arr[j] < pivot)
                {
                    // Tăng vị trí của phần tử đánh dấu
                    i++;

                    // Hoán đổi phần tử hiện tại với phần tử đánh dấu
                    Swap(arr, i, j);
                }
            }

            // Hoán đổi phần tử đánh dấu với pivot
            Swap(arr, i + 1, high);

            // Trả về vị trí của pivot
            return i + 1;
        }

        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        static void Main(string[] args)
        {
            int[] arr = { 5, 2, 4, 1, 3,7 };
            int n = arr.Length;

            QuickSortRecursive(arr, 0, n - 1);

            Console.WriteLine("Mang sau khi sap xep:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
