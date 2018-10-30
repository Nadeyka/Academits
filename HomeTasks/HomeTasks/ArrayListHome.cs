using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    class ArrayListHome
    {
        static void Main()
        {
            #region Чтение строк из файла в список

            List<string> fileContent = new List<string>();

            try
            {
                using (StreamReader sr = new StreamReader("../../input.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        fileContent.Add(line);
                    }
                }
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл не найден");
            }

            foreach (string e in fileContent)
            {
                Console.WriteLine(e);
            }
            #endregion

            #region Удаление четных чисел из списка

            List<int> intNumbersList = new List<int> { 1, 2, 3, 45, 6, 7, 51, 16 };
            int i = 0;
            while (i < intNumbersList.Count)
            {
                if (intNumbersList[i] % 2 == 0)
                {
                    intNumbersList.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Список без четных чисел:");
            foreach (int e in intNumbersList)
            {
                Console.Write(e + " ");
            }
            #endregion

            #region Создание копии списка без повторений

            List<int> originalList = new List<int> { 0, 1, 2, 3, 4, 6, 1, 12, 11, 3, 6, 8 };
            List<int> notDuplicateList = new List<int>();

            foreach (int e in originalList)
            {
                if (!notDuplicateList.Contains(e))
                {
                    notDuplicateList.Add(e);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Список без повторяющихся чисел:");
            foreach (int e in notDuplicateList)
            {
                Console.Write(e + " ");
            }
            #endregion
        }
    }
}