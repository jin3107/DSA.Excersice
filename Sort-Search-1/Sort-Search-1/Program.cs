using System;
using System.Text;

namespace Sort_Search_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Sort sort = new Sort();
            int[] a = { 10, 5, 1, 3, 4, 15, 1, 7, 8, 12 };
            int[] ac = (int[])a.Clone();
            int[] b = { 2, 4, 6, 16, 76, 82 };
            int[] c = { 1, 3, 5, 7, 11, 13, 17, 19, 25, 31 };

            while (true)
            {
                Console.WriteLine("\nMảng A ban đầu:");
                sort.DisplayElements(a, a.Length);

                Console.WriteLine("\nMảng B ban đầu:");
                sort.DisplayElements(b, b.Length);

                Console.WriteLine("\nMảng C ban đầu:");
                sort.DisplayElements(c, c.Length);

                Console.WriteLine("\n\n*** MENU ***");
                Console.WriteLine("4. Sắp xếp Interchange Sort");
                Console.WriteLine("5. Sắp xếp Bubble Sort");
                Console.WriteLine("6. Sắp xếp Shaker Sort");
                Console.WriteLine("7. Sắp xếp Selection Sort");
                Console.WriteLine("8. Sắp xếp Insertion Sort");
                Console.WriteLine("9. Sắp xếp Quick Sort");
                Console.WriteLine("10. Sắp xếp Heap Sort");
                Console.WriteLine("0. Thoát chương trình");
                Console.WriteLine("-------------------------------");

                Console.Write("Nhập lựa chọn của bạn: ");
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập lại!");
                    continue;
                }

                Console.WriteLine();
                switch (choice)
                {
                    case 4:
                        sort.InterchangeSort(ac, ac.Length);
                        Console.Write("\nMảng sau khi sắp xếp bằng Interchange Sort: ");
                        sort.DisplayElements(ac, ac.Length);
                        break;

                    case 10:
                        sort.HeapSort(ac, ac.Length);
                        Console.Write("\nMảng sau khi sắp xếp bằng Heap Sort:   ");
                        sort.DisplayElements(ac, ac.Length);
                        break;

                    case 0:
                        Console.WriteLine("Thoát chương trình.");
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }

                if (choice != 0)
                {
                    Console.WriteLine("\nNhấn phím bất kỳ để tiếp tục...");
                    Console.ReadKey();
                    Console.Clear();
                    ac = (int[])a.Clone();
                }
            }
        }
    }
}
