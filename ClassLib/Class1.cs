using System;

namespace ClassLib 
{
    [Serializable]
    public class PC
    {
        public string Mark { get; set; }
        public int SerialNumber { get; set; }
        public string CPU { get; set; }

        public PC()
        {
            Mark = "";
            SerialNumber = 0;
            CPU = "";
        }
        public PC(string mark, int serialNumber, string cpu)
        {
            Mark = mark;
            SerialNumber = serialNumber;
            CPU = cpu;
        }

        public void On()
        {
            Console.WriteLine("Компьютер был включен");
        }
        public void Off()
        {
            Console.WriteLine("Компьютер был выключен");
        }
        public void Reboot()
        {
            Console.WriteLine("Компьютер был перезагружен");
        }
    }
}
