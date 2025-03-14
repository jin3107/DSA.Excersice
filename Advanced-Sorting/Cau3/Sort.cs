using Cau3;
using System.Text;

namespace Cau3
{
    public class Sort
    {
        public void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        // 3.1 Sắp xếp nổi bọt với cách duyệt đưa phần tử lớn nhất về cuối mảng
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

        // 3.2 Sắp xếp nổi bọt với cách duyệt đưa phần tử lớn nhất về đầu mảng
        public void BubbleSortDescending(int[] arr, int n)
        {
            int k = 1;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = n - 1; j > i; j--)
                {
                    if (arr[j] > arr[j - 1])
                        Swap(ref arr[j], ref arr[j - 1]);
                }
                Console.WriteLine($"Vòng lặp {k++}: " + string.Join(", ", arr));
            }
        }

        // 3.3 Sắp xếp chọn với cách duyệt đưa phần tử lớn nhất về cuối mảng
        public void SelectionSortAscending(int[] arr, int n)
        {
            int k = 1;
            for (int i = n - 1; i > 0; i--)
            {
                int maxIndex = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (arr[j] > arr[maxIndex])
                        maxIndex = j;
                }
                Swap(ref arr[maxIndex], ref arr[i]);
                Console.WriteLine($"Vòng lặp {k++}: " + string.Join(", ", arr));
            }
        }

        // 3.4 Sắp xếp chọn với cách duyệt đưa phần tử lớn nhất về đầu mảng
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

        // 3.5 Sắp xếp chèn với cách duyệt xem phần tử cuối mảng là dãy đã sắp xếp ban đầu
        public void InsertionSortFromEnd(int[] arr, int n)
        {
            int k = 1;
            for (int i = n - 2; i >= 0; i--)
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

        // 3.6 Sắp xếp chèn với cách duyệt xem phần tử đầu mảng là dãy đã sắp xếp ban đầu
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

        //// 3.7 Sắp xếp nhanh, trong đó phân hoạch dùng pp đệ quy
        //private int partitionStep = 0;
        //public void QuickSortRecursive(int[] arr, int n)
        //{
        //    partitionStep = 0;
        //    QuickSortRecursiveHelper(arr, 0, n - 1);
        //}

        //private void QuickSortRecursiveHelper(int[] arr, int low, int high)
        //{
        //    if (low < high)
        //    {
        //        int pivotIndex = PartitionRecursive(arr, low, high);
        //        Console.WriteLine($"Sau khi phân hoạch lần {partitionStep}: " + string.Join(", ", arr));
        //        QuickSortRecursiveHelper(arr, low, pivotIndex - 1);
        //        QuickSortRecursiveHelper(arr, pivotIndex + 1, high);
        //    }
        //}

        //private int PartitionRecursive(int[] arr, int low, int high)
        //{
        //    partitionStep++;
        //    int pivot = arr[high];
        //    int i = (low - 1);
        //    for (int j = low; j < high; j++)
        //    {
        //        if (arr[j] <= pivot)
        //        {
        //            i++;
        //            Swap(ref arr[i], ref arr[j]);
        //        }
        //    }
        //    Swap(ref arr[i + 1], ref arr[high]);
        //    return i + 1;
        //}

        //// 3.8 Sắp xếp nhanh, trong đó phân hoạch dùng pp lặp
        //public void QuickSortIterative(int[] arr, int n)
        //{
        //    int[] stack = new int[n];
        //    int top = -1;
        //    int partitionStep = 0;
        //    stack[++top] = 0;
        //    stack[++top] = n - 1;
        //    while (top >= 0)
        //    {
        //        int high = stack[top--];
        //        int low = stack[top--];
        //        int pivotIndex = PartitionIterative(arr, low, high);
        //        partitionStep++;
        //        Console.WriteLine($"Sau khi phân hoạch lần {partitionStep}: " + string.Join(", ", arr));
        //        if (pivotIndex - 1 > low)
        //        {
        //            stack[++top] = low;
        //            stack[++top] = pivotIndex - 1;
        //        }
        //        if (pivotIndex + 1 < high)
        //        {
        //            stack[++top] = pivotIndex + 1;
        //            stack[++top] = high;
        //        }
        //    }
        //}

        //private int PartitionIterative(int[] arr, int low, int high)
        //{
        //    int pivot = arr[high];
        //    int i = (low - 1);
        //    for (int j = low; j < high; j++)
        //    {
        //        if (arr[j] <= pivot)
        //        {
        //            i++;
        //            Swap(ref arr[i], ref arr[j]);
        //        }
        //    }
        //    Swap(ref arr[i + 1], ref arr[high]);
        //    return i + 1;
        //}
    }
}