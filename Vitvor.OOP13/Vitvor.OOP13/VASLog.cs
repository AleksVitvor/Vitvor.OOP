using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.OOP13
{
    class VASLog
    {
        private static string _data = @"log.txt";
        public void WriteAnyth(string way, string filename)
        {
            using (StreamWriter writer = new StreamWriter(_data, true))
            {
                writer.WriteLine($"{Environment.UserName} change this file {filename} by this way {way} on time {DateTime.Now}");
            }
        }
        static VASLog()
        {
            using (StreamWriter writer = new StreamWriter(_data, false))
            {
                writer.Close();
            }
        }
    }
}
