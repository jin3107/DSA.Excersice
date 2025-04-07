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
        /// <summary>
        /// Thêm giá trị X vào trước giá trị chẵn sau cùng trong danh sách liên kết.
        /// </summary>
        /// <param name="X">Giá trị cần thêm vào danh sách trước giá trị chẵn sau cùng.</param>
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

        // 7. Thêm giá trị X vào sau giá trị chẵn sau cùng trong dslk
        /// <summary>
        /// Thêm giá trị X vào sau giá trị chẵn sau cùng trong danh sách liên kết.
        /// </summary>
        /// <param name="X">Giá trị cần thêm vào danh sách sau giá trị chẵn sau cùng.</param>
        public void AddAfterEvenLast(T X)
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
            while (curNode != null)
            {
                if (curNode.Value is int && (int)(object)curNode.Value % 2 == 0)
                    evenNode = curNode;
                curNode = curNode.Next;
            }
            if (evenNode != null)
            {
                newNode.Next = evenNode.Next;
                evenNode.Next = newNode;
                Console.WriteLine($"Đã thêm {X} vào sau {evenNode.Value}.");
            }
            else
                Console.WriteLine("Không có số chẵn trong danh sách liên kết.");
        }

        // 8. Thêm giá trị X vào trước giá trị chẵn đầu tiên trong dslk
        /// <summary>
        /// Thêm giá trị X vào trước giá trị chẵn đầu tiên trong danh sách liên kết.
        /// </summary>
        /// <param name="X">Giá trị cần thêm vào danh sách trước giá trị chẵn đầu tiên.</param>
        public void AddBeforeEvenFirst(T X)
        {
            if (X == null) return;
            Node<T> newNode = new Node<T>(X);
            if (First == null)
            {
                First = newNode;
                return;
            }
            Node<T> curNode = First;
            Node<T> prevNode = null;
            while (curNode != null)
            {
                if (curNode.Value is int && (int)(object)curNode.Value % 2 == 0)
                    break;
                prevNode = curNode;
                curNode = curNode.Next;
            }
            if (curNode != null)
            {
                newNode.Next = curNode;
                if (prevNode != null)
                    prevNode.Next = newNode;
                else
                    First = newNode;
                Console.WriteLine($"Đã thêm {X} vào trước {curNode.Value}.");
            }
            else
                Console.WriteLine("Không có số chẵn trong danh sách liên kết.");
        }

        // 9. Thêm giá trị X vào sau giá trị chẵn đầu tiên trong dslk
        /// <summary>
        /// Thêm giá trị X vào sau giá trị chẵn đầu tiên trong danh sách liên kết.
        /// </summary>
        /// <param name="X">Giá trị cần thêm vào danh sách sau giá trị chẵn đầu tiên.</param>
        public void AddAfterEvenFirst(T X)
        {
            if (X == null) return;
            Node<T> newNode = new Node<T>(X);
            if (First == null)
            {
                First = newNode;
                return;
            }
            Node<T> curNode = First;
            while (curNode != null)
            {
                if (curNode.Value is int && (int)(object)curNode.Value % 2 == 0)
                    break;
                curNode = curNode.Next;
            }
            if (curNode != null)
            {
                newNode.Next = curNode.Next;
                curNode.Next = newNode;
                Console.WriteLine($"Đã thêm {X} vào sau {curNode.Value}.");
            }
            else
                Console.WriteLine("Không có số chẵn trong danh sách liên kết.");
        }

        // 10. Thêm giá trị X vào trước giá trị lẻ sau cùng trong dslk
        /// <summary>
        /// Thêm giá trị X vào trước giá trị lẻ sau cùng trong danh sách liên kết.
        /// </summary>
        /// <param name="X">Giá trị cần thêm vào danh sách trước giá trị lẻ sau cùng.</param>
        public void AddBeforeOddLast(T X)
        {
            if (X == null) return;
            Node<T> newNode = new Node<T>(X);
            if (First == null)
            {
                First = newNode;
                return;
            }

            Node<T> curNode = First;
            Node<T> oddNode = null;
            Node<T> prevNode = null;
            Node<T> lastOddPrevNode = null;
            while (curNode != null)
            {
                if (curNode.Value is int && (int)(object)curNode.Value % 2 != 0)
                {
                    oddNode = curNode;
                    lastOddPrevNode = prevNode;
                }
                prevNode = curNode;
                curNode = curNode.Next;
            }
            if (oddNode != null && lastOddPrevNode != null)
            {
                newNode.Next = oddNode;
                lastOddPrevNode.Next = newNode;
                Console.WriteLine($"Đã thêm {X} vào trước {oddNode.Value}.");
            }
            else if (oddNode == null)
                Console.WriteLine("Không có số lẻ trong danh sách liên kết.");
        }

        // 11. Thêm giá trị X vào sau giá trị lẻ sau cùng trong dslk
        /// <summary>
        /// Thêm giá trị X vào sau giá trị lẻ sau cùng trong danh sách liên kết.
        /// </summary>
        /// <param name="X">Giá trị cần thêm vào danh sách sau giá trị lẻ sau cùng.</param>
        public void AddAfterOddLast(T X)
        {
            if (X == null) return;
            Node<T> newNode = new Node<T>(X);
            if (First == null)
            {
                First = newNode;
                return;
            }

            Node<T> curNode = First;
            Node<T> oddNode = null;
            while (curNode != null)
            {
                if (curNode.Value is int && (int)(object)curNode.Value % 2 != 0)
                    oddNode = curNode;
                curNode = curNode.Next;
            }
            if (oddNode != null)
            {
                newNode.Next = oddNode.Next;
                oddNode.Next = newNode;
                Console.WriteLine($"Đã thêm {X} vào sau {oddNode.Value}.");
            }
            else
                Console.WriteLine("Không có số lẻ trong danh sách liên kết.");
        }

        // 12. Thêm giá trị X vào trước giá trị lẻ đầu tiên trong dslk
        /// <summary>
        /// Thêm giá trị X vào trước giá trị lẻ đầu tiên trong danh sách liên kết.
        /// </summary>
        /// <param name="X">Giá trị cần thêm vào danh sách trước giá trị lẻ đầu tiên.</param>
        public void AddBeforeOddFirst(T X)
        {
            if (X == null) return;
            Node<T> newNode = new Node<T>(X);
            if (First == null)
            {
                First = newNode;
                return;
            }
            Node<T> curNode = First;
            Node<T> prevNode = null;
            while (curNode != null)
            {
                if (curNode.Value is int && (int)(object)curNode.Value % 2 != 0)
                    break;
                prevNode = curNode;
                curNode = curNode.Next;
            }
            if (curNode != null)
            {
                newNode.Next = curNode;
                if (prevNode != null)
                    prevNode.Next = newNode;
                else
                    First = newNode;
                Console.WriteLine($"Đã thêm {X} vào trước {curNode.Value}.");
            }
            else
                Console.WriteLine("Không có số lẻ trong danh sách liên kết.");
        }

        // 13. Thêm giá trị X vào sau giá trị lẻ đầu tiên trong dslk
        /// <summary>
        /// Thêm giá trị X vào sau giá trị lẻ đầu tiên trong danh sách liên kết.
        /// </summary>
        /// <param name="X">Giá trị cần thêm vào danh sách sau giá trị lẻ đầu tiên.</param>
        public void AddAfterOddFirst(T X)
        {
            if (X == null) return;
            Node<T> newNode = new Node<T>(X);
            if (First == null)
            {
                First = newNode;
                return;
            }
            Node<T> curNode = First;
            while (curNode != null)
            {
                if (curNode.Value is int && (int)(object)curNode.Value % 2 != 0)
                    break;
                curNode = curNode.Next;
            }
            if (curNode != null)
            {
                newNode.Next = curNode.Next;
                curNode.Next = newNode;
                Console.WriteLine($"Đã thêm {X} vào sau {curNode.Value}.");
            }
            else
                Console.WriteLine("Không có số lẻ trong danh sách liên kết.");
        }

        // 14. Thêm X vào trước giá trị nhỏ nhất sau cùng trong dslk
        /// <summary>
        /// Thêm giá trị X vào trước giá trị nhỏ nhất sau cùng trong danh sách liên kết.
        /// </summary>
        /// <param name="X">Giá trị cần thêm vào danh sách trước giá trị nhỏ nhất sau cùng.</param>
        public void AddBeforeMinLast(T X)
        {
            if (X == null) return;
            Node<T> newNode = new Node<T>(X);
            if (First == null)
            {
                First = newNode;
                return;
            }
            Node<T> curNode = First;
            Node<T> minNode = null;
            Node<T> prevNode = null;
            Node<T> lastMinPrevNode = null;
            while (curNode != null)
            {
                if (curNode.Value is IComparable && (minNode == null || ((IComparable)curNode.Value).CompareTo(minNode.Value) < 0))
                {
                    minNode = curNode;
                    lastMinPrevNode = prevNode;
                }
                prevNode = curNode;
                curNode = curNode.Next;
            }
            if (minNode != null && lastMinPrevNode != null)
            {
                newNode.Next = minNode;
                lastMinPrevNode.Next = newNode;
                Console.WriteLine($"Đã thêm {X} vào trước {minNode.Value}.");
            }
            else if (minNode == null)
                Console.WriteLine("Không có số trong danh sách liên kết.");
        }

        // 15. Thêm X vào sau giá trị nhỏ nhất sau cùng trong dslk
        /// <summary>
        /// Thêm giá trị X vào sau giá trị nhỏ nhất sau cùng trong danh sách liên kết.
        /// </summary>
        /// <param name="X">Giá trị cần thêm vào danh sách sau giá trị nhỏ nhất sau cùng.</param>
        public void AddAfterMinLast(T X)
        {
            if (X == null) return;
            Node<T> newNode = new Node<T>(X);
            if (First == null)
            {
                First = newNode;
                return;
            }
            Node<T> curNode = First;
            Node<T> minNode = null;
            while (curNode != null)
            {
                if (curNode.Value is IComparable && (minNode == null || ((IComparable)curNode.Value).CompareTo(minNode.Value) < 0))
                    minNode = curNode;
                curNode = curNode.Next;
            }
            if (minNode != null)
            {
                newNode.Next = minNode.Next;
                minNode.Next = newNode;
                Console.WriteLine($"Đã thêm {X} vào sau {minNode.Value}.");
            }
            else
                Console.WriteLine("Không có số trong danh sách liên kết.");
        }

        // 16. Thêm X vào trước giá trị nhỏ nhất đầu tiên trong dslk
        /// <summary>
        /// Thêm giá trị X vào trước giá trị nhỏ nhất đầu tiên trong danh sách liên kết.
        /// </summary>
        /// <param name="X">Giá trị cần thêm vào danh sách trước giá trị nhỏ nhất đầu tiên.</param>
        public void AddBeforeMinFirst(T X)
        {
            if (X == null) return;
            Node<T> newNode = new Node<T>(X);
            if (First == null)
            {
                First = newNode;
                return;
            }
            Node<T> curNode = First;
            Node<T> prevNode = null;
            while (curNode != null)
            {
                if (curNode.Value is IComparable && ((IComparable)curNode.Value).CompareTo(newNode.Value) < 0)
                    break;
                prevNode = curNode;
                curNode = curNode.Next;
            }
            if (curNode != null)
            {
                newNode.Next = curNode;
                if (prevNode != null)
                    prevNode.Next = newNode;
                else
                    First = newNode;
                Console.WriteLine($"Đã thêm {X} vào trước {curNode.Value}.");
            }
            else
                Console.WriteLine("Không có số trong danh sách liên kết.");
        }

        // 17. Thêm X vào sau giá trị nhỏ nhất đầu tiên trong dslk
        /// <summary>
        /// Thêm giá trị X vào sau giá trị nhỏ nhất đầu tiên trong danh sách liên kết.
        /// </summary>
        /// <param name="X">Giá trị cần thêm vào danh sách sau giá trị nhỏ nhất đầu tiên.</param>
        public void AddAfterMinFirst(T X)
        {
            if (X == null) return;
            Node<T> newNode = new Node<T>(X);
            if (First == null)
            {
                First = newNode;
                return;
            }
            Node<T> curNode = First;
            while (curNode != null)
            {
                if (curNode.Value is IComparable && ((IComparable)curNode.Value).CompareTo(newNode.Value) < 0)
                    break;
                curNode = curNode.Next;
            }
            if (curNode != null)
            {
                newNode.Next = curNode.Next;
                curNode.Next = newNode;
                Console.WriteLine($"Đã thêm {X} vào sau {curNode.Value}.");
            }
            else
                Console.WriteLine("Không có số trong danh sách liên kết.");
        }

        // 18. Thêm X vào trước giá trị lớn nhất sau cùng trong dslk
        /// <summary>
        /// Thêm giá trị X vào trước giá trị lớn nhất sau cùng trong danh sách liên kết.
        /// </summary>
        /// <param name="X">Giá trị cần thêm vào danh sách trước giá trị lớn nhất sau cùng.</param>
        public void AddBeforeMaxLast(T X)
        {
            if (X == null) return;
            Node<T> newNode = new Node<T>(X);
            if (First == null)
            {
                First = newNode;
                return;
            }
            Node<T> curNode = First;
            Node<T> maxNode = null;
            Node<T> prevNode = null;
            Node<T> lastMaxPrevNode = null;
            while (curNode != null)
            {
                if (curNode.Value is IComparable && (maxNode == null || ((IComparable)curNode.Value).CompareTo(maxNode.Value) > 0))
                {
                    maxNode = curNode;
                    lastMaxPrevNode = prevNode;
                }
                prevNode = curNode;
                curNode = curNode.Next;
            }
            if (maxNode != null && lastMaxPrevNode != null)
            {
                newNode.Next = maxNode;
                lastMaxPrevNode.Next = newNode;
                Console.WriteLine($"Đã thêm {X} vào trước {maxNode.Value}.");
            }
            else if (maxNode == null)
                Console.WriteLine("Không có số trong danh sách liên kết.");
        }

        // 19. Thêm X vào sau giá trị lớn nhất sau cùng trong dslk
        /// <summary>
        /// Thêm giá trị X vào sau giá trị lớn nhất sau cùng trong danh sách liên kết.
        /// </summary>
        /// <param name="X">Giá trị cần thêm vào danh sách sau giá trị lớn nhất sau cùng.</param>
        public void AddAfterMaxLast(T X)
        {
            if (X == null) return;
            Node<T> newNode = new Node<T>(X);
            if (First == null)
            {
                First = newNode;
                return;
            }
            Node<T> curNode = First;
            Node<T> maxNode = null;
            while (curNode != null)
            {
                if (curNode.Value is IComparable && (maxNode == null || ((IComparable)curNode.Value).CompareTo(maxNode.Value) > 0))
                    maxNode = curNode;
                curNode = curNode.Next;
            }
            if (maxNode != null)
            {
                newNode.Next = maxNode.Next;
                maxNode.Next = newNode;
                Console.WriteLine($"Đã thêm {X} vào sau {maxNode.Value}.");
            }
            else
                Console.WriteLine("Không có số trong danh sách liên kết.");
        }

        // 20. Thêm X vào trước giá trị lớn nhất đầu tiên trong dslk
        /// <summary>
        /// Thêm giá trị X vào trước giá trị lớn nhất đầu tiên trong danh sách liên kết.
        /// </summary>
        /// <param name="X">Giá trị cần thêm vào danh sách trước giá trị lớn nhất đầu tiên.</param>
        public void AddBeforeMaxFirst(T X)
        {
            if (X == null) return;
            Node<T> newNode = new Node<T>(X);
            if (First == null)
            {
                First = newNode;
                return;
            }
            Node<T> curNode = First;
            Node<T> prevNode = null;
            while (curNode != null)
            {
                if (curNode.Value is IComparable && ((IComparable)curNode.Value).CompareTo(newNode.Value) > 0)
                    break;
                prevNode = curNode;
                curNode = curNode.Next;
            }
            if (curNode != null)
            {
                newNode.Next = curNode;
                if (prevNode != null)
                    prevNode.Next = newNode;
                else
                    First = newNode;
                Console.WriteLine($"Đã thêm {X} vào trước {curNode.Value}.");
            }
            else
                Console.WriteLine("Không có số trong danh sách liên kết.");
        }

        // 21. Thêm X vào sau giá trị lớn nhất đầu tiên trong dslk
        /// <summary>
        /// Thêm giá trị X vào sau giá trị lớn nhất đầu tiên trong danh sách liên kết.
        /// </summary>
        /// <param name="X">Giá trị cần thêm vào danh sách sau giá trị lớn nhất đầu tiên.</param>
        public void AddAfterMaxFirst(T X)
        {
            if (X == null) return;
            Node<T> newNode = new Node<T>(X);
            if (First == null)
            {
                First = newNode;
                return;
            }
            Node<T> curNode = First;
            while (curNode != null)
            {
                if (curNode.Value is IComparable && ((IComparable)curNode.Value).CompareTo(newNode.Value) > 0)
                    break;
                curNode = curNode.Next;
            }
            if (curNode != null)
            {
                newNode.Next = curNode.Next;
                curNode.Next = newNode;
                Console.WriteLine($"Đã thêm {X} vào sau {curNode.Value}.");
            }
            else
                Console.WriteLine("Không có số trong danh sách liên kết.");
        }














        // In dslk
        /// <summary>
        /// In danh sách liên kết đơn.
        /// </summary>
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
