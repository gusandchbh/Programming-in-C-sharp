using Assignment3.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Utilities
{
    public class BinSeralizerUtility
    {

        public static string BinaryFileSerialize<T>(string filePath, List<T> items)
        {
            FileStream fileStream = null;
            string errorMsg = null;

            try
            {
                fileStream = new FileStream(filePath, FileMode.Create);
                BinaryFormatter b = new BinaryFormatter();
                b.Serialize(fileStream, items);
            }
            catch (Exception e)
            {
                errorMsg = e.Message;
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }
            return errorMsg;
        }




        public static List<T> BinaryFileDeSerialize<T>(string filePath, out string errorMessage)
        {
            FileStream fileStream = null;
            errorMessage = null;
            List<T> items = null;
            try
            {
                if (!File.Exists(filePath))
                {
                    errorMessage = $"The file {filePath} was not found. ";
                    throw new Exception(errorMessage);
                }
                fileStream = new FileStream(filePath, FileMode.Open);
                BinaryFormatter b = new BinaryFormatter();
                items = (List<T>)b.Deserialize(fileStream);
            }
            catch (Exception e)
            {
                if (errorMessage != null)
                {
                    errorMessage = e.Message;
                }
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }
            return items;
        }



    }
}
