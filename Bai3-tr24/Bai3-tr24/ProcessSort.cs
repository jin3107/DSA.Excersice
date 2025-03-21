using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_tr24
{
    public class ProcessSort
    {
        public void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        // 3.1 Sắp xếp nổi bọt với cách duyệt đưa phần tử lớn nhất về cuối mảng (Duyệt Xuôi)
        public void BubbleSortAscending(int[] arr, int n)
        {
            int k = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                        Swap(ref arr[j], ref arr[j + 1]);
                }
                Console.WriteLine($"Vòng lặp {k++}: " + string.Join(", ", arr));
            }
        }

        // 3.2 Sắp xếp nổi bọt với cách duyệt đưa phần tử lớn nhất về đầu mảng (Duyệt Xuôi)
        public void BubbleSortDescending(int[] arr, int n)
        {
            int k = 1;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                        Swap(ref arr[j], ref arr[j + 1]);
                }
                Console.WriteLine($"Vòng lặp {k++}: " + string.Join(", ", arr));
            }
        }

        // 3.3 Sắp xếp chọn với cách duyệt đưa phần tử lớn nhất về cuối mảng (Duyệt Xuôi)
        public void SelectionSortAscending(int[] arr, int n)
        {
            int k = 1;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                        minIndex = j;
                }
                if (minIndex != i)
                    Swap(ref arr[minIndex], ref arr[i]);
                Console.WriteLine($"Vòng lặp {k++}: " + string.Join(", ", arr));
            }
        }

        // 3.4 Sắp xếp chọn với cách duyệt đưa phần tử lớn nhất về đầu mảng (Duyệt Xuôi)
        public void SelectionSortDescending(int[] arr, int n)
        {
            int k = 1;
            for (int i = 0; i < n - 1; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] > arr[maxIndex])
                        maxIndex = j;
                }
                Swap(ref arr[i], ref arr[maxIndex]);
                Console.WriteLine($"Vòng lặp {k++}: " + string.Join(", ", arr));
            }
        }

        // 3.5 Sắp xếp chèn với cách duyệt xem phần tử cuối mảng là dãy đã sắp xếp ban đầu (Duyệt Ngược - Tăng dần)
        public void InsertionSortFromEnd(int[] arr, int n)
        {
            int k = 1;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i + 1;
                while (j < n && arr[j] < key)
                {
                    arr[j - 1] = arr[j];
                    j++;
                }
                arr[j - 1] = key;
                Console.WriteLine($"Vòng lặp {k++}: " + string.Join(", ", arr));
            }
        }

        // 3.6 Sắp xếp chèn với cách duyệt xem phần tử đầu mảng là dãy đã sắp xếp ban đầu (Duyệt Xuôi - Tăng dần)
        public void InsertionSortFromBeginning(int[] arr, int n)
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

        // 3.7 Sắp xếp nhanh, trong đó phân hoạch dùng pp đệ quy
        public void QuickSortRecursiveAscending_DuyetXuoi(int[] arr, int left, int right)
        {
            int k = 1;
            if (left < right)
            {
                int pivot = arr[left];
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
                Console.WriteLine($"Vòng lặp {k++}: " + string.Join(", ", arr));
                QuickSortRecursiveAscending_DuyetXuoi(arr, left, j);
                QuickSortRecursiveAscending_DuyetXuoi(arr, i, right);
            }
        }

        // 3.8 Sắp xếp nhanh, trong đó phân hoạch dùng pp lặp
        public void QuickSortIterativeAscending_DuyetXuoi(int[] arr, int left, int right)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(left);
            stack.Push(right);
            int k = 1;
            while (stack.Count > 0)
            {
                right = stack.Pop();
                left = stack.Pop();
                int pivot = arr[left];
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
                Console.WriteLine($"Vòng lặp {k++}: " + string.Join(", ", arr));
                if (left < j) { stack.Push(left); stack.Push(j); }
                if (i < right) { stack.Push(i); stack.Push(right); }
            }
        }
    }
}
