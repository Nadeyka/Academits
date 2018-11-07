using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class SinglyLinkedList<T>
    {
        private ListItem<T> Head { get; set; }
        private int count;

        public SinglyLinkedList(ListItem<T> head)
        {
            Head = head;
            count = 0;
        }

        public int GetListSize()
        {
            return count;
        }

        public T GetFirstElement()
        {
            return Head.Data;
        }

        public T GetElementByIndex(int index)
        {
            ListItem<T> item = Head;
            int i = 0;
            while (i < index)
            {
                item = item.Next;
                ++i;
            }
            return item.Data;
        }

        public T SetElementByIndex(int index, T newData)
        {
            ListItem<T> item = Head;
            int i = 0;
            while (i < index)
            {
                item = item.Next;
                ++i;
            }

            T oldData = item.Data;
            item.Data = newData;
            return oldData;
        }

        public void InsertElementAtBegin(T data)
        {
            ListItem<T> p = new ListItem<T>(data, Head);
            Head = p;
            count++;
        }

        public T DeleteElementAtBegin()
        {
            T deletedData = Head.Data;
            Head = Head.Next;
            count--;
            return deletedData;
        }

        public T DeleteElementByIndex(int index)
        {
            ListItem<T> item = Head;
            int i = 0;
            while (i < index)
            {
                item = item.Next;
                ++i;
            }
            T oldData = item.Data;
            item.Next = item.Next.Next;
            count--;
            return oldData;
        }

        public void InsertElementByIndex(int index, T data)
        {
            ListItem<T> item = Head;
            int i = 0;
            while (i < index - 1)
            {
                item = item.Next;
                ++i;
            }
            ListItem<T> p = new ListItem<T>(data, item.Next);
            item.Next = p;
            count++;
        }

        public bool DeleteElementByValue(T value)
        {
            for (ListItem<T> p = Head.Next, prev = Head; p != null; prev = p, p = p.Next)
            {
                if (p.Data.Equals(value))
                {
                    prev.Next = p.Next;
                    count--;
                    return true;
                }
            }
            return false;
        }

        public void InvertList()
        {
            for (ListItem<T> p = Head.Next, prev = Head; p != null; prev = p, p = p.Next)
            {
                p.Next = prev;
            }
        }

    }
}
