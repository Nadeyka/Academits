using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class HashTable
    {
        private List<object>[] hashTableArray;

        HashTable(int tableSize)
        {
            hashTableArray = new List<object>[tableSize];
        }

        public void InsertObject(object objToInsert)
        {
            int index = objToInsert.GetHashCode();
            
        }

        public void SearchObject(object objToSearch)
        {

        }
    }
}
