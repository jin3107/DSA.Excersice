using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nsStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            int so, coSo;
            Console.Write("Nhập vào số muốn đồi: ");

            so = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập vào cơ số mới: ");

            coSo = Convert.ToInt32(Console.ReadLine());
            string ketQua = DoiCoSo(so, coSo);

            Console.Write($"Số {so} đổi dang cơ số {coSo} là {ketQua}");
            Console.Read();
        }

        private static string DoiCoSo(int so, int coSo)
        {
            int soDu;
            Cstack cstack = new Cstack();
            do
            {
                soDu = so % coSo;
                cstack.Push(soDu);
                so /= coSo;
            } while (so != 0);

            string ketQua = "";
            while (cstack.Count > 0) 
                ketQua += cstack.Pop().ToString();

            return ketQua;
        }
    }
}
