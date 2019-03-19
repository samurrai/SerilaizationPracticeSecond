using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;
using Newtonsoft.Json;

namespace DeserializeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PC> computers = new List<PC>();
            string json;
            using (FileStream reader = new FileStream("D:\\listSerial.txt", FileMode.Open))
            {
                byte[] buffer = new byte[reader.Length];
                reader.Read(buffer, 0, buffer.Length);
                json = Encoding.UTF8.GetString(buffer);
            }
            computers = JsonConvert.DeserializeObject<List<PC>>(json);
            foreach (var pc in computers)
            {
                Console.WriteLine(pc.Mark);
                Console.WriteLine(pc.SerialNumber);
                Console.WriteLine(pc.CPU);
                Console.WriteLine();
            }
        }
    }
}
