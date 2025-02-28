using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
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
    }
}
