using System;
using System.IO;
public class test {
	public static void Main()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
        Console.WriteLine("Available Fixed NTFS Drivers");
        foreach (DriveInfo drive in drives)
        {
            if (drive.DriveType == DriveType.Fixed)
            {
                Console.WriteLine("The drive name {0} has {1} bytes of free space available",
                    drive.Name, drive.AvailableFreeSpace);
            }
        }

        Console.ReadLine();
}
}