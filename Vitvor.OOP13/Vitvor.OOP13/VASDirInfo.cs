using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.OOP13
{
    class VASDirInfo
    {
        private static string _dirinfo = @"dirinfo.txt";
        public void DirInfo(string directory)
        {
            VASLog log = new VASLog();
            FileInfo info = new FileInfo(_dirinfo);
            log.WriteAnyth(info.FullName, "dirinfo.txt");
            using(StreamWriter writer=new StreamWriter(_dirinfo))
            {
                if(Directory.Exists(directory))
                {
                    writer.WriteLine("Файлы:");
                    string[] files = Directory.GetFiles(directory);
                    int count = 0;
                    foreach(string file in files)
                    {
                        writer.WriteLine($"{count}. {file}");
                        count++;
                    }
                    writer.WriteLine($"{Directory.GetCreationTime(directory)}");
                    writer.WriteLine("Поддиректории:");
                    string[] dirs = Directory.GetDirectories(directory);
                    count = 0;
                    foreach(string s in dirs)
                    {
                        writer.WriteLine($"{count}. {s}");
                        count++;
                    }
                    writer.WriteLine("Родительские дериктории");
                    writer.WriteLine(Directory.GetDirectoryRoot(directory));
                }
            }
        }
    }
}
