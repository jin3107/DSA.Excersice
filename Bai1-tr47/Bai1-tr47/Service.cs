using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_tr47
{
    public class Service
    {
        public void ReserveString(string str)
        {
            //Stack<string> stack = new Stack<string>(); Phương thức có sẵn của C#
            CStack stack = new CStack();
            string[] words = str.Split(' ');
            foreach (string word in words)
            {
                stack.Push(word);
            }
            string reversedString = "";
            while (stack.Count > 0)
            {
                reversedString += stack.Pop() + " ";
            }
            Console.WriteLine("Chuỗi ký tự đã đảo ngược: " + reversedString.Trim());
        }

        public string DoiCoSo(int so, int coSo)
        {
            //Stack<string> stack = new Stack<string>(); Phương thức có sẵn của C#
            CStack stack = new CStack();
            do
            {
                int soDu = so % coSo;
                stack.Push(soDu);
                so /= coSo;
            }
            while (so != 0);
            string ketQua = "";
            while (stack.Count > 0)
                ketQua += stack.Pop().ToString();
            return ketQua;
        }
    }
}
