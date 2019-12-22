using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace Vitvor.OOP13
{
    class VASFileManager
    {
        private static string _path = @"VASInspect";
        private static string _secondpath = @"VASFiles";
        private static string _secondnewpath = @"D:\\VASFiles\\";
        private static string _newpath = @"D:\\VAS-2019\\";
        private string _path1 { get; set; }
        public void ReadAndCreate(string directory, VASDirInfo dirInfo)
        {
            dirInfo.DirInfo(directory);
            DirectoryInfo info = new DirectoryInfo(directory);
            info.CreateSubdirectory(_path);
            using (FileStream fileStream = new FileStream(directory + _path + "\\VASdirinfo.txt", FileMode.Create))
            {
                StreamWriter writer = new StreamWriter(fileStream);
                writer.WriteLine(DateTime.Now);
                writer.Close();
            }

            FileInfo file = new FileInfo(directory + _path + "\\VASdirinfo.txt");
            if (file.Exists)
            {
                file.CopyTo(_newpath + "copy.txt", true);
            }
            file.Delete();
            _path1 = directory + _path;

        }
        public void Copy(string directory)
        {
            DirectoryInfo info = new DirectoryInfo("D:\\");
            info.CreateSubdirectory(_secondpath);
            DirectoryInfo directoryInfo = new DirectoryInfo(directory);
            FileInfo[] files=directoryInfo.GetFiles();
            IEnumerable<FileInfo> ts = from i in files where i.FullName.Contains(".txt") select i;
            foreach(FileInfo fi in ts)
            {
                FileInfo file = new FileInfo(fi.FullName);
                file.CopyTo(_secondnewpath+fi.Name, true);
            }
            Directory.Move(_secondnewpath, _path1+"\\"+_secondpath);
        }
        public void Archive(string resultdir)
        {
            ZipFile.CreateFromDirectory("D://VASInspect/", "D://VASInspect.zip");
            ZipFile.ExtractToDirectory("D://VASInspect.zip", resultdir);
        }
    }
}
