using System;
using System.Threading;
class test
{
	static void Main()
	{
		int x, y;
		x = Int32.Parse(Console.ReadLine());
		y = Int32.Parse(Console.ReadLine());
		Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
		Console.ReadLine();

	}
}