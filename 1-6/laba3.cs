using System;
				
public class MyClassA
{
	int a, b;
	public MyClassA(int a, int b)
	{
		this.a = a;
		this.b = b;
	}
	public int A
	{
		get { return a; }
	}
	public int B
	{
		get { return b; }
	}
	public float C0
	{
		get { a *= b; return a; }
	}
	public float C1
	{
		get { return ++a; }
	}
	public float C2
	{
		get { return a/b; }
	}
}


public class MyClassB: MyClassA
{
	int d;
	float[] array;
	
	public MyClassB(int a, int b, int d): base(a, b)
	{
		this.d = d;
	}
	public MyClassB(): this(3, 4, 5)
	{
		this.d = 5;
	}
	public MyClassB(int a): this(a, 2, -7)
	{
		this.d = -7;
		array = new float[A];
		for(int i = 0; i < A; i++)
		{
			array[i] = C3 * i;
		}
	}
	public int D
	{
		get { return d; }
	}
	public int C3
	{
		get {
			for(int i=0; i < 3; i++)
			{
				d -= A + B;
			}
			return d;
		}
	}
	public float[] Array
	{
		get { return array; }
	}
}


public class Program
{
	public static void Main()
	{
		MyClassB ObjectB = new MyClassB(7);
		foreach(float e in ObjectB.Array) Console.WriteLine(e);
	}
}