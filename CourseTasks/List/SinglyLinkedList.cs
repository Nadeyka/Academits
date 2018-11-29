using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class SinglyLinkedList<T>
    {
        public ListItem<T> Head { get; set; }
        public int Count { get; private set; }

        public SinglyLinkedList()
        {
            Count = 0;
        }

        public T GetFirstElement()
        {
            if (Count == 0)
            {
                throw new Exception("Список пуст");
            }
            return Head.Data;
        }

        public T GetElementByIndex(int index)
        {
            if (index >= Count)
            {
                throw new IndexOutOfRangeException("Элемента с таким индексом нет в списке");
            }
            ListItem<T> item = Head;
            int i = 0;
            item = IterateItem(index, i, item);
            return item.Data;
        }

        public T SetElementByIndex(int index, T newData)
        {
            if (index >= Count)
            {
                throw new IndexOutOfRangeException("Элемента с таким индексом нет в списке");
            }

            ListItem<T> item = Head;
            int i = 0;
            item = IterateItem(index, i, item);

            T oldData = item.Data;
            item.Data = newData;
            return oldData;
        }

        public void InsertElementAtBegin(T data)
        {
            ListItem<T> p = new ListItem<T>(data, Head);
            Head = p;
            Count++;
        }

        public T DeleteElementAtBegin()
        {
            if (Count == 0)
            {
                throw new Exception("Список пуст");
            }
            T deletedData = Head.Data;
            Head = Head.Next;
            Count--;
            return deletedData;
        }

        public T DeleteElementByIndex(int index)
        {
            if (index >= Count)
            {
                throw new IndexOutOfRangeException("Элемента с таким индексом нет в списке");
            }
            ListItem<T> item = Head;
            int i = 0;
            item = IterateItem(index, i, item);
            T oldData = item.Data;
            item.Next = item.Next.Next;
            Count--;
            return oldData;
        }

        public void InsertElementByIndex(int index, T data)
        {
            if (index > Count)
            {
                throw new IndexOutOfRangeException("Элемента с таким индексом нет в списке");
            }
            ListItem<T> item = Head;
            int i = 0;
            item = IterateItem(index - 1, i, item);
            ListItem<T> p = new ListItem<T>(data, item.Next);
            item.Next = p;
            Count++;
        }

        public bool DeleteElementByValue(T value)
        {
            if (Count == 0)
            {
                throw new Exception("Список пуст");
            }

            for (ListItem<T> p = Head.Next, prev = Head; p != null; prev = p, p = p.Next)
            {
                if (p.Data.Equals(value))
                {
                    prev.Next = p.Next;
                    Count--;
                    return true;
                }
            }
            return false;
        }

        public void InvertList()
        {
            if (Count == 0)
            {
                throw new Exception("Список пуст");
            }

            ListItem<T> p = Head;
            ListItem<T> prev = null;
            while (p != null)
            {
                ListItem<T> q = p.Next;
                p.Next = prev;
                prev = p;
                Head = p;
                p = q;
            }
        }

        public SinglyLinkedList<T> CopyList()
        {
            if (Count == 0)
            {
                throw new Exception("Список пуст");
            }

            for (ListItem<T> p = Head.Next, prev = Head; p != null; prev = p, p = p.Next)
            {
                p.Next = prev;
            }

            Head = null;
        }

        private ListItem<T> IterateItem(int index, int i, ListItem<T> item)
        {
            while (i < index)
            {
                item = item.Next;
                ++i;
            }
            return item;
        }
    }
}
