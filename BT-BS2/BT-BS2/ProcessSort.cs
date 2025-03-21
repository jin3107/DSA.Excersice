using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_BS2
{
    public class ProcessSort
    {
        private List<Student> students;

        public ProcessSort(List<Student> students)
        {
            this.students = students;
        }

        public void InterchangeSortAscending()
        {
            int n = students.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (students[i].GetAverage() > students[j].GetAverage())
                    {
                        (students[i], students[j]) = (students[j], students[i]);
                    }
                }
            }
        }

        public void InterchangeSortDescending()
        {
            int n = students.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (students[i].GetAverage() < students[j].GetAverage())
                    {
                        (students[i], students[j]) = (students[j], students[i]);
                    }
                }
            }
        }

        public void BullbleSortAscending()
        {
            int n = students.Count;
            for (int i = n - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (students[j].GetAverage() < students[j - 1].GetAverage())
                    {
                        (students[j], students[j - 1]) = (students[j - 1], students[j]);
                    }
                }
            }
        }

        public void BullbleSortDescending()
        {
            int n = students.Count;
            for (int i = n - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (students[j].GetAverage() > students[j - 1].GetAverage())
                    {
                        (students[j], students[j - 1]) = (students[j - 1], students[j]);
                    }
                }
            }
        }

        public void ShakerSortAscending()
        {
            int n = students.Count;
            int left = 0;
            int right = n - 1;
            while (left <= right)
            {
                for (int i = left; i < right; i++)
                {
                    if (students[i].GetAverage() > students[i + 1].GetAverage())
                    {
                        (students[i], students[i + 1]) = (students[i + 1], students[i]);
                    }
                }
                right--;
                for (int i = right; i > left; i--)
                {
                    if (students[i].GetAverage() < students[i - 1].GetAverage())
                    {
                        (students[i], students[i - 1]) = (students[i - 1], students[i]);
                    }
                }
                left++;
            }
        }

        public void ShakerSortDescending()
        {
            int n = students.Count;
            int left = 0;
            int right = n - 1;
            while (left <= right)
            {
                for (int i = left; i < right; i++)
                {
                    if (students[i].GetAverage() < students[i + 1].GetAverage())
                    {
                        (students[i], students[i + 1]) = (students[i + 1], students[i]);
                    }
                }
                right--;
                for (int i = right; i > left; i--)
                {
                    if (students[i].GetAverage() > students[i - 1].GetAverage())
                    {
                        (students[i], students[i - 1]) = (students[i - 1], students[i]);
                    }
                }
                left++;
            }
        }

        public void SelectionSortAscending()
        {
            int n = students.Count;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (students[j].GetAverage() < students[minIndex].GetAverage())
                        minIndex = j;
                }
                if (minIndex != i)
                {
                    (students[i], students[minIndex]) = (students[minIndex], students[i]);
                }
            }
        }

        public void SelectionSortDescending()
        {
            int n = students.Count;
            for (int i = 0; i < n - 1; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (students[j].GetAverage() > students[maxIndex].GetAverage())
                        maxIndex = j;
                }
                if (maxIndex != i)
                {
                    (students[i], students[maxIndex]) = (students[maxIndex], students[i]);
                }
            }
        }

        public void InsertionSortAscending()
        {
            int n = students.Count;
            for (int i = 1; i < n; i++)
            {
                Student key = students[i];
                int j = i - 1;
                while (j >= 0 && students[j].GetAverage() > key.GetAverage())
                {
                    students[j + 1] = students[j];
                    j--;
                }
                students[j + 1] = key;
            }
        }

        public void InsertionSortDescending()
        {
            int n = students.Count;
            for (int i = 1; i < n; i++)
            {
                Student key = students[i];
                int j = i - 1;
                while (j >= 0 && students[j].GetAverage() < key.GetAverage())
                {
                    students[j + 1] = students[j];
                    j--;
                }
                students[j + 1] = key;
            }
        }

        public void QuickSortAscending(int low, int high)
        {
            if (low < high)
            {
                int pi = PartitionAscending(low, high);
                QuickSortAscending(low, pi - 1);
                QuickSortAscending(pi + 1, high);
            }
        }

        private int PartitionAscending(int low, int high)
        {
            double pivot = students[high].GetAverage();
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (students[j].GetAverage() < pivot)
                {
                    i++;
                    (students[i], students[j]) = (students[j], students[i]);
                }
            }
            (students[i + 1], students[high]) = (students[high], students[i + 1]);
            return i + 1;
        }

        public void QuickSortDescending(int low, int high)
        {
            if (low < high)
            {
                int pi = PartitionDescending(low, high);
                QuickSortDescending(low, pi - 1);
                QuickSortDescending(pi + 1, high);
            }
        }

        private int PartitionDescending(int low, int high)
        {
            double pivot = students[high].GetAverage();
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (students[j].GetAverage() > pivot)
                {
                    i++;
                    (students[i], students[j]) = (students[j], students[i]);
                }
            }
            (students[i + 1], students[high]) = (students[high], students[i + 1]);
            return i + 1;
        }
    }
}
