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

        public static string BinaryFileSerialize(string filePath, List<Animal> animals)
        {
            FileStream fileStream = null;
            string errorMsg = null;

            try
            {
                fileStream = new FileStream(filePath, FileMode.Create);
                BinaryFormatter b = new BinaryFormatter();
                b.Serialize(fileStream, animals);
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



        public static List<Animal> BinaryFileDeSerialize(string filePath, out string errorMessage)
        {
            FileStream fileStream = null;
            errorMessage = null;
            List<Animal> animals = null;
            try
            {
                if (!File.Exists(filePath))
                {
                    errorMessage = $"The file {filePath} was not found. ";
                    throw new Exception(errorMessage);
                }
                fileStream = new FileStream(filePath, FileMode.Open);
                BinaryFormatter b = new BinaryFormatter();
                animals = (List<Animal>)b.Deserialize(fileStream);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                if (errorMessage != null)
                {
                    MessageBox.Show(e.Message);
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
            return animals;
        }


    }
}
