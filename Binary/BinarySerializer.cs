using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Binary
{
    public class BinarySerializer
    {
        public void Serialize(object data, string filePath)
        {
            //Create the stream to add object into it.
            System.IO.Stream ms = File.OpenWrite(filePath);
            //Format the object as Binary

            BinaryFormatter formatter = new BinaryFormatter();
            //It serialize the employee object
            formatter.Serialize(ms, data);
            ms.Flush();
            ms.Close();
            ms.Dispose();
        }

        public object Deserialize(string filePath)
        {
            //Format the object as Binary
            BinaryFormatter formatter = new BinaryFormatter();

            //Reading the file from the server
            FileStream fs = File.Open(filePath, FileMode.Open);

            object obj = formatter.Deserialize(fs);
            fs.Flush();
            fs.Close();
            fs.Dispose();

            return obj;
        }
    }
}
