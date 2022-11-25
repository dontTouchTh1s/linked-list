using System.Collections;
using System.Collections.Generic;

namespace LinkedList
{
    public class LinkedList
    {
        private readonly List<Student> _list;
        public LinkedList()
        {
            _list = new List<Student>();
        }

        public int Length => _list.Count;

        public void Add(Student item)
        {
            var index = 0;
            for (var j = 0; j < _list.Count; j++)
            {
                if (item.GPA < _list[j].GPA)
                {
                    index = j + 1;
                    continue;
                }

                index = j;
                break;
            }
            _list.Insert(index, item);
        }

        public Student Find(string number)
        {
            for (var index = 0; index < _list.Count; index++)
            {
                var item = _list[index];
                if (item.Number == number)
                    return item;
            }

            return null;
        }

        public Student this[int index]
        {
            get => _list[index];
            set => _list[index] = value;
        }
    }
}