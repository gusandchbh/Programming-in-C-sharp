using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;//BinaryFormatter
using System.Runtime.Serialization; //IFormatterUsing
using System.IO;//FileStream, Reader/Writer classes
using System.CodeDom;
using Assignment3.Utilities;
using Assignment3.Animals;

namespace Assignment3.Manager
{
    [Serializable]
    public class ListManager<T> : IListManager<T>
    {
        private List<T> list;

        public ListManager()
        {
            list = new List<T>();
        }

        /// <summary>
        /// Returns the size of the list
        /// If list is null, return 0
        /// </summary>

        public int Count { get { return list?.Count ?? 0; } }


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

        public List<T> List
        {
            get { return list; }
            protected set { list = value; }
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


        public void JsonSerialize(string fileName)
        {
            JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented
            };
                string? jsonString = JsonConvert.SerializeObject(list, jsonSerializerSettings);
                File.WriteAllText(fileName, jsonString);
        }

        public void JsonDeserialize(string fileName)
        {
            JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented
            };
                string? jsonString = File.ReadAllText(fileName);
                list = JsonConvert.DeserializeObject<List<T>>(jsonString, jsonSerializerSettings);
        }

        public virtual void BinarySerialize(string fileName)
        {
            throw new NotImplementedException();
        }

        public void XMLSerialize(string fileName)
        {
            throw new NotImplementedException();
        }

        public virtual void BinaryDeserialize(string fileName)
        {
            throw new NotImplementedException();
        }

    }
}
