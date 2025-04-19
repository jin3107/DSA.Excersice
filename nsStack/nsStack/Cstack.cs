using System;
using System.Collections;

namespace nsStack
{
    public class Cstack
    {
        private int topIndex;
        private ArrayList list;

        public Cstack()
        {
            topIndex = -1;
            list = new ArrayList();
        }

        public void Push(Object item)
        {
            list.Add(item);
            topIndex++;
        }

        public Object Pop()
        {
            Object obj = list[topIndex];
            list.RemoveAt(topIndex);
            topIndex--;
            return obj;
        }

        public object Peek()
        {
            return list[topIndex];
        }

        public int Count
        {
            get { return list.Count; }
        }

        public void Clear()
        {
            list.Clear();
            topIndex = -1;
        }
    }
}
