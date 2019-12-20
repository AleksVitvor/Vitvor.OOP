using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.OOP13
{
    class VASDiskInfo
    {
        private static string _info = @"info.txt";
        public void InfoAboutDisks()
        {
            VASLog log = new VASLog();
            FileInfo file = new FileInfo(_info);
            log.WriteAnyth(file.FullName, "info.txt");
            DriveInfo[] drives = DriveInfo.GetDrives();
            using (StreamWriter writer = new StreamWriter(_info))
            {
                foreach (DriveInfo drive in drives)
                {
                    writer.WriteLine($"Название: {drive.Name}");
                    writer.WriteLine($"Тип: {drive.DriveType}");
                    if(drive.IsReady)
                    {
                        writer.WriteLine($"Объём диска: {drive.TotalSize}");
                        writer.WriteLine($"Free space: {drive.TotalFreeSpace}");
                        writer.WriteLine($"Метка: {drive.VolumeLabel}");
                    }
                }
                writer.Close();
            }
        }
    }
}
