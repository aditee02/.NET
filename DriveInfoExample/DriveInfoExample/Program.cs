using System;
using System.Collections.Generic;
using System.IO;

namespace DriveInfoExample
{
    class Program
    {
        static void Main()
        {
            DriveInfo driveInfo = new DriveInfo("c:");
            Console.WriteLine("Name: " + driveInfo.Name);
            Console.WriteLine("DriveType: " + driveInfo.DriveType);
            Console.WriteLine("VolumeLabel: " + driveInfo.VolumeLabel);
            Console.WriteLine("RootDirectory: " + driveInfo.RootDirectory);
            Console.WriteLine("TotalSize: " + (driveInfo.TotalSize / 1024 / 1024 / 1024) + "gb");
            Console.WriteLine("Free Space: " + (driveInfo.AvailableFreeSpace / 1024 / 1024 / 1024) + "gb") ;

            Console.ReadKey();

        }
    }
}
