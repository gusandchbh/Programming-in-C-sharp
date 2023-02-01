using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class Task
    {
        private string description;
        private PriorityType priorityType;
        private DateTime taskDate;


        /// <summary>
        /// Default constructor
        /// </summary>
        public Task()
        {
        }

        /// <summary>
        /// Full constructor
        /// </summary>
        /// <param name="description"></param>
        /// <param name="priorityType"></param>
        /// <param name="taskDate"></param>

        public Task(string description, PriorityType priorityType, DateTime taskDate)
        {
            this.description = description;
            this.priorityType = priorityType;
            this.taskDate = taskDate;
        }

        /// <summary>
        /// Property for Description
        /// </summary>

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        /// <summary>
        /// Property for PriorityType
        /// </summary>
        public PriorityType PriorityType
        {
            get { return priorityType; }
            set { priorityType = value; }
        }

        /// <summary>
        /// Property for TaskDate
        /// </summary>

        public DateTime TaskDate
        {
            get { return taskDate; }
            set { taskDate = value; }
        }

        /// <summary>
        /// Returns the string representation of the PriorityType and if applicable replaces _ with a space
        /// </summary>
        /// <returns></returns>

        public string GetPriorityString()
        {
            string prio = this.PriorityType.ToString().Replace("_", " ");
            return prio;
        }

        /// <summary>
        /// ToString to show the data in the GUI
        /// </summary>
        /// <returns></returns>

        public override string ToString()
        {
            
            string strOut = string.Format(" {0,-32} {1, -9} {2, -28} {3, -40}", this.taskDate.ToShortDateString(),this.taskDate.ToShortTimeString(), GetPriorityString(), this.description);
            return strOut;
        }
    }
}
