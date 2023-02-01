using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Reflection.Metadata.Ecma335;

namespace Assignment6
{

    internal class FileManager
    {
        //Write this token as the first line in the textfile as a stamp
        //To mark that the file is saved by this application

        private const string fileVersionToken = "ToDoRe_21";
        //The file version can help you make old files compatible
        //The fileVersion does ot have to be the same as the app's version nr
        private const double fileVersionNr = 1.0;

        public bool SaveTaskListToFile(List<Task> taskList, string fileName)
        {
            bool ok = true;
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(fileName);
                writer.WriteLine(fileVersionToken);
                writer.WriteLine(fileVersionNr);
                writer.WriteLine(taskList.Count);

                for (int i = 0; i < taskList.Count; i++)
                {
                    writer.WriteLine(taskList[i].Description);
                    writer.WriteLine(taskList[i].PriorityType.ToString());
                    writer.WriteLine(taskList[i].TaskDate.Year);
                    writer.WriteLine(taskList[i].TaskDate.Month);
                    writer.WriteLine(taskList[i].TaskDate.Day);
                    writer.WriteLine(taskList[i].TaskDate.Hour);
                    writer.WriteLine(taskList[i].TaskDate.Minute);
                    writer.WriteLine(taskList[i].TaskDate.Second);
                }
            } catch
            {
                ok = false;
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
            return ok;
        }

        public bool ReadTaskListFromFile(List<Task> taskList, string filename)
        {
            bool ok = true;
            StreamReader reader = null;

            try
            {
                if (taskList != null)
                {
                    taskList.Clear();
                } else
                {
                    taskList = new List<Task>();
                }

                reader = new StreamReader(filename);

                // Ensure that it is the correct file
                string? versionTest = reader.ReadLine();
                //Ensure that is it the correct version nr
                double version = double.Parse(reader.ReadLine());

                if ((versionTest == fileVersionToken) && (version == fileVersionNr))
                {
                    int count = int.Parse(reader.ReadLine());
                    for (int i = 0; i < count; i++)
                    {
                        Task task = new Task();
                        task.Description = reader.ReadLine();
                        task.PriorityType = (PriorityType)Enum.Parse(typeof(PriorityType), reader.ReadLine());

                        //DateTime.Year, Month, etc. are readonly!
                        int year = 0, month = 0, day = 0;
                        int hour = 0, minute = 0, second = 0;

                        year = int.Parse(reader.ReadLine());
                        month = int.Parse(reader.ReadLine());
                        day = int.Parse(reader.ReadLine());
                        hour = int.Parse(reader.ReadLine());
                        minute = int.Parse(reader.ReadLine());
                        second = int.Parse(reader.ReadLine());

                        task.TaskDate = new DateTime(year, month, day, hour, minute, second);
                        taskList.Add(task);
                    }
                } else
                {
                    ok = false;
                }
            } catch
            {
                ok = false;
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            } return ok;
        } 

    } 
}
