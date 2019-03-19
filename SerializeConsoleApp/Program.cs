using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;
using Newtonsoft.Json;

namespace SerializeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PC> computers = new List<PC>();
            computers.Add(new PC()
            {
                Mark = "Asus",
                SerialNumber = 123,
                CPU = "Intel Core Duo",
            });
            computers.Add(new PC()
            {
                Mark = "HP",
                SerialNumber = 783,
                CPU = "AMD Ryzen 5",
            });
            computers.Add(new PC()
            {
                Mark = "Acer",
                SerialNumber = 368,
                CPU = "Intel Core i7",
            });

            if (File.Exists("D:\\listSerial.txt"))
            {
                Console.WriteLine("Файл был перезаписан");
            }
            using (FileStream writer = new FileStream("D:\\listSerial.txt", FileMode.Create))
            {   
                string json = JsonConvert.SerializeObject(computers);
                byte[] buffer = Encoding.UTF8.GetBytes(json);
                writer.Write(buffer, 0, buffer.Length);
            }

        }
    }
}
