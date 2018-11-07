using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class HashTable<T> : ICollection<T>
    {
        private List<T>[] hashTableArray;

        HashTable(int tableSize)
        {
            hashTableArray = new List<T>[tableSize];
        }

        public int Count { get; set; }
    };

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            int index = item.GetHashCode();

        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }


        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void SearchObject(object objToSearch)
        {

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
