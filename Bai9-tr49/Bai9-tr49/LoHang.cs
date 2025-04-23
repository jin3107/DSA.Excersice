using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9_tr49
{
    public class LoHang
    {
        public string MaLoHang { get; set; }
        public string TenLoHang { get; set; }

        public LoHang() { }

        public LoHang(string maLoHang, string tenLoHang)
        {
            MaLoHang = maLoHang;
            TenLoHang = tenLoHang;
        }

        public void NhapLoHang()
        {
            Console.Write("Nhập mã lô hàng: ");
            MaLoHang = Console.ReadLine();

            Console.Write("Nhập tên lô hàng: ");
            TenLoHang = Console.ReadLine();
        }

        public override string ToString()
        {
            return $"Mã lô hàng: {MaLoHang}, Tên lô hàng: {TenLoHang}";
        }
    }
}
