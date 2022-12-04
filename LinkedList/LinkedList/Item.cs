namespace LinkedList.LinkedList
{
    public class Item
    {
        public Student Info;
        public Item Next;

        public Item(Student info)
        {
            Next = null;
            Info = info;
        }
    }
}