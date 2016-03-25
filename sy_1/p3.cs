using System;
delegate void D(int x);
class C {
	public static void F1(int i) {
		Console.WriteLine("C.F1: " + i);
	}

	public static void F2(int i)
	{
		Console.WriteLine("C.F2: " + i);
	}

	public void F3(int i) 
	{
		Console.WriteLine("C.F3: " + i);
	}
}

class Test {
	static void Main()
	{
		D d1 = new D(C.F1);
		d1(1);
		D d2 = new D(C.F2);
		d2(2);
		D d3 = d1 + d2;
		d3(3);
		d3 += d1;
		d3(4);
		C c = new C();
		D d4 = new D(c.F3);
		d3 += d4;
		d3(5);
		d3 -= d1;
		d3(6);
		d3 -= d4;
		d3(7);
		d3 -= d2;
		d3(8);
		d3 -= d2;
		d3(9);
		d3 -= d1;
		d3 -= d1;
	}
}