using System;
using System.IO;

namespace HACKERTOOL
{
    class FileManager
    {
        private string UserText;
        private Boolean Key = false;
        private string Path;
        public void Manager()
        {
            //Console.WriteLine("WE IN TOOL");

            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Name: {drive.Name}");
                Console.WriteLine($"Type: {drive.DriveType}");
                if (drive.IsReady)
                {
                    Console.WriteLine($"Dick total size: {drive.TotalSize}");
                    Console.WriteLine($"FS name: {drive.DriveFormat}");

                    Console.WriteLine($"Disk Free space: {drive.TotalFreeSpace}");
                    Console.WriteLine($"Disk Label: {drive.VolumeLabel}");
                }
            }
            while (Key != true)
            {
                UserText = Console.ReadLine();
                if(UserText == "exit")
                {
                    Key = true;
                }
                int position = UserText.IndexOf(" ");
                if (position < 0)
                    continue;
                
                string Command = (UserText.Substring(0, position));
                string Argument = UserText.Substring(position + 1);
                Console.WriteLine("command : " + Command + " argument : " + Argument);
                if(Command == "cd")
                {
                    Path = Argument;
                }
            }
        } 
    }
}
