using System;
using System.IO;
public class test {
	public static void Main()
	{
		DirectoryInfo dir = new DirectoryInfo("c:\\WINDOWS");
		FileInfo[] dllfiles = dir.GetFiles("*.dll");
		Console.WriteLine("Total number of dll files is {0}", dllfiles.Length);
		foreach (FileInfo f in dllfiles) {
			Console.WriteLine("Name is :{0}", f.Name);
			Console.WriteLine("Length of the file is :{0}", f.Length);
			Console.WriteLine("Creation times is :{0}", f.CreationTime);
			Console.WriteLine("Attributes of the files are :{0}",
				f.Attributes.ToString());
		}
		Console.ReadLine();
	}
}