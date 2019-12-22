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
        private static string _data1 = @"log1.txt";
        public void WriteAnyth(string way, string filename)
        {
            using (StreamWriter writer = new StreamWriter(_data, true))
            {
                writer.WriteLine($"{Environment.UserName}; change this file; {filename} by this way; {way} on time; {DateTime.Now}");
            }
        }
        public void ReadAndDelete()
        {
            using (StreamWriter writer = new StreamWriter(_data1))
            {
                using (StreamReader reader = new StreamReader(_data))
                {
                    string file = reader.ReadToEnd();
                    string[] filesinfo = file.Split('\n');
                    foreach (string i in filesinfo)
                    {
                        string[] info = i.Split(';');
                        foreach (string l in info)
                        {
                            if (l.Contains(":"))
                            {
                                DateTime earlier;
                                if (DateTime.TryParse(l, out earlier))
                                {
                                    if (earlier.Minute + 1 >= DateTime.Now.Minute)
                                        writer.WriteLine(i);
                                }
                        }
                        }
                    }
                }
            }
        }
        //static VASLog()
        //{
        //    using (StreamWriter writer = new StreamWriter(_data, false))
        //    {
        //        writer.Close();
        //    }
        //}
    }
}
