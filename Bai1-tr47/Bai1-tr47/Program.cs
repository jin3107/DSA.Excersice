using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_tr47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập chuỗi ký tự: ");
            string input = Console.ReadLine();
            Service reserve = new Service();
            reserve.ReserveString(input);
            Console.WriteLine();

            int so, coSo;
            Console.Write("Nhập vào cơ số muốn đổi: ");
            so = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập vào số muốn đổi: ");
            coSo = Convert.ToInt32(Console.ReadLine());

            string ketQua = reserve.DoiCoSo(so, coSo);
            Console.WriteLine($"Số {so} đổi sang cơ số {coSo} là {ketQua}");
            Console.ReadKey();
        }
    }
}
