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

            int[] mang = new int[0];
            Search search = new Search();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n\t\t===== MENU =====");
                Console.WriteLine("1. Nhập mảng");
                Console.WriteLine("2. Tìm phần tử có giá trị X đầu tiên");
                Console.WriteLine("3. Tìm phần tử có giá trị X cuối cùng");
                Console.WriteLine("4. Tìm tất cả phần tử có giá trị X");
                Console.WriteLine("5. Tìm phần tử nhỏ nhất đầu tiên");
                Console.WriteLine("6. Tìm phần tử lớn nhất sau cùng");
                Console.WriteLine("7. Tìm tất cả các số nhỏ nhất trong mảng");
                Console.WriteLine("8. Tìm phần tử là số lẻ lớn nhất đầu tiên");
                Console.WriteLine("9. Tìm kiếm phần tử là số chẵn lớn nhất sau cùng");
                Console.WriteLine("10. Tìm kiếm nhị phân phần tử có giá trị X (phương pháp lặp)");
                Console.WriteLine("11. Tìm kiếm nhị phân phần tử có giá trị X (phương pháp đệ quy)");
                Console.WriteLine("12. Hiển thị mảng");
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
                        mang = NhapMang();
                        break;

                    // 1.1
                    case 2:
                        Console.Write("Nhập giá trị X cần tìm: ");
                        if (!int.TryParse(Console.ReadLine(), out int x2))
                        {
                            Console.WriteLine("❌ Giá trị không hợp lệ!");
                            continue;
                        }
                        int i2 = search.FindFirst(mang, mang.Length, x2);
                        if (i2 != -1)
                            Console.WriteLine($"✅ Phần tử có giá trị {x2} đầu tiên ở vị trí {i2}");
                        else
                            Console.WriteLine($"❌ Không tìm thấy phần tử có giá trị {x2}");
                        break;

                    // 1.2
                    case 3:
                        Console.Write("Nhập giá trị X cần tìm: ");
                        if (!int.TryParse(Console.ReadLine(), out int x3))
                        {
                            Console.WriteLine("❌ Giá trị không hợp lệ!");
                            continue;
                        }
                        int i3 = search.FindLast(mang, mang.Length, x3);
                        if (i3 != -1)
                            Console.WriteLine($"✅ Phần tử có giá trị {x3} sau cùng ở vị trí {i3}");
                        else
                            Console.WriteLine($"❌ Không tìm thấy phần tử có giá trị {x3}");
                        break;

                    // 1.3
                    case 4:
                        Console.Write("Nhập giá trị X cần tìm: ");
                        if (!int.TryParse(Console.ReadLine(), out int x4))
                        {
                            Console.WriteLine("❌ Giá trị không hợp lệ!");
                            continue;
                        }
                        List<int> i4 = search.FindAll(mang, mang.Length, x4);
                        if (i4.Count > 0)
                            Console.WriteLine($"✅ Các phần tử có giá trị {x4} ở vị trí: {string.Join(", ", i4)}");
                        else
                            Console.WriteLine($"❌ Không tìm thấy phần tử có giá trị {x4}");
                        break;

                    // 1.4
                    case 5:
                        int i5 = search.FindMinFirst(mang, mang.Length);
                        if (i5 != -1)
                            Console.WriteLine($"✅ Phần tử có giá trị nhỏ nhất đầu tiên ở vị trí {i5}");
                        else
                            Console.WriteLine($"❌ Không tìm thấy phần tử nhỏ nhất đầu tiên");
                        break;

                    // 1.5
                    case 6:
                        int i6 = search.FindMaxLast(mang, mang.Length);
                        if (i6 != -1)
                            Console.WriteLine($"✅ Phần tử có giá trị lớn nhất sau cùng ở vị trí {i6}");
                        else
                            Console.WriteLine($"❌ Không tìm thấy phần tử lớn nhất sau cùng");
                        break;

                    // 1.6
                    case 7:
                        List<int> i7 = search.FindAllMin(mang, mang.Length);
                        if (i7.Count > 0)
                            Console.WriteLine($"✅ Các phần tử nhỏ nhất ở vị trí: {string.Join(", ", i7)}");
                        else
                            Console.WriteLine($"❌ Không tìm thấy phần tử nhỏ nhất");
                        break;

                    // 1.7
                    case 8:
                        int i8 = search.FindFirstMaxOdd(mang, mang.Length);
                        if (i8 != -1)
                            Console.WriteLine($"✅ Phần tử là số lẻ lớn nhất đầu tiên ở vị trí: {string.Join(", ", i8)}");
                        else
                            Console.WriteLine($"❌ Không tìm thấy phần tử là số lẻ lớn nhất đầu tiên");
                        break;

                    // 1.8
                    case 9:
                        int i9 = search.FindLastMaxEven(mang, mang.Length);
                        if (i9 != -1)
                            Console.WriteLine($"✅ Phần tử là số chẵn lớn nhất sau cùng ở vị trí: {string.Join(", ", i9)}");
                        else
                            Console.WriteLine($"❌ Không tìm thấy phần tử là số chẵn lớn nhất sau cùng");
                        break;

                    // 1.9
                    case 10:
                        Console.Write("Nhập giá trị X cần tìm: ");
                        if (!int.TryParse(Console.ReadLine(), out int x10))
                        {
                            Console.WriteLine("❌ Giá trị không hợp lệ!");
                            continue;
                        }
                        int i10 = search.BinarySearchInterative(mang, mang.Length, x10);
                        if (i10 != -1)
                            Console.WriteLine($"✅ Phần tử có giá trị {x10} ở vị trí {i10}");
                        else
                            Console.WriteLine($"❌ Không tìm thấy phần tử có giá trị {x10}");
                        break;

                    // 1.10
                    case 11:
                        Console.Write("Nhập giá trị X cần tìm: ");
                        if (!int.TryParse(Console.ReadLine(), out int x11))
                        {
                            Console.WriteLine("❌ Giá trị không hợp lệ!");
                            continue;
                        }
                        int i11 = search.BinarySearchRecursive(mang, 0, mang.Length - 1, x11);
                        if (i11 != -1)
                            Console.WriteLine($"✅ Phần tử có giá trị {x11} ở vị trí {i11}");
                        else
                            Console.WriteLine($"❌ Không tìm thấy phần tử có giá trị {x11}");
                        break;

                    case 12:
                        Console.WriteLine("✅ Mảng đã nhập: " + (mang.Length > 0 ? string.Join(", ", mang) : "(Chưa có dữ liệu)"));
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
    }
}
