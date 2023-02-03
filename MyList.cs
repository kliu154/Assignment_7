using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    public class MyList<T>
    {
        private List<T> list;

        public MyList()
        {
            list = new List<T>();
        }

        public void Add(T element)
        {
            list.Add(element);
        }

        public T Remove(int index)
        {
            if (index < 0 || index >= list.Count)
            {
                throw new IndexOutOfRangeException("Index is out of range!");
            }

            T element = list[index];
            list.RemoveAt(index);
            return element;
        }

        public bool Contains(T element)
        {
            return list.Contains(element);
        }

        public void Clear()
        {
            list.Clear();
        }

        public void InsertAt(T element, int index)
        {
            if (index < 0 || index >= list.Count)
            {
                throw new IndexOutOfRangeException("Index is out of range!");
            }

            list.Insert(index, element);
        }

        public void DeleteAt(int index) 
        {
            if (index < 0 || index >= list.Count)
            {
                throw new IndexOutOfRangeException("Index is out of range!");
            }

            list.RemoveAt(index);
        }

        public T Find(int index)
        {
            if (index < 0 || index >= list.Count)
            {
                throw new IndexOutOfRangeException("Index is out of range!");
            }

            return list[index];
        }
    }
}
