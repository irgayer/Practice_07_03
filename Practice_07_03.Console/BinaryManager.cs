using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Practice_07_03.SerializConsolApp
{
    public class BinaryManager
    {
        public void WriteToFile<T>(List<T> list, string path)
        {
            using(Stream fileStream = File.Open(path, FileMode.Create))
            {
                System.Console.WriteLine("Создание файла");
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, list);
            }
        }
        public List<T> LoadFromFile<T>(string path)
        {
            List<T> result = new List<T>();
            using(Stream fileStream = File.Open(path, FileMode.OpenOrCreate))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                result = (List<T>)binaryFormatter.Deserialize(fileStream);
            }
            return result;
        }
    }
}
