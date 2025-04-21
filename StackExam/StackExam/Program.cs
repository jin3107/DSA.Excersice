using System;
using System.Collections;
using System.Text;

namespace StackExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Stack myStack = new Stack();
            myStack.Push("Một"); myStack.Push("Hai");
            myStack.Push("Ba"); myStack.Push("Bốn");

            Console.Write("Thứ tự Push vào Stack:\n\tMột\tHai\tBa\tBốn\n");
            Console.Write("\nGiá trị trong Stack (từ Top đến Bottom):\n");
            PrintValues(myStack, '\t');

            Console.Write($"\nStack.Pop()\t{myStack.Pop()}");
            Console.Write("\nGiá trị trong Stack:\n");
            PrintValues(myStack, '\t');

            Console.Write($"\nStack.Peek()\t{myStack.Peek()}");
            Console.Write("\nGiá trị trong Stack:\n");
            PrintValues(myStack, '\t');

            myStack.Clear();
            Console.Write("\nStack.Clear()\n");
            Console.Write($"\nStack.Count: {myStack.Count}");

            Console.Read();
        }

        public static void PrintValues(IEnumerable myCollection, char mySeparator)
        {
            foreach (Object obj in myCollection)
            {
                Console.Write($"{mySeparator}{obj}");
            }
            Console.WriteLine();
        }
    }
}
