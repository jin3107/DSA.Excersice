using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_tr24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            int[] mang = { 16, 82, 6, 76, 4, 6, 76, 4, 82, 2 };
            //int[] mang = { 9, 28, 2, 2, 16, 17, 28, 2, 17, 10 };
            Search search = new Search();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n\t\t===== MENU =====");
                Console.WriteLine("1. Tìm phần tử có giá trị X đầu tiên");
                Console.WriteLine("2. Tìm phần tử có giá trị X cuối cùng");
                Console.WriteLine("3. Tìm tất cả phần tử có giá trị X");
                Console.WriteLine("4. Tìm phần tử nhỏ nhất đầu tiên");
                Console.WriteLine("5. Tìm phần tử lớn nhất sau cùng");
                Console.WriteLine("6. Tìm tất cả các số nhỏ nhất trong mảng");
                Console.WriteLine("7. Tìm phần tử là số lẻ lớn nhất đầu tiên");
                Console.WriteLine("8. Tìm kiếm phần tử là số chẵn lớn nhất sau cùng");
                Console.WriteLine("9. Tìm kiếm nhị phân phần tử có giá trị X (phương pháp lặp)");
                Console.WriteLine("10. Tìm kiếm nhị phân phần tử có giá trị X (phương pháp đệ quy)");
                Console.WriteLine("11. Hiển thị mảng");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn chức năng: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("❌ Lựa chọn không hợp lệ!");
                    continue;
                }

                Console.Clear();
                switch (choice)
                {
                    case 1:
                        Console.Write("Nhập giá trị X cần tìm: ");
                        if (!int.TryParse(Console.ReadLine(), out int x2))
                        {
                            Console.WriteLine("❌ Giá trị không hợp lệ!");
                            continue;
                        }
                        int i2 = search.FindFirst(mang, x2);
                        if (i2 != -1)
                            Console.WriteLine($"✅ Phần tử có giá trị {x2} đầu tiên ở vị trí {i2}");
                        else
                            Console.WriteLine($"❌ Không tìm thấy phần tử có giá trị {x2}");
                        break;

                    // 1.2
                    case 2:
                        Console.Write("Nhập giá trị X cần tìm: ");
                        if (!int.TryParse(Console.ReadLine(), out int x3))
                        {
                            Console.WriteLine("❌ Giá trị không hợp lệ!");
                            continue;
                        }
                        int i3 = search.FindLast(mang, x3);
                        if (i3 != -1)
                            Console.WriteLine($"✅ Phần tử có giá trị {x3} sau cùng ở vị trí {i3}");
                        else
                            Console.WriteLine($"❌ Không tìm thấy phần tử có giá trị {x3}");
                        break;

                    // 1.3
                    case 3:
                        Console.Write("Nhập giá trị X cần tìm: ");
                        if (!int.TryParse(Console.ReadLine(), out int x4))
                        {
                            Console.WriteLine("❌ Giá trị không hợp lệ!");
                            continue;
                        }
                        // List
                        Console.WriteLine("--- *** List *** ---");
                        List<int> i4list = search.FindAllList(mang, x4);
                        if (i4list.Count > 0)
                            Console.WriteLine($"✅ Các phần tử có giá trị {x4} ở vị trí: {string.Join(", ", i4list)}");
                        else
                            Console.WriteLine($"❌ Không tìm thấy phần tử có giá trị {x4}");

                        // Array
                        Console.WriteLine("\n--- *** Array *** ---");
                        int i4arr = search.FindAllArray(mang, x4);
                        if (i4arr > 0)
                            Console.WriteLine($"✅ Số lần xuất hiện phần tử có giá trị {x4} là: {i4arr}");
                        else
                            Console.WriteLine($"❌ Không tìm thấy phần tử có giá trị {x4}");
                        break;

                    // 1.4
                    case 4:
                        int i5MinFirst = search.FindMinFirst141(mang);
                        if (i5MinFirst != -1)
                            Console.WriteLine($"✅ Phần tử có giá trị nhỏ nhất đầu tiên trong mảng ở vị trí {i5MinFirst}");
                        else
                            Console.WriteLine($"❌ Không tìm thấy phần tử nhỏ nhất đầu tiên");

                        int i5MinLast = search.FindMinLast142(mang);
                        if (i5MinLast != -1)
                            Console.WriteLine($"✅ Phần tử có giá trị nhỏ nhất sau cùng trong mảng ở vị trí {i5MinLast}");
                        else
                            Console.WriteLine($"❌ Không tìm thấy phần tử nhỏ nhất sau cùng");

                        int i5MaxFirst = search.FindMaxFirst143(mang);
                        if (i5MaxFirst != -1)
                            Console.WriteLine($"✅ Phần tử có giá trị lớn nhất đầu tiên trong mảng ở vị trí {i5MaxFirst}");
                        else
                            Console.WriteLine($"❌ Không tìm thấy phần tử lớn nhất đầu tiên");

                        int i5MaxLast = search.FindMaxLast144(mang);
                        if (i5MaxLast != -1)
                            Console.WriteLine($"✅ Phần tử có giá trị lớn nhất sau cùng trong mảng ở vị trí {i5MaxLast}");
                        else
                            Console.WriteLine($"❌ Không tìm thấy phần tử lớn nhất sau cùng");

                        int i5MinFirst2 = search.FindMinFirst145(mang);
                        if (i5MinFirst2 != -1)
                            Console.WriteLine($"✅ Phần tử có giá trị nhỏ nhất đầu tiên ở vị trí {i5MinFirst2}");
                        else
                            Console.WriteLine($"❌ Không tìm thấy phần tử nhỏ nhất đầu tiên");

                        break;

                    // 1.5
                    case 5:
                        int i6 = search.FindMaxLast(mang);
                        if (i6 != -1)
                            Console.WriteLine($"✅ Phần tử có giá trị lớn nhất sau cùng ở vị trí {i6}");
                        else
                            Console.WriteLine($"❌ Không tìm thấy phần tử lớn nhất sau cùng");
                        break;

                    // 1.6
                    case 6:
                        search.FindAllMinList(mang);
                        search.FindAllMinArray(mang);
                        search.FindAllX(mang, 6);
                        break;

                    // 1.7
                    case 7:
                        int i8 = search.FindFirstMaxOdd(mang);
                        if (i8 != -1)
                            Console.WriteLine($"✅ Phần tử là số lẻ lớn nhất đầu tiên ở vị trí: {string.Join(", ", i8)}");
                        else
                            Console.WriteLine($"❌ Không tìm thấy phần tử là số lẻ lớn nhất đầu tiên");
                        break;

                    // 1.8
                    case 8:
                        int i9 = search.FindLastMaxEven(mang);
                        if (i9 != -1)
                            Console.WriteLine($"✅ Phần tử là số chẵn lớn nhất sau cùng ở vị trí: {string.Join(", ", i9)}");
                        else
                            Console.WriteLine($"❌ Không tìm thấy phần tử là số chẵn lớn nhất sau cùng");
                        break;

                    // 1.9
                    case 9:
                        Console.Write("Nhập giá trị X cần tìm: ");
                        if (!int.TryParse(Console.ReadLine(), out int x10))
                        {
                            Console.WriteLine("❌ Giá trị không hợp lệ!");
                            continue;
                        }
                        
                        Array.Sort(mang);
                        Console.WriteLine("Mảng sau khi sắp xếp: ");
                        XuatMang(mang);
                        search.BinarySearchInterativeWrapper(mang, x10);
                        break;

                    // 1.10
                    case 10:
                        Console.Write("Nhập giá trị X cần tìm: ");
                        if (!int.TryParse(Console.ReadLine(), out int x11))
                        {
                            Console.WriteLine("❌ Giá trị không hợp lệ!");
                            continue;
                        }
                        XuatMang(mang);
                        search.BinarySearchRecursiveWrapper(mang, x11);
                        break;

                    case 11:
                        XuatMang(mang);
                        break;

                    case 0:
                        Console.WriteLine("Thoát chương trình.");
                        return;

                    default:
                        Console.WriteLine("❌ Chức năng không hợp lệ!");
                        break;
                }
                Console.Write("\nNhấn phím bất kỳ để tiếp tục...");
                Console.ReadKey();
            }
        }

        public static int[] NhapMang()
        {
            Console.Write("Nhập số lượng phần tử: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("❌ Số lượng phần tử không hợp lệ!");
                return new int[0];
            }

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}] = ");
                if (!int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.WriteLine("❌ Giá trị không hợp lệ!");
                    return new int[0];
                }
            }
            return arr;
        }

        public static void XuatMang(int[] arr)
        {
            Console.WriteLine("Mảng đã nhập: " + (arr.Length > 0 ? string.Join(", ", arr) : "(Chưa có dữ liệu)"));
        }
    }
}
