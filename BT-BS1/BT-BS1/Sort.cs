using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_BS1
{
    public class Sort
    {
        public List<Student> students = new List<Student>();

        public void SelectionSortHoTen()
        {
            int n = students.Count;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (string.Compare(students[j].HoTen, students[minIndex].HoTen) < 0)
                        minIndex = j;
                }
                if (minIndex != i)
                {
                    (students[i], students[minIndex]) = (students[minIndex], students[i]);
                }
            }
        }

        public void BubbleSortMaSV()
        {
            int n = students.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (string.Compare(students[j].MaSinhVien, students[j + 1].MaSinhVien) > 0)
                    {
                        (students[j], students[j + 1]) = (students[j + 1], students[j]);
                    }
                }
            }
        }

        public void QuickSortRecursiveDTB(int left, int right)
        {
            if (left < right)
            {
                double pivot = students[left].DiemTrungBinh;
                int i = left, j = right;

                while (i <= j)
                {
                    while (students[i].DiemTrungBinh < pivot) i++;
                    while (students[j].DiemTrungBinh > pivot) j--;

                    if (i <= j)
                    {
                        (students[i], students[j]) = (students[j], students[i]);
                        i++;
                        j--;
                    }
                }

                QuickSortRecursiveDTB(left, j);
                QuickSortRecursiveDTB(i, right);
            }
        }
    }
}
