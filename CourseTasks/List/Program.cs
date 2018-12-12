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
            ListItem<int> head = new ListItem<int>(0);
            SinglyLinkedList<int> intList = new SinglyLinkedList<int>
            {
                Head = head
            };
            intList.InsertElementAtBegin(2);

            intList.InsertElementByIndex(1, 7);

            Console.WriteLine("Размер списка: " + intList.Count);
            Console.WriteLine("Первый элемент: " + intList.GetFirstElement());
            Console.WriteLine("Элемент по индексу 1: " + intList.GetElementByIndex(1));

            intList.SetElementByIndex(1, 8);
            Console.WriteLine("Элемент по индексу 1 после изменения: " + intList.GetElementByIndex(1));

            intList.DeleteElementByValue(8);
            intList.DeleteElementAtBegin();
            Console.WriteLine("Размер списка: " + intList.Count);

            intList.InsertElementAtBegin(16);
            intList.InsertElementByIndex(1, 17);
            intList.InsertElementByIndex(2, 18);
            for (ListItem<int> p = intList.Head; p != null; p = p.Next)
            {
                Console.WriteLine(p.Data);
            }

            intList.InvertList();
            Console.WriteLine("Инвертированный список:");
            for (ListItem<int> p = intList.Head; p != null; p = p.Next)
            {
                Console.WriteLine(p.Data);
            }

            intList.DeleteElementByIndex(2);
            Console.WriteLine("Список после удаления:");
            for (ListItem<int> p = intList.Head; p != null; p = p.Next)
            {
                Console.WriteLine(p.Data);
            }

            SinglyLinkedList<int> intListCopy = intList.CopyList();
            Console.WriteLine("Копия списка:");
            for (ListItem<int> p = intListCopy.Head; p != null; p = p.Next)
            {
                Console.WriteLine(p.Data);
            }
        }
    }
}
