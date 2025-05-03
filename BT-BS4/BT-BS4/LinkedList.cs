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
            else
            {
                Node curNode = First;
                while (curNode.Next != null)
                    curNode = curNode.Next;
                curNode.Next = newNode;
            }
        }
    }
}
