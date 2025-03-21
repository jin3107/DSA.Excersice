using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_tr8
{
    public class App
    {
        public void Run()
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("-- Chương trình đo thời gian & bộ nhớ khi hiển thị n số nguyên --");
            Console.Write("\nNhập n: ");
            if (!long.TryParse(Console.ReadLine(), out long N) || N <= 0)
            {
                Console.WriteLine("Giá trị nhập không hợp lệ!");
                return;
            }

            Console.WriteLine("Gõ phím để bắt đầu hiển thị và đo thời gian ...");
            Console.ReadKey();

            MemoryTracker memoryTracker = new MemoryTracker();
            long memoryBefore = memoryTracker.GetMemoryUsage();
            Stopwatch timer = Stopwatch.StartNew();

            NumberDisplay numberDisplay = new NumberDisplay();
            numberDisplay.Display(N);

            timer.Stop();
            long memoryAfter = memoryTracker.GetMemoryUsage();

            Console.WriteLine("\n\nKết thúc đo thời gian!");
            Console.WriteLine($"⏱️ Thời gian: {timer.ElapsedMilliseconds} mili giây");
            Console.WriteLine($"📌 Bộ nhớ trước: {memoryBefore / 1024.0:F2} KB");
            Console.WriteLine($"📌 Bộ nhớ sau: {memoryAfter / 1024.0:F2} KB");
            Console.WriteLine($"📌 Chênh lệch: {(memoryAfter - memoryBefore) / 1024.0:F2} KB");
            Console.ReadKey();
        }
    }
}
