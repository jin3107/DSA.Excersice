using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_BS4
{
    public class LinkedList
    {
        protected Node First;

        public LinkedList() 
        { 
            First = null;
        }

        // 1. Duyệt và xuất giá trị các nút của ds ra màn hình
        public void PrintList()
        {
            if (First == null)
            {
                Console.WriteLine("Danh sách rỗng");
                return;
            }
            Node curNode = First;
            while (curNode != null)
            {
                Console.Write(curNode.Value);
                if (curNode.Next != null)
                    Console.Write(" -> ");
                curNode = curNode.Next;
            }
        }

        // 2. Thêm X vào sau V
        public Node AddXAfterV(object X, object V)
        {
            if (First == null || X == null || V == null)
                return null;
            Node curNode = First;
            while (curNode != null && !curNode.Value.Equals(V))
                curNode = curNode.Next;
            if (!curNode.Value.Equals(V))
                return null;
            Node newNode = new Node(X);
            newNode.Next = curNode.Next;
            curNode.Next = newNode;
            return newNode;
        }

        // 3. Thêm X vào trước V
        public Node AddXBeforeV(object X, object V)
        {
            if (First == null || X == null || V == null) return null;
            Node curNode = First;
            Node prevNode = null;
            while (curNode != null && !curNode.Value.Equals(V))
            {
                prevNode = curNode;
                curNode = curNode.Next;
            }
            if (curNode == null) return null;
            Node newNode = new Node(X);
            if (prevNode == null)
            {
                newNode.Next = First;
                First = newNode;
            }
            else
            {
                prevNode.Next = newNode;
                newNode.Next = curNode;
            }
            return newNode;
        }

        // 4. Thêm X vào đầu trong dslk
        public void AddXFirst(object X)
        {
            if (X == null) return;
            Node newNode = new Node(X);
            newNode.Next = First;
            First = newNode;
        }

        // 5. Thêm X vào cuối trong dslk
        public void AddXLast(object X)
        {
            Node newNode = new Node(X);
            if (X == null) return;
            if (First == null) 
                First = newNode;
            Node curNode = First;
            while (curNode.Next != null)
                curNode = curNode.Next;
            curNode.Next = newNode;
        }

        // 6. Thêm giá trị X vào trước giá trị chẵn sau cùng trong dslk
        public void AddXBeforeEvenLast(object X)
        {
            if (X == null) return;
            if (First == null)
            {
                Console.WriteLine("Danh sách rỗng");
                return;
            }
            Node curNode = First;
            Node prevNode = null;
            Node lastEvenNode = null;
            Node lastEvenPrevNode = null;
            while (curNode != null) 
            {
                if ((int)curNode.Value % 2 == 0)
                {
                    lastEvenNode = curNode;
                    lastEvenPrevNode = prevNode;
                }
                prevNode = curNode;
                curNode = curNode.Next;
            }
            if (lastEvenNode == null)
            {
                Console.WriteLine("Không có giá trị chẵn trong danh sách");
                return;
            }
            Node newNode = new Node(X);
            if (lastEvenPrevNode == null)
            {
                newNode.Next = First;
                First = newNode;
            }
            else
            {
                newNode.Next = lastEvenNode;
                lastEvenPrevNode.Next = newNode;
            }
        }

        // 7. Thêm giá trị X vào sau giá trị chẵn sau cùng trong dslk
        public void AddXAfterEvenLast(object X)
        {
            if (X == null) return;
            if (First == null)
            {
                Console.WriteLine("Danh sách rỗng");
                return;
            }

            Node curNode = First;
            Node lastEvenNode = null;
            while (curNode != null)
            {
                if ((int)curNode.Value % 2 == 0)
                    lastEvenNode = curNode;
                curNode = curNode.Next;
            }
            if (lastEvenNode == null)
            {
                Console.WriteLine("Không có giá trị chẵn trong danh sách");
                return;
            }
            Node newNode = new Node(X);
            newNode.Next = lastEvenNode.Next;
            lastEvenNode.Next = newNode;
        }

        // 8. Thêm giá trị X vào trước giá trị chẵn đầu tiên trong dslk
        public void AddXBeforeEvenFirst(object X)
        {
            if (X == null) return;
            if (First == null)
            {
                Console.WriteLine("Danh sách rỗng");
                return;
            }

            Node curNode = First;
            Node prevNode = null;
            Node firstEven = null;
            while (curNode != null)
            {
                if ((int)curNode.Value % 2 == 0)
                { 
                    firstEven = curNode;
                    break;
                }
                prevNode = curNode;
                curNode = curNode.Next;
            }
            Node newNode = new Node(X);
            if (firstEven == null)
            {
                Console.WriteLine("Không có giá trị chẵn trong danh sách");
                return;
            }
            newNode.Next = curNode;
            if (firstEven == null)
                First = newNode;
            prevNode = newNode;
        }
    }
}
