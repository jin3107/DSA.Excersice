using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_BS3
{
    public class Sort
    {
        public void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        // Sắp xếp vun đống (Tăng dần)
        public void AdjustHeap(int[] arr, int iRoot, int iEnd)
        {
            int saved = arr[iRoot];
            int i = iRoot;
            int j = 2 * i + 1;
            while (j <= iEnd)
            {
                if ((j + 1 <= iEnd) && arr[j] < arr[j + 1])
                    j += 1;
                if (arr[j] <= saved)
                    break;
                else
                {
                    arr[i] = arr[j];
                    arr[j] = saved;
                    i = j;
                    j = 2 * i + 1;
                }
            }

            Console.WriteLine($"Hiệu chỉnh đống từ chỉ số {iRoot} đến {iEnd}:     " + string.Join(" ", arr));
        }

        public void CreateHeap(int[] arr, int n)
        {
            Console.WriteLine("\nGIAI ĐOẠN 1. TẠO ĐỐNG CHO MẢNG");
            for (int iRoot = (n / 2) - 1; iRoot >= 0; iRoot--)
                AdjustHeap(arr, iRoot, n - 1);
        }

        public void HeapSort(int[] arr, int n)
        {
            CreateHeap(arr, n);
            Console.WriteLine("\nGIAI ĐOẠN 2. LẶP: HOÁN VỊ 2 PHẦN TỬ & HIỆU CHỈNH ĐỐNG");
            int iEnd = n - 1;
            while (iEnd > 0)
            {
                Swap(ref arr[0], ref arr[iEnd]);
                Console.WriteLine($"\nHoán vị phần tử chỉ số 0 với chỉ số {iEnd}: " + string.Join(" ", arr));
                iEnd -= 1;
                AdjustHeap(arr, 0, iEnd);
            }
        }


    }
}
