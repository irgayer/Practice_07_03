using System;

namespace Practice_07_03.ClassLib
{
    [Serializable]
    public class PC
    {
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public string MotherBoard { get; set; }
        public string VideoCard { get; set; }

        private bool isTurnedOn;

        public PC(string name, string serialNumber)
        {
            Name = name;
            SerialNumber = serialNumber;
            MotherBoard = "Unknown";
            VideoCard = "Unknown";
            isTurnedOn = false;
        }
        public PC(string name)
        {
            Name = name;
            SerialNumber = "Unknown";
            MotherBoard = "Unknown";
            VideoCard = "Unknown";
            isTurnedOn = false;
        }
        public PC(string name, string motherboard, string videocard)
        {
            Name = name;
            MotherBoard = motherboard;
            VideoCard = videocard;
            isTurnedOn = false;
        }

        public void PowerOn()
        {
            if (!isTurnedOn)
            {
                isTurnedOn = true;
            }
            else
            {
                Console.WriteLine("Power is already turned on!");
            }
        }
        public void PowerOff()
        {
            if (isTurnedOn)
            {
                isTurnedOn = false;
            }
            else
            {
                Console.WriteLine("Power is already turned off!");
            }
        }
        public void StackOveflow()
        {
            if (isTurnedOn)
            {
                Console.WriteLine("CRITICAL ERROR : 0x5631");
                Console.WriteLine("BSOD");
                Console.WriteLine("TURNING OFF");
                isTurnedOn = false;
            }
        }

        public void Print()
        {
            Console.WriteLine($"Name          : {Name}");
            Console.WriteLine($"Serial number : {SerialNumber}");
            Console.WriteLine($"Mother Board  : {MotherBoard}");
            Console.WriteLine($"Video Card    : {VideoCard}");
        }

    }
}
