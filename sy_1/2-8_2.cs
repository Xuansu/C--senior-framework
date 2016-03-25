using System;
using System.IO;
public class test {
	public static void Main()
	{
		string directory = "c:\\Users\\59173\\Thunder";
		Console.WriteLine("The parent directory we search is \n" + directory);
		SearchFile(directory);
		Console.ReadLine();
	}

	public static void SearchFile(string directory)
	{
        int countfile = 0;
        int countdir = 0;
        DirectoryInfo dir = new DirectoryInfo(directory);
        FileSystemInfo[] f = dir.GetFileSystemInfos("*", SearchOption.AllDirectories);
        foreach (FileSystemInfo i in f)
        {
            if (i is DirectoryInfo)
            {
                countdir++;
                SearchFile(i.FullName);
            }
            else if (i is FileInfo)
            {
                countfile++;
            }
        }
        Console.WriteLine("目录" + directory + "下共有 {0} 个文件夹,{1}个文件", countdir, countfile);
	}
}