using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace BT_BS4
{
    public class LinkedList<T>
    {
        protected Node<T> First;

        public LinkedList()
        {
            First = null;
        }

        //1. Thêm X vào sau V
        public Node<T> AddAfter(T V, T X)
        {
            if (First == null || V == null || X == null)
                return null;

            Node<T> curNode = First;
            while (!curNode.Value.Equals(V) && curNode.Next != null)
                curNode = curNode.Next;

            if (!curNode.Value.Equals(V))
                return null;

            Node<T> newNode = new Node<T>(X);
            newNode.Next = curNode.Next;
            curNode.Next = newNode;
            return newNode;
        }

        // 2. Thêm X vào trước V
        public Node<T> AddBefore(T V, T X)
        {
            if (First == null || V == null || X == null)
                return null;
            if (First.Value.Equals(V))
            {
                AddFirst(X);
                return First;
            }
            Node<T> curNode = First;
            Node<T> prevNode = null;
            while (curNode != null && !curNode.Value.Equals(V))
            {
                prevNode = curNode;
                curNode = curNode.Next;
            }
            if (curNode == null)
                return null;
            Node<T> newNode = new Node<T>(X);
            prevNode.Next = newNode;
            newNode.Next = curNode;
            return newNode;
        }

        // 3. Thêm X vào đầu trong dslk
        public void AddFirst(T X)
        {
            if (X == null) return;

            Node<T> newNode = new Node<T>(X);
            newNode.Next = First;
            First = newNode;
            Console.WriteLine($"Đã thêm {X} vào đầu danh sách.");
        }

        // 4. Thêm X vào cuối trong dslk
        public void AddLast(T X)
        {
            if (X == null) return;
            Node<T> newNode = new Node<T>(X);
            if (First == null)
                First = newNode;
            else
            {
                Node<T> curNode = First;
                while (curNode.Next != null)
                    curNode = curNode.Next;
                curNode.Next = newNode;
                Console.WriteLine($"Đã thêm {X} vào cuối danh sách.");
            }
        }

        // 5. Thêm X vào giữa trong dslk
        public void AddCenter(T X)
        {
            if (X == null) return;
            Node<T> newNode = new Node<T>(X);
            if (First == null)
            {
                First = newNode;
                return;
            }

            Node<T> curNode = First;
            int count = 0;
            while (curNode != null)
            {
                count++;
                curNode = curNode.Next;
            }

            curNode = First;
            int mid = count / 2;
            for (int i = 1; i < mid; i++)
                curNode = curNode.Next;
            newNode.Next = curNode.Next;
            curNode.Next = newNode;
            Console.WriteLine($"Đã thêm {X} vào giữa danh sách.");
        }

        // 6. Thêm giá trị X vào trước giá trị chẵn sau cùng trong dslk
        public void AddBeforeEvenLast(T X)
        {
            if (X == null) return;
            Node<T> newNode = new Node<T>(X);
            if (First == null)
            {
                First = newNode;
                return;
            }

            Node<T> curNode = First;
            Node<T> evenNode = null;
            Node<T> prevNode = null;
            Node<T> lastEvenPrevNode = null;
            while (curNode != null)
            {
                if (curNode.Value is int && (int)(object)curNode.Value % 2 == 0)
                {
                    evenNode = curNode;
                    lastEvenPrevNode = prevNode;
                }
                prevNode = curNode;
                curNode = curNode.Next;
            }
            if (evenNode != null && lastEvenPrevNode != null)
            {
                newNode.Next = evenNode;
                lastEvenPrevNode.Next = newNode;
                Console.WriteLine($"Đã thêm {X} vào trước {evenNode.Value}.");
            }
            else if (evenNode == null)
                Console.WriteLine("Không có số chẵn trong danh sách liên kết.");
        }



















        // In dslk
        public void PrintList()
        {
            if (First == null)
            {
                Console.WriteLine("Danh sách rỗng.");
                return;
            }

            Node<T> curNode = First;
            while (curNode != null)
            {
                Console.Write(curNode.Value);
                if (curNode.Next != null)
                    Console.Write(" -> ");
                curNode = curNode.Next;
            }
            Console.WriteLine();
        }
    }
}
