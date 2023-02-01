using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    internal class PhoneBook
    {
        private string[] names = { "Johan", "Ludwig", "Erik", "John", "Adrian" };
        private string[] phones = { "031-1234", "031-1337", "031-4321", "031-9999", "031-2525" };
        private string[,] phoneList;

        public PhoneBook()
        {
            Console.Clear();
            DisplayList();
            Console.WriteLine();
            SortByName();
            Console.WriteLine("\n\nSorted List:\n");
            DisplayList();

            int count = names.Length;
            phoneList = new string[count, 2];
            FillTable();
            Console.WriteLine("\n\nUsing a 2d array instead of two 1d arrays:\n");
            DisplayTable();
        }

        public void DisplayList()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(names[i].PadRight(15) + phones[i]);
            }
        }
        public void DisplayTable()
        {
            int rows = phoneList.GetLength(0);
            int cols = phoneList.GetLength(1);
            for (int row = 0; row < rows; row++)
            {
                Console.Write(string.Format("{0,-15}", "Row " + row.ToString()));
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(string.Format("{0,-15}", phoneList[row, col]));
                }
                Console.WriteLine();
            }
        }

        public void FillTable()
        {
            int row;
            for (row = 0; row < names.Length; row++)
            {
                phoneList[row, 0] = names[row];
                phoneList[row, 1] = phones[row];
            }
        }

        public void SortByName()
        {
            int pos, i;
            int length = names.Length;

            for (pos = 0; pos < length -1; pos++)
            {
                for (i = 0; i < length - pos - 1; i++)
                {
                    int result = names[i].CompareTo(names[i + 1]);
                    if (result == 1)
                    {
                        SwapValues(i);
                    }
                }
            }

        }

        public void SwapValues(int pos)
        {
            string temp = names[pos];
            names[pos] = names[pos + 1];
            names[pos + 1] = temp;

            temp = phones[pos];
            phones[pos] = phones[pos + 1];
            phones[pos + 1] = temp;
        }



    }
}
