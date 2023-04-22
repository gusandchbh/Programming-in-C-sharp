using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class TaskManager
    {
        private List<Task> taskList;

        public TaskManager()
        {
            taskList = new List<Task>();
        }

        /// <summary>
        /// Read data from file
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>

        public bool ReadDataFromFile(string fileName)
        {
            FileManager fileManager = new FileManager();

            return fileManager.ReadTaskListFromFile(taskList, fileName);
        }

        /// <summary>
        /// Add task to the list of tasks
        /// </summary>
        /// <param name="task"></param>

        public void AddTask(Task task)
        {
            this.taskList.Add(task);
        }

        /// <summary>
        /// Write data to file
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>

        public bool WriteDataToFile(string fileName)
        {
            FileManager fileManager = new FileManager();
            return fileManager.SaveTaskListToFile(taskList, fileName);
        }

        /// <summary>
        /// Returns an array of strings containing the ToString representation of tasks
        /// </summary>
        /// <returns></returns>

        public string[] GetInfoStringsList()
        {
            string[] arr = new string[taskList.Count];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = taskList[i].ToString();
            }
            return arr;
        }

        /// <summary>
        /// Delete a specific task based on the index
        /// </summary>
        /// <param name="index"></param>

        public void Delete(int index)
        {
            taskList.RemoveAt(index);
        }

        /// <summary>
        /// Retrieve a specific task based on the index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>

        public Task GetTask(int index)
        {
            return taskList[index];
        }

    }
}
