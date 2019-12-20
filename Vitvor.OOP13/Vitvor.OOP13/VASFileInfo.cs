using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.OOP13
{
    class VASFileInfo
    {
        private static string _fileinfo = @"fileinfo.txt";
        public void InfoAboutFile(string fileway)
        {
            VASLog log = new VASLog();
            FileInfo file = new FileInfo(fileway);
            FileInfo info = new FileInfo(_fileinfo);
            log.WriteAnyth(info.FullName, "fileinfo.txt");
            using(StreamWriter writer = new StreamWriter(_fileinfo))
            {
                if(file.Exists)
                {
                    writer.WriteLine($"Full name: {file.FullName}");
                    writer.WriteLine($"Size: {file.Length}");
                    writer.WriteLine($"Расширение: {file.Extension}");
                    writer.WriteLine($"Name: {file.Name}");
                    writer.WriteLine($"Time: {file.CreationTime}");
                }
            }
        }
    }
}
