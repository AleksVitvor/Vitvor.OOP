using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.OOP13
{
    class Program
    {
        static void Main(string[] args)
        {
            VASDiskInfo diskInfo = new VASDiskInfo();
            diskInfo.InfoAboutDisks();
            VASFileInfo fileInfo = new VASFileInfo();
            fileInfo.InfoAboutFile(@"D:\\2 курс\\C#\\Лабы\\Vitvor.OOP12\\Vitvor.OOP12\\bin\\Debug\\data.txt");
            VASDirInfo dirInfo = new VASDirInfo();
            dirInfo.DirInfo("C:\\");
            VASFileManager fileManager = new VASFileManager();
            fileManager.ReadAndCreate("D:\\", dirInfo);
            fileManager.Copy("D:\\VAS-2019");
            fileManager.Archive("D:\\VAS-2019\\");
            VASLog log = new VASLog();
            log.ReadAndDelete();
        }
    }
}