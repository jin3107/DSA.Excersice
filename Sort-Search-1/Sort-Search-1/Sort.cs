using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Search_1
{
    public class Sort
    {
        public void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }


        // Sắp xếp trực tiếp (Duyệt xuôi - Tăng dần)
        public void InterchangeSort(int[] arr, int n)
        {
            int k = 1;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                        Swap(ref arr[i], ref arr[j]);
                }
                Console.WriteLine($"Vòng lặp {k++}: " + string.Join(", ", arr));
            }
        }

        // Sắp xếp nổi bọt (Duyệt xuôi - Tăng dần)
        public void BubbleSort(int[] arr ,int n)
        {
            int k = 1;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                        Swap(ref arr[j], ref arr[j + 1]);
                }
                Console.WriteLine($"Vòng lặp {k++}: " + string.Join(", ", arr));
            }
        }

        // Sắp xếp rung lắc (Duyệt ngược/xuôi - Tăng dần)
        public void ShakerSort(int[] arr, int n)
        {
            int left = 0, right = n - 1;
            int k = 0;
            int m = 1;
            while (left < right)
            {
                Console.WriteLine("\n\nLần lặp thứ: " + m);
                // Duyệt từ trái sang phải (Duyệt ngược)
                for (int j = right; j > left; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        Swap(ref arr[j], ref arr[j - 1]);
                        k = j;
                    }
                }

                left = k;
                Console.WriteLine("\nDuyệt ngược: ");
                Console.WriteLine($"{m}a: \t" + string.Join(", ", arr));
                // Duyệt từ phải sang trái (Duyệt xuôi)
                for (int i = left; i < right; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        Swap(ref arr[i], ref arr[i + 1]);
                        k = i;
                    }
                }

                right = k;
                Console.WriteLine("\nDuyệt xuôi: ");
                Console.WriteLine($"{m}b: \t" + string.Join(", ", arr));
                m++;
            }
        }

        // Sắp xếp chọn (Duyệt xuôi - Tăng dần)
        public void SelectionSort(int[] arr, int n)
        {
            int k = 1;
            for (int i = 0; i < n - 1; i++)
            {
                int imin = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[imin])
                        imin = j;
                }

                if (imin != i)
                    Swap(ref arr[i], ref arr[imin]);
                Console.WriteLine($"Vòng lặp {k++}: " + string.Join(", ", arr));
            }
        }

        // Sắp xếp chèn (Duyệt xuôi - Tăng dần)
        public void InsertionSort(int[] arr, int n)
        {
            int k = 1;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
                Console.WriteLine($"Vòng lặp {k++}: " + string.Join(", ", arr));
            }
        }

        // Sắp xếp nhanh - Đệ quy (Tăng dần)
        public void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = arr[(left + right) / 2];
                int i = left, j = right;
                while (i <= j)
                {
                    while (arr[i] < pivot) i++;
                    while (arr[j] > pivot) j--;

                    if (i <= j)
                    {
                        Swap(ref arr[i], ref arr[j]);
                        i++;
                        j--;
                    }
                }

                if (left < j)
                    QuickSort(arr, left, j);
                if (i < right)
                    QuickSort(arr, i, right);
            }
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

        public void DisplayElements(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
        }
    }
}
