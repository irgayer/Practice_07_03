using Practice_07_03.ClassLib;
using System.Collections.Generic;

namespace Practice_07_03.SerializConsolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const string PATH = @"E:\special\listSerial.txt"; //у меня нет диска D
            List<PC> pcs = new List<PC>()
            {
                new PC("name","0442-1123-5523-9668"),
                new PC("xisire", "asusat xtreme", "gtx 1337228"),
                new PC("Jolybell"),
                new PC("Oleg", "2223-3332-4441-5554")
            };
            BinaryManager binaryManager = new BinaryManager();
            binaryManager.WriteToFile(pcs, PATH);
            List<PC> loadedPcs = binaryManager.LoadFromFile<PC>(PATH);
            System.Console.WriteLine("\nЗагрузка из файла:\n");
            foreach(var l in loadedPcs)
            {
                l.Print();
                System.Console.WriteLine();
            }
            System.Console.ReadLine();
        }
    }
}
