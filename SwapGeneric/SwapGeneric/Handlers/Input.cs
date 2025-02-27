using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapGeneric.Handlers
{
    public static class Input
    {
        public static T GetInput<T>(string message) where T : IConvertible
        {
            while (true)
            {
                Console.Write(message);
                string? input = Console.ReadLine();

                try
                {
                    T value = (T)Convert.ChangeType(input, typeof(T))!;
                    if (typeof(T) == typeof(int) && Convert.ToInt32(value) < 0)
                    {
                        Console.WriteLine("❌ Lỗi: Giá trị phải là số nguyên dương!");
                        continue;
                    }
                    if (typeof(T) == typeof(double) && Convert.ToDouble(value) < 0)
                    {
                        Console.WriteLine("❌ Lỗi: Giá trị phải là số thực dương!");
                        continue;
                    }
                    if (typeof(T) == typeof(string) && string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("❌ Lỗi: Chuỗi không được để trống!");
                        continue;
                    }
                    return value;
                }
                catch
                {
                    Console.WriteLine("❌ Lỗi: Giá trị nhập vào không hợp lệ, vui lòng thử lại.");
                }
            }
        }
    }
}
