using System;
using System.IO;
public class test {
	public static void Main()
	{
        DriveInfo[] drives = DriveInfo.GetDrives();
        Console.WriteLine("Available Fixed NTFS Drivers");
        DriveInfo[] rmbdisk = new DriveInfo[10];
        int index = 0;
        foreach (DriveInfo drive in drives)
        {
            if (drive.DriveType == DriveType.Removable)
                rmbdisk[index++] = drive;
        }
        rmbdisk[index] = null;
        
        long  max = 0;
        DriveInfo maxspace = null;
        for(int i = 0; i < index; i++)
        {
            if (rmbdisk[i].AvailableFreeSpace >= max)
            {
                max = rmbdisk[i].AvailableFreeSpace;
                maxspace = rmbdisk[i];
            }
        }

        Console.WriteLine("Name {0} has max {1} bytes of free space available",
                maxspace.Name, maxspace.AvailableFreeSpace);
                
        Console.ReadLine();
}
}