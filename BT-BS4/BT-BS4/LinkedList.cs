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

        // 4. Thêm giá trị X vào đầu trong dslk
        public void AddXFirst(object X)
        {
            if (X == null) return;
            Node newNode = new Node(X);
            newNode.Next = First;
            First = newNode;
        }

        // 5. Thêm giá trị X vào cuối trong dslk
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
            while (curNode != null)
            {
                if ((int)curNode.Value % 2 == 0)
                    break;
                prevNode = curNode;
                curNode = curNode.Next;
            }
            if (curNode == null)
            {
                Console.WriteLine("Không có giá trị chẵn trong danh sách");
                return;
            }
            Node newNode = new Node(X);
            newNode.Next = curNode;
            if (prevNode == null)
                First = newNode;
            else
                prevNode.Next = newNode;
        }

        // 9. Thêm giá trị X vào sau giá trị chẵn đầu tiên trong dslk
        public void AddXAfterEvenFirst(object X)
        {
            if (X == null) return;
            if (First == null)
            {
                Console.WriteLine("Danh sách rỗng");
                return;
            }
            Node curNode = First;
            while (curNode != null)
            {
                if ((int)curNode.Value % 2 == 0)
                    break;
                curNode = curNode.Next;
            }
            Node newNode = new Node(X);
            if (curNode == null)
            {
                Console.WriteLine("Không có giá trị chẵn trong danh sách");
                return;
            }
            newNode.Next = curNode.Next;
            curNode.Next = newNode;
        }

        // 10. Thêm giá trị X vào trước giá trị lẻ sau cùng trong dslk
        public void AddXBeforeOddLast(object X)
        {
            if (X == null) return;
            if (First == null)
            {
                Console.WriteLine("Danh sách rỗng");
                return;
            }
            Node curNode = First;
            Node prevNode = null;
            Node lastOddNode = null;
            Node lastOddPrevNode = null;
            while (curNode != null)
            {
                if ((int)curNode.Value % 2 != 0)
                {
                    lastOddNode = curNode;
                    lastOddPrevNode = prevNode;
                }
                prevNode = curNode;
                curNode = curNode.Next;
            }
            if (lastOddNode == null)
            {
                Console.WriteLine("Không có giá trị lẻ trong danh sách");
                return;
            }
            Node newNode = new Node(X);
            if (lastOddPrevNode == null)
            {
                newNode.Next = First;
                First = newNode;
            }
            else
            {
                newNode.Next = lastOddNode;
                lastOddPrevNode.Next = newNode;
            }
        }

        // 11. Thêm giá trị X vào sau giá trị lẻ sau cùng trong dslk
        public void AddXAfterOddLast(object X)
        {
            if (X == null) return;
            if (First == null)
            {
                Console.WriteLine("Danh sách rỗng");
                return;
            }
            Node curNode = First;
            Node lastOddNode = null;
            while (curNode != null)
            {
                if ((int)curNode.Value % 2 != 0)
                    lastOddNode = curNode;
                curNode = curNode.Next;
            }
            if (lastOddNode == null)
            {
                Console.WriteLine("Không có giá trị lẻ trong danh sách");
                return;
            }
            Node newNode = new Node(X);
            newNode.Next = lastOddNode.Next;
            lastOddNode.Next = newNode;
        }

        // 12. Thêm giá trị X vào trước giá trị lẻ đầu tiên trong dslk
        public void AddXBeforeOddFirst(object X)
        {
            if (X == null) return;
            if (First == null)
            {
                Console.WriteLine("Danh sách rỗng");
                return;
            }
            Node curNode = First;
            Node prevNode = null;
            while (curNode != null)
            {
                if ((int)curNode.Value % 2 != 0)
                    break;
                prevNode = curNode;
                curNode = curNode.Next;
            }
            if (curNode == null)
            {
                Console.WriteLine("Không có giá trị lẻ trong danh sách");
                return;
            }
            Node newNode = new Node(X);
            newNode.Next = curNode;
            if (prevNode == null)
                First = newNode;
            else
                prevNode.Next = newNode;
        }

        // 13. Thêm giá trị X vào sau giá trị lẻ đầu tiên trong dslk
        public void AddXAfterOddFirst(object X)
        {
            if (X == null) return;
            if (First == null)
            {
                Console.WriteLine("Danh sách rỗng");
                return;
            }
            Node curNode = First;
            while (curNode != null)
            {
                if ((int)curNode.Value % 2 != 0)
                    break;
                curNode = curNode.Next;
            }
            Node newNode = new Node(X);
            if (curNode == null)
            {
                Console.WriteLine("Không có giá trị lẻ trong danh sách");
                return;
            }
            newNode.Next = curNode.Next;
            curNode.Next = newNode;
        }

        // 14. Thêm giá trị X vào trước giá trị nhỏ nhất sau cùng trong dslk
        public void AddXBeforeMinLast(object X)
        {
            if (X == null) return;
            if (First == null)
            {
                Console.WriteLine("Danh sách rỗng");
                return;
            }
            Node curNode = First;
            Node prevNode = null;
            Node minNode = First;
            Node minPrevNode = null;
            while (curNode != null)
            {
                if ((int)curNode.Value <= (int)minNode.Value)
                {
                    minNode = curNode;
                    minPrevNode = prevNode;
                }
                prevNode = curNode;
                curNode = curNode.Next;
            }
            Node newNode = new Node(X);
            newNode.Next = minNode;
            if (minPrevNode == null)
                First = newNode;
            else
                minPrevNode.Next = newNode;
        }

        // 15. Thêm giá trị X vào sau giá trị nhỏ nhất sau cùng trong dslk
        public void AddXAfterMinLast(object X)
        {
            if (X == null) return;
            if (First == null)
            {
                Console.WriteLine("Danh sách rỗng");
                return;
            }
            Node curNode = First;
            Node minNode = First;
            while (curNode != null)
            {
                if ((int)curNode.Value <= (int)minNode.Value)
                    minNode = curNode;
                curNode = curNode.Next;
            }
            Node newNode = new Node(X);
            newNode.Next = minNode.Next;
            minNode.Next = newNode;
        }

        // 16. Thêm giá trị X vào trước giá trị nhỏ nhất đầu tiên trong dslk
        public void AddXBeforeMinFirst(object X)
        {
            if (X == null) return;
            if (First == null)
            {
                Console.WriteLine("Danh sách rỗng");
                return;
            }
            Node curNode = First;
            Node prevNode = null;
            Node minNode = First;
            Node minPrevNode = null;
            while (curNode != null)
            {
                if ((int)curNode.Value < (int)minNode.Value)
                {
                    minNode = curNode;
                    minPrevNode = prevNode;
                }
                prevNode = curNode;
                curNode = curNode.Next;
            }
            Node newNode = new Node(X);
            newNode.Next = minNode;
            if (minPrevNode == null)
                First = newNode;
            else
                minPrevNode.Next = newNode;
        }

        // 17. Thêm giá trị X vào sau giá trị nhỏ nhất đầu tiên trong dslk
        public void AddXAfterMinFirst(object X)
        {
            if (X == null) return;
            if (First == null)
            {
                Console.WriteLine("Danh sách rỗng");
                return;
            }

            Node curNode = First;
            Node prevNode = null;
            Node minNode = First;
            while (curNode != null)
            {
                if ((int)curNode.Value < (int)minNode.Value)
                    minNode = curNode;
                prevNode = curNode;
                curNode = curNode.Next;
            }
            Node newNode = new Node(X);
            newNode.Next = minNode.Next;
            minNode.Next = newNode;
        }

        // 18. Thêm giá trị X vào trước giá trị lớn nhất sau cùng trong dslk
        public void AddXBeforeMaxLast(object X)
        {
            if (X == null) return;
            if (First == null)
            {
                Console.WriteLine("Danh sách rỗng");
                return;
            }
            Node curNode = First;
            Node prevNode = null;
            Node maxNode = First;
            Node maxPrevNode = null;
            while (curNode != null)
            {
                if ((int)curNode.Value >= (int)maxNode.Value)
                {
                    maxNode = curNode;
                    maxPrevNode = prevNode;
                }
                prevNode = curNode;
                curNode = curNode.Next;
            }
            Node newNode = new Node(X);
            newNode.Next = maxNode;
            if (maxPrevNode == null)
                First = newNode;
            else
                maxPrevNode.Next = newNode;
        }

        // 19. Thêm giá trị X vào sau giá trị lớn nhất sau cùng trong dslk
        public void AddXAfterMaxLast(object X)
        {
            if (X == null) return;
            if (First == null)
            {
                Console.WriteLine("Danh sách rỗng");
                return;
            }
            Node curNode = First;
            Node maxNode = First;
            while (curNode != null)
            {
                if ((int)curNode.Value >= (int)maxNode.Value)
                    maxNode = curNode;
                curNode = curNode.Next;
            }
            Node newNode = new Node(X);
            newNode.Next = maxNode.Next;
            maxNode.Next = newNode;
        }

        // 20. Thêm giá trị X vào trước giá trị lớn nhất đầu tiên trong dslk
        public void AddXBeforeMaxFirst(object X)
        {
            if (X == null) return;
            if (First == null)
            {
                Console.WriteLine("Danh sách rỗng");
                return;
            }
            Node curNode = First;
            Node prevNode = null;
            Node maxNode = First;
            Node maxPrevNode = null;
            while (curNode != null)
            {
                if ((int)curNode.Value > (int)maxNode.Value)
                {
                    maxNode = curNode;
                    maxPrevNode = prevNode;
                }
                prevNode = curNode;
                curNode = curNode.Next;
            }
            Node newNode = new Node(X);
            newNode.Next = maxNode;
            if (maxPrevNode == null)
                First = newNode;
            else
                maxPrevNode.Next = newNode;
        }

        // 21. Thêm giá trị X vào sau giá trị lớn nhất đầu tiên trong dslk
        public void AddXAfterMaxFirst(object X)
        {
            if (X == null) return;
            if (First == null)
            {
                Console.WriteLine("Danh sách rỗng");
                return;
            }

            Node curNode = First;
            Node prevNode = null;
            Node maxNode = First;
            while (curNode != null)
            {
                if ((int)curNode.Value > (int)maxNode.Value)
                    maxNode = curNode;
                prevNode = curNode;
                curNode = curNode.Next;
            }
            Node newNode = new Node(X);
            newNode.Next = maxNode.Next;
            maxNode.Next = newNode;
        }

        // 22. Xóa giá trị X trong dslk
        public void Remove(object X)
        {
            if ((First == null || (X == null))) return;
            if (First.Value.Equals(X))
            {
                First = First.Next;
                return;
            }

            Node curNode = First;
            while ((curNode.Next != null) && !curNode.Next.Value.Equals(X))
                curNode = curNode.Next;
            if (curNode.Next != null)
                curNode.Next = curNode.Next.Next;
            Console.WriteLine($"Đã xóa thành công {X}");
        }

        // 23. Xóa hết tất cả các phần tử trong dslk
        public void RemoveAll()
        {
            First = null;
            Console.WriteLine("Đã xóa tất cả các phần tử trong danh sách.");
        }

        // 24. Xóa phần tử kề sau phần tử Q trong dslk
        public void RemoveAfter(object Q)
        {
            if (First == null || Q == null) return;
            Node curNode = First;
            if (First == Q)
            {
                First = First.Next;
                return;
            }
            while (curNode != null && (int)curNode.Value != (int)Q)
                curNode = curNode.Next;
            if (curNode != null && curNode.Next != null)
                curNode.Next = curNode.Next.Next;
        }

        // 25. Xóa phần tử kề trước phần tử Q trong dslk
        public void RemoveBefore(object Q)
        {
            if (First == null || Q == null || (int)First.Value == (int)Q) return;
            Node cur = First;
            Node prev = null;
            Node prePrev = null;
            while (cur != null && (int)cur.Value != (int)Q)
            {
                prePrev = prev;
                prev = cur;
                cur = cur.Next;
            }
            if (prev == null) return;
            if (prePrev == null)
                First = cur;
            else
                prePrev.Next = cur;
        }

        // 26. Xóa phần tử đầu tiên trong dslk
        public void RemoveFirst()
        {
            if (First == null)
                return;
            First = First.Next;
            Console.WriteLine("Đã xóa phần tử đầu tiên trong danh sách.");
        }

        // 27. Xóa phần tử cuối cùng trong dslk
        public void RemoveLast()
        {
            if (First == null) return;
            if (First.Next == null)
            {
                First = null;
                Console.WriteLine("Đã xóa phần tử cuối cùng trong danh sách.");
                return;
            }
            Node curNode = First;
            while (curNode.Next.Next != null)
                curNode = curNode.Next;
            curNode.Next = null;
            Console.WriteLine("Đã xóa phần tử cuối cùng trong danh sách.");
        }

        // 28. Xóa phần tử ở giữa trong dslk
        public void RemoveCenter()
        {
            if (First == null) return;
            Node curNode = First;
            Node prevNode = null;
            int count = 0;
            while (curNode != null)
            {
                count++;
                curNode = curNode.Next;
            }
            curNode = First;
            int mid = count / 2;
            for (int i = 0; i < mid; i++)
            {
                prevNode = curNode;
                curNode = curNode.Next;
            }
            if (prevNode != null)
                prevNode.Next = curNode.Next;
        }

        // 29. Xóa phần tử chẵn đầu tiên trong dslk
        public void RemoveEvenFirst()
        {
            if (First == null) return;
            Node curNode = First;
            Node prevNode = null;
            while (curNode != null)
            {
                if ((int)curNode.Value % 2 == 0)
                    break;
                prevNode = curNode;
                curNode = curNode.Next;
            }
            if (curNode != null)
            {
                if (prevNode != null)
                    prevNode.Next = curNode.Next;
                else
                    First = curNode.Next;
                Console.WriteLine($"Đã xóa {curNode.Value}.");
            }
            else
                Console.WriteLine("Không có số chẵn trong danh sách liên kết.");
        }

        // 30. Xóa phần tử chẵn cuồi cùng trong dslk
        public void RemoveEvenLast()
        {
            if (First == null) return;
            Node cur = First, prev = null;
            Node even = null, evenPrev = null;
            while (cur != null)
            {
                if ((int)cur.Value % 2 == 0)
                {
                    even = cur;
                    evenPrev = prev;
                }
                prev = cur;
                cur = cur.Next;
            }
            if (even == null)
            {
                Console.WriteLine("Không có số chẵn.");
                return;
            }
            if (evenPrev == null)
                First = First.Next;
            else
                evenPrev.Next = even.Next;
            Console.WriteLine($"Đã xóa {even.Value}.");
        }

        // 31. Xóa phần tử lẻ đầu tiên trong dslk
        public void RemoveOddFirst()
        {
            if (First == null) return;
            Node curNode = First;
            Node prevNode = null;
            while (curNode != null)
            {
                if ((int)curNode.Value % 2 != 0)
                    break;
                prevNode = curNode;
                curNode = curNode.Next;
            }
            if (curNode != null)
            {
                if (prevNode != null)
                    prevNode.Next = curNode.Next;
                else
                    First = curNode.Next;
                Console.WriteLine($"Đã xóa {curNode.Value}.");
            }
            else
                Console.WriteLine("Không có số lẻ trong danh sách liên kết.");
        }

        // 32. Xóa phần tử lẻ cuồi cùng trong dslk
        public void RemoveOddLast()
        {
            if (First == null) return;
            Node cur = First, prev = null;
            Node odd = null, oddPrev = null;
            while (cur != null)
            {
                if ((int)cur.Value % 2 != 0)
                {
                    odd = cur;
                    oddPrev = prev;
                }
                prev = cur;
                cur = cur.Next;
            }
            if (odd == null)
            {
                Console.WriteLine("Không có số lẻ.");
                return;
            }
            if (oddPrev == null)
                First = First.Next;
            else
                oddPrev.Next = odd.Next;
            Console.WriteLine($"Đã xóa {odd.Value}.");
        }

        // 33. Xóa phần tử nhỏ nhất trong dslk
        public void RemoveMin()
        {
            if (First == null) return;
            Node cur = First;
            Node minNode = First;
            Node minPrev = null;
            Node prev = null;
            while (cur != null)
            {
                if ((int)cur.Value < (int)minNode.Value)
                {
                    minNode = cur;
                    minPrev = prev;
                }
                prev = cur;
                cur = cur.Next;
            }
            if (minPrev == null)
                First = First.Next;
            else
                minPrev.Next = minNode.Next;
            Console.WriteLine($"Đã xóa {minNode.Value}.");
        }

        // 34. Xóa phần tử nhỏ nhất đầu tiên trong dslk
        public void RemoveMinFirst()
        {
            if (First == null) return;
            Node cur = First;
            Node minNode = First;
            Node minPrev = null;
            Node prev = null;
            while (cur != null)
            {
                if ((int)cur.Value < (int)minNode.Value)
                {
                    minNode = cur;
                    minPrev = prev;
                }
                prev = cur;
                cur = cur.Next;
            }
            if (minPrev == null)
                First = First.Next;
            else
                minPrev.Next = minNode.Next;
            Console.WriteLine($"Đã xóa {minNode.Value}.");
        }

        // 35. Xóa phần tử nhỏ nhất sau cùng trong dslk
        public void RemoveMinLast()
        {
            if (First == null) return;
            Node cur = First;
            Node minNode = null;
            Node minPrev = null;
            Node prev = null;
            while (cur != null)
            {
                if (minNode == null || (int)cur.Value < (int)minNode.Value)
                {
                    minNode = cur;
                    minPrev = prev;
                }
                prev = cur;
                cur = cur.Next;
            }
            if (minNode != null)
            {
                if (minPrev == null)
                    First = First.Next;
                else
                    minPrev.Next = minNode.Next;
                Console.WriteLine($"Đã xóa {minNode.Value}.");
            }
            else
                Console.WriteLine("Không có giá trị trong danh sách.");
        }

        // 36. Xóa phần tử lớn nhất trong dslk
        public void RemoveMax()
        {
            if (First == null) return;
            Node curNode = First;
            Node maxNode = First;
            Node maxPrev = null;
            Node prev = null;
            while (curNode != null)
            {
                if ((int)curNode.Value > (int)maxNode.Value)
                {
                    maxNode = curNode;
                    maxPrev = prev;
                }
                prev = curNode;
                curNode = curNode.Next;
            }
            if (maxNode != null)
            {
                if (maxPrev == null) 
                    First = First.Next;
                else
                    maxPrev.Next = maxNode.Next;
                Console.WriteLine($"Đã xóa {maxNode.Value}.");
            }
            else
                Console.WriteLine("Không có giá trị trong danh sách.");
        }

        // 37. Xóa phần tử lớn nhất đầu tiên trong dslk
        public void RemoveMaxFirst()
        {
            if (First == null) return;
            Node curNode = First;
            Node prevNode = null;
            Node maxNode = First;
            Node maxPrev = null;
            while (curNode != null)
            {
                if ((int)curNode.Value > (int)maxNode.Value)
                {
                    maxNode = curNode;
                    maxPrev = prevNode;
                }
                prevNode = curNode;
                curNode = curNode.Next;
            }
            if (maxNode != null)
            {
                if (maxPrev == null)
                    First = maxNode.Next;
                else
                    maxPrev.Next = maxNode.Next;
                Console.WriteLine($"Đã xóa {maxNode.Value}.");
            }
            else
                Console.WriteLine("Không có giá trị trong danh sách.");
        }

        // 38. Xóa phần tử lớn nhất sau cùng trong dslk
        public void RemoveMaxLast()
        {
            if (First == null) return;
            Node curNode = First;
            Node prevNode = null;
            Node maxNode = null;
            Node maxPrev = null;
            while (curNode != null)
            {
                if (maxNode == null || (int)curNode.Value > (int)maxNode.Value)
                {
                    maxNode = curNode;
                    maxPrev = prevNode;
                }
                else if ((int)curNode.Value == (int)maxNode.Value)
                {
                    maxNode = curNode;
                    maxPrev = prevNode;
                }
                prevNode = curNode;
                curNode = curNode.Next;
            }
            if (maxNode != null)
            {
                if (maxPrev == null)
                    First = maxNode.Next;
                else
                    maxPrev.Next = maxNode.Next;
                Console.WriteLine($"Đã xóa {maxNode.Value}.");
            }
            else
                Console.WriteLine("Không có giá trị trong danh sách.");
        }

        // 39. Tìm phần tử min trong ds
        public void FindMin()
        {
            if (First == null)
            {
                Console.WriteLine("Danh sách rỗng");
                return;
            }
            Node curNode = First.Next;
            Node minNode = First;
            while (curNode != null)
            {
                if ((int)curNode.Value < (int)minNode.Value)
                    minNode = curNode;
                curNode = curNode.Next;
            }
            Console.WriteLine($"Phần tử nhỏ nhất trong danh sách là: {minNode.Value}");
        }

        // 40. Tìm phần tử min sau cùng. Dùng cho ds các int
        public void FindLastMin()
        {
            if (First == null)
            {
                Console.WriteLine("Danh sách rỗng");
                return;
            }
            Node curNode = First.Next;
            Node minNode = First;
            while (curNode != null)
            {
                if ((int)curNode.Value <= (int)minNode.Value)
                    minNode = curNode;
                curNode = curNode.Next;
            }
            Console.WriteLine($"Phần tử nhỏ nhất sau cùng là: {minNode.Value}");
        }

        // 41. Tìm phần tử min đầu tiên. Dùng cho ds các int
        public void FindFirstMin()
        {
            if (First == null)
            {
                Console.WriteLine("Danh sách rỗng");
                return;
            }
            Node curNode = First.Next;
            Node minNode = First;
            while (curNode != null)
            {
                if ((int)curNode.Value < (int)minNode.Value)
                    minNode = curNode;
                curNode = curNode.Next;
            }
            Console.WriteLine($"Phần tử nhỏ nhất đầu tiên là: {minNode.Value}");
        }

        // 42. Tìm phần tử max trong ds
        public void FindMax()
        {
            if (First == null)
            {
                Console.WriteLine("Danh sách rỗng");
                return;
            }
            Node curNode = First.Next;
            Node maxNode = First;
            while (curNode != null)
            {
                if ((int)curNode.Value > (int)maxNode.Value)
                    maxNode = curNode;
                curNode = curNode.Next;
            }
            Console.WriteLine($"Phần tử lớn nhất trong danh sách là: {maxNode.Value}");
        }

        // 43. Tìm phần tử max sau cùng. Dùng cho ds các int
        public void FindLastMax()
        {
            if (First == null)
            {
                Console.WriteLine("Danh sách rỗng");
                return;
            }
            Node curNode = First.Next;
            Node maxNode = First;
            while (curNode != null)
            {
                if ((int)curNode.Value >= (int)maxNode.Value)
                    maxNode = curNode;
                curNode = curNode.Next;
            }
            Console.WriteLine($"Phần tử lớn nhất sau cùng là: {maxNode.Value}");
        }

        // 44. Tìm phần tử max đầu tiên. Dùng cho ds các int
        public void FindFirstMax()
        {
            if (First == null)
            {
                Console.WriteLine("Danh sách rỗng");
                return;
            }
            Node curNode = First.Next;
            Node maxNode = First;
            while (curNode != null)
            {
                if ((int)curNode.Value > (int)maxNode.Value)
                    maxNode = curNode;
                curNode = curNode.Next;
            }
            Console.WriteLine($"Phần tử lớn nhất đầu tiên là: {maxNode.Value}");
        }

        // 45. Tìm phần tử là số nguyên số
        public void FindPrime()
        {
            if (First == null)
            {
                Console.WriteLine("Danh sách rỗng");
                return;
            }
            Node curNode = First;
            Node primeNode = First;
            List<int> soNguyenTo = new List<int>();
            while (curNode != null)
            {
                if (IsPrime((int)curNode.Value))
                {
                    primeNode = curNode;
                    soNguyenTo.Add((int)primeNode.Value);
                }
                curNode = curNode.Next;
            }
            Console.Write("Phần từ là số nguyên tố là: ");
            foreach (var item in soNguyenTo)
            {
                Console.Write(item + " ");
            }
        }

        private bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

    }
}
