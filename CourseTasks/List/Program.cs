using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            ListItem<int> head = new ListItem<int>(5);
            SinglyLinkedList<int> intList = new SinglyLinkedList<int>(head);
            intList.InsertElementAtBegin(2);
            intList.InsertElementByIndex(1, 7);
            Console.WriteLine("Размер списка: " + intList.GetListSize());
            Console.WriteLine("Первый элемент: " + intList.GetFirstElement());
            Console.WriteLine("Элемент по индексу 1: " + intList.GetElementByIndex(1));
            intList.SetElementByIndex(1, 8);
            Console.WriteLine("Элемент по индексу 1: " + intList.GetElementByIndex(1));
            intList.DeleteElementByValue(8);
            intList.InvertList();
            for (ListItem<int> p = head; p != null; p = p.Next)
            {
                Console.WriteLine(p.Data);
            }
        }
    }
}
