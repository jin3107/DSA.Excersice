namespace BT_BS4
{
    /// <summary>
    /// Lớp Node cho danh sách liên kết đơn.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {
        public T Value;
        public Node<T> Next;

        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }
}