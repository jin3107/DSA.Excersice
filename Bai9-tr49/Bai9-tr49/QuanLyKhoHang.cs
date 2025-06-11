using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9_tr49
{
    public class QuanLyKhoHang
    {
        public Queue<LoHang> khoHang = new Queue<LoHang>();

        //public void NhapKho(int soLuong, List<LoHang> danhSachNhap)
        //{
        //    foreach (var lo in danhSachNhap)
        //    {
        //        khoHang.Enqueue(lo);
        //    }
        //}
        public void NhapKho()
        {
            Console.Write("Nhập số lượng lô hàng: ");
            int soLuong = int.Parse(Console.ReadLine());
            for (int i = 0; i < soLuong; i++)
            {
                Console.WriteLine($"\nNhập lô hàng thứ {i + 1}:");
                LoHang loHang = new LoHang();
                loHang.NhapLoHang();
                khoHang.Enqueue(loHang);
            }

            Console.WriteLine("\nĐơn hàng đã nhập:");
            foreach (var lo in khoHang)
            {
                Console.WriteLine(lo.ToString());
            } 

        }

        public LoHang XuatKho()
        {
            if (khoHang.Count > 0)
            {
                return khoHang.Dequeue();
            }
            else
            {
                Console.WriteLine("Kho hàng rỗng!");
                return null;
            }
        }

        public int SoLuongTonKho()
        {
            return khoHang.Count;
        }

        public void HienThiKho()
        {
            if (khoHang.Count == 0)
            {
                Console.WriteLine("Kho hàng rỗng.");
                return;
            }

            Console.WriteLine("Danh sách lô hàng trong kho:");
            foreach (var lo in khoHang)
            {
                Console.WriteLine(lo.ToString());
            }
        }
    }
}
