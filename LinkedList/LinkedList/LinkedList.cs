using System;

namespace LinkedList.LinkedList
{
    public class LinkedList
    { 
        private Item _start;

        public bool Delete(string number)
        {
            Item current = _start;
            Item previos = _start;
            if (number == _start.Info.Number)
            {
                _start =  current.Next;
                return true;
            }
            else
            {
                previos = current;
                current = current.Next;
                while (current != null && number != current.Info.Number)
                {
                    previos = current;
                    current = current.Next;
                }
                if (current == null)
                    return false;
                else
                {
                    previos.Next = current.Next;
                    return true;
                }
            }
        }

        public void Add(Student student)
        {
            var item = new Item(student);
            if (_start == null)
            {
                _start = item;
            }
            else if (student.GPA < _start.Info.GPA)
            {
                item.Next = _start;
                _start = item;
            }
            else
            {
                Item p1 = _start;
                Item p2 = p1.Next;
                while (p2 != null && p2.Info.GPA < item.Info.GPA)
                {
                    p1 = p2;
                    p2 = p2.Next;
                }

                p1.Next = item;
                item.Next = p2;

            }
        }

        public Student Find(string number)
        {
            Item current = _start;
            while (current != null && current.Info.Number != number)
            {
                current = current.Next;
            }
            if (current == null)
            {
                return null;
            }
            return current.Info;
        }

        public void Print()
        {
            Item current = _start;
            while (current != null)
            {
                Console.WriteLine (current.Info);
                current = current.Next;
            }
        }
    }
}