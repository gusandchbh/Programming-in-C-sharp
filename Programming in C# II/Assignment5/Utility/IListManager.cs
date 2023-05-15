using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.Utility
{
    public interface IListManager<T>
    {


        /// <summary>
        /// Return the number of items in the collection m_list
        /// </summary>
        int Count { get; }


        /// <summary>
        /// Add an object to the collection m_list
        /// </summary>
        /// <param name="aType"></param>
        /// <returns></returns>
        bool Add(T aType);


        /// <summary>
        /// Remove an object from the collection m_list at the provided index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        bool DeleteAt(int index);

        /// <summary>
        /// Returns an object from the collection m_list at the provided index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        T Get(int index);

        /// <summary>
        /// Replaces one object with another
        /// </summary>
        /// <param name="oldItem"></param>
        /// <param name="newItem"></param>
        /// <returns></returns>
        bool Replace(T oldItem, T newItem);


        /// <summary>
        /// Return a string array where each element in the array is the tostring of an object in the list
        /// </summary>
        /// <returns></returns>
        string[] GetÍnfo();


        /// <summary>
        /// Checks if there the argument provided is a valid index in the list
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        bool CheckIndex(int index);

        /// <summary>
        /// Deletes all objects in the list
        /// </summary>
        void deleteAll();

        // Each of the methods returns true if the operation
        // completes successfully, and false otherwise.
        // Use JsonConvert as it is more convenient
    }
}
