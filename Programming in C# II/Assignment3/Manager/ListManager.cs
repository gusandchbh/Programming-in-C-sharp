using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Manager
{
    public class ListManager<T> : IListManager<T>
    {
        private List<T> list;

        public ListManager()
        {
            list = new List<T>();
        }

        /// <summary>
        /// Returns the size of the list
        /// </summary>

        public int Count { get { return list.Count; } }

        /// <summary>
        /// Adds a new element to the list, returns false if argument is null
        /// </summary>
        /// <param name="aType"></param>
        /// <returns></returns>
        public bool Add(T aType)
        {
            if (aType == null)
            {
                return false;
            }
            list.Add(aType);
            return true;
        }

        /// <summary>
        /// Deletes object from the list at the provided index. If index is less than 0 or more than count, return false;
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>

        public bool DeleteAt(int index)
        {
            if (index < 0 || index >= Count)
            {
                return false;
            }
            list.RemoveAt(index);
            return true;
        }

        public bool CheckIndex(int index)
        {
            if (index < 0 || index >= Count)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Returns the object at the provided index in the list
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T Get(int index)
        {
            return list[index];
        }

        /// <summary>
        /// Creates an array of strings, then loops through the list and fills the array with the toString representation of the objects
        /// </summary>
        /// <returns></returns>

        public string[] GetÍnfo()
        {
            string[] infoStrings = new string[Count];
            for (int i = 0; i < Count; i++)
            {
                infoStrings[i] = list[i].ToString();
            }

            return infoStrings;
        }

        /// <summary>
        /// Replaces one item with another
        /// If index is less than 0 it does not exist in the list and we return false
        /// </summary>
        /// <param name="oldItem"></param>
        /// <param name="newItem"></param>
        /// <returns></returns>
        public bool Replace(T oldItem, T newItem)
        {
            int index = list.IndexOf(oldItem);
            if (index < 0)
            {
                return false;
            }
            list[index] = newItem;
            return true;
        }

        /// <summary>
        /// Removes all items from the list
        /// </summary>

        public void deleteAll()
        {
            list.Clear();
        }
    }
}
