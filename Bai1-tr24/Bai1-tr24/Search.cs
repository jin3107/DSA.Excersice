using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_tr24
{
    public class Search
    {
        // 1.1. Tìm phần từ có giá trị X đầu tiên
        public int FindFirst(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)

                    return i;
            }
            return -1;
        }

        // 1.2. Tìm phần tử có giá trị X cuối cùng
        public int FindLast(int[] arr, int x)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }

        // 1.3. Tìm tất cả phần tử có giá trị X
        public List<int> FindAllList(int[] arr, int x)
        {
            List<int> indices = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                    indices.Add(i);
            }
            return indices;
        }

        public int FindAllArray(int[] arr, int x)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                    count++;
            }
            return count;
        }

        // 1.4.1 Tìm phần tử nhỏ nhất trong mảng đầu tiên
        public int FindMinFirst141(int[] arr)
        {
            int imin = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[imin])
                    imin = i;
            }
            return imin;
        }

        // 1.4.2 Tìm phần tử nhỏ nhất trong mảng sau cùng
        public int FindMinLast142(int[] arr)
        {
            int imin = arr.Length - 1;
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                if (arr[i] < arr[imin])
                    imin = i;
            }
            return imin;
        }

        // 1.4.3 Tìm phần tử lớn nhất trong mảng đầu tiên
        public int FindMaxFirst143(int[] arr)
        {
            int imax = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[imax])
                    imax = i;
            }
            return imax;
        }

        // 1.4.4 Tìm phần tử lớn nhất trong mảng sau cùng
        public int FindMaxLast144(int[] arr)
        {
            int imax = arr.Length - 1;
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                if (arr[i] > arr[imax])
                    imax = i;
            }
            return imax;
        }

        // 1.4.5 Tìm phần tử nhỏ nhất đầu tiên
        public int FindMinFirst145(int[] arr)
        {
            int imin = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[imin])
                {
                    imin = i;
                    break;
                }
            }
            return imin;
        }


        // 1.5. Tìm phần tử lớn nhất sau cùng
        public int FindMaxLast(int[] arr)
        {
            int imax = arr.Length - 1;
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                if (arr[i] > arr[imax])
                    imax = i;
            }
            return imax;
        }

        // 1.6.1 Tìm tất cả các số nhỏ nhất trong mảng List
        public void FindAllMinList(int[] arr)
        {
            List<int> indices = new List<int>();
            int min = int.MaxValue;
            foreach (var num in arr)
            {
                if (num < min)
                    min = num;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == min)
                    indices.Add(i);
            }
            if (indices.Count > 0)
                Console.WriteLine($"✅ Các phần tử nhỏ nhất có giá trị {min} ở vị trí: {string.Join(", ", indices)}");
            else
                Console.WriteLine($"❌ Không tìm thấy phần tử nhỏ nhất");
        }

        // 1.6.2 Tìm tất cả các số nhỏ nhất trong mảng Array
        public void FindAllMinArray(int[] arr)
        {
            int min = int.MaxValue;
            foreach (var num in arr)
            {
                if (num < min)
                    min = num;
            }
            List<int> indices = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == min)
                    indices.Add(i);
            }
            if (indices.Count > 0)
                Console.WriteLine($"✅ Có {indices.Count} phần tử nhỏ nhất có giá trị {min} ở vị trí: {string.Join(", ", indices)}");
            else
                Console.WriteLine($"❌ Không tìm thấy phần tử nhỏ nhất");
        }

        // 1.6.3 Tìm tất cả các số X = 6 trong mảng
        public void FindAllX(int[] arr, int x)
        {
            List<int> indices = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                    indices.Add(i);
            }
            if (indices.Count > 0)
                Console.WriteLine($"✅ Có {indices.Count} phần tử có giá trị {x} ở vị trí: {string.Join(", ", indices)}");
            else
                Console.WriteLine($"❌ Không tìm thấy phần tử có giá trị {x}");
        }

        // 1.7. Tìm phần tử là số lẻ lớn nhất đầu tiên
        public int FindFirstMaxOdd(int[] arr)
        {
            int maxOdd = int.MinValue, index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0 && arr[i] > maxOdd)
                {
                    maxOdd = arr[i];
                    index = i;
                }
            }
            return index;
        }

        // 1.8. Tìm kiếm phần tử là số chẵn lớn nhất sau cùng
        public int FindLastMaxEven(int[] arr)
        {
            int maxEven = int.MinValue, index = -1;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] % 2 == 0 && arr[i] > maxEven)
                {
                    maxEven = arr[i];
                    index = i;
                }
            }
            return index;
        }

        // 1.9. Tìm kiếm nhị phân phần tử có giá trị X (phương pháp lặp)
        public void BinarySearchInterative(int[] arr, int x)
        {
            int low = 0, up = arr.Length - 1;
            while (low <= up)
            {
                int mid = (low + up) / 2;
                if (arr[mid] == x)
                {
                    Console.WriteLine($"✅ Phần tử có giá trị {x} ở vị trí: {mid}");
                    return;
                }
                else if (x > arr[mid])
                    low = mid + 1;
                else
                    up = mid - 1;
            }
            Console.WriteLine($"❌ Không tìm thấy phần tử có giá trị {x}");
        }

        public void BinarySearchInterativeWrapper(int[] arr, int x)
        {
            Array.Sort(arr);
            BinarySearchInterative(arr, x);
        }

        // 1.10. Tìm kiếm nhị phân phần tử có giá trị X (phương pháp đệ quy)
        public void BinarySearchRecursive(int[] arr, int low, int up, int x, List<int> indices)
        {
            if (low > up)
                return;
            int mid = (low + up) / 2;
            if (arr[mid] == x)
                indices.Add(mid);
            if (x < arr[mid])
                BinarySearchRecursive(arr, low, mid - 1, x, indices);
            else
                BinarySearchRecursive(arr, mid + 1, up, x, indices);
        }

        public void BinarySearchRecursiveWrapper(int[] arr, int x)
        {
            Array.Sort(arr);
            List<int> indices = new List<int>();
            BinarySearchRecursive(arr, 0, arr.Length - 1, x, indices);

            if (indices.Count > 0)
                Console.WriteLine($"✅ Có {indices.Count} phần tử có giá trị {x} ở vị trí: {string.Join(", ", indices)}");
            else
                Console.WriteLine($"❌ Không tìm thấy phần tử có giá trị {x}");
        }

        public void InterpolationSearch(int[] arr, int x)
        {
            int low = 0, up = arr.Length - 1;
            while (low <= up && x >= arr[low] && x <= arr[up])
            {
                if (low == up)
                {
                    if (arr[low] == x)
                        Console.WriteLine($"✅ Phần tử có giá trị {x} ở vị trí: {low}");
                    return;
                }
                int pos = low + ((x - arr[low]) * (up - low)) / (arr[up] - arr[low]);
                if (arr[pos] == x)
                {
                    Console.WriteLine($"✅ Phần tử có giá trị {x} ở vị trí: {pos}");
                    return;
                }
                if (arr[pos] < x)
                    low = pos + 1;
                else
                    up = pos - 1;
            }
            Console.WriteLine($"❌ Không tìm thấy phần tử có giá trị {x}");
        }

        public void InterpolationSearchWrapper(int[] arr, int x)
        {
            Array.Sort(arr);
            InterpolationSearch(arr, x);
        }

        public void InterpolationSearchRecursive(int[] arr, int low, int up, int x)
        {
            if (low > up || x < arr[low] || x > arr[up])
                return;
            if (low == up)
            {
                if (arr[low] == x)
                    Console.WriteLine($"✅ Phần tử có giá trị {x} ở vị trí: {low}");
                return;
            }
            int pos = low + ((x - arr[low]) * (up - low)) / (arr[up] - arr[low]);
            if (arr[pos] == x)
            {
                Console.WriteLine($"✅ Phần tử có giá trị {x} ở vị trí: {pos}");
                return;
            }
            if (arr[pos] < x)
                InterpolationSearchRecursive(arr, pos + 1, up, x);
            else
                InterpolationSearchRecursive(arr, low, pos - 1, x);
        }

        public void InterpolationSearchRecursiveWrapper(int[] arr, int x)
        {
            Array.Sort(arr);
            InterpolationSearchRecursive(arr, 0, arr.Length - 1, x);
        }
    }
}
