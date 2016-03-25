using System;
class GCCollectClass
{
	private const long maxGarbage = 1000;
	static void Main()
	{
		GCCollectClass myGCCol = new GCCollectClass();
		Console.WriteLine("The highest generation is {0}", GC.MaxGeneration);
		//显示系统支持的当前代数
		myGCCol.MakeSomeGarbage();
		//调用MakeSomeGarbage方法制造一些内存垃圾
		Console.WriteLine("Generation:{0}", GC.GetGeneration(myGCCol));
		//显示myGCCol对象的代数
		Console.WriteLine("Total Memory:{0}", GC.GetTotalMemory(false));
		//

		GC.Collect(0);
		Console.WriteLine("Generation:{0}", GC.GetGeneration(myGCCol));
		Console.WriteLine("Total Memory:{0}", GC.GetTotalMemory(false));
		GC.Collect(2);
		Console.WriteLine("Generation:{0}", GC.GetGeneration(myGCCol));
		Console.WriteLine("Total Memory:{0}", GC.GetTotalMemory(false));
		Console.Read();
	}

	void MakeSomeGarbage()
	{
		Version vt;
		for (int i = 0; i < maxGarbage; i++)
		{
			vt = new Version();
		}
	}
}