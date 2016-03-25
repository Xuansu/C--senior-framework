using System;
using System.IO;
public class FileTest {
	public static void Main() {
		StreamWriter SW;
		string filename = "c:\\MyTextFile.txt";
		SW = File.CreateText(filename);
		SW.WriteLine("创建一个文本文件");
		SW.WriteLine("并写入若干内容");
		SW.Close();
		Console.WriteLine("创建文件成功!");
		Console.ReadLine();

		StreamReader SR;
		SR = File.OpenText(filename);
		string S = SR.ReadToEnd();
		while(S != null) {
			Console.WriteLine(S);
			S = SR.ReadLine();
		}

		SR.Close();
		Console.WriteLine("读取文件成功!");
		Console.ReadLine();

		SW = File.AppendText(filename);
		SW.WriteLine("Microsoft C# .NET框架程序设计");
		SW.Close();
		Console.WriteLine("添加文件成功!");
		Console.ReadLine();
	}
}