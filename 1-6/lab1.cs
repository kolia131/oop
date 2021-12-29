using System;
				
public class MyClassA
{
	float a = 2.3F;
	float b = 4.9F;
	
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


public class Program
{
	public static void Main()
	{
		MyClassA MyObject = new MyClassA();
		Console.WriteLine(string.Format("C0 result: {0}\nC1 result: {1}\nC2 result: {2}\n", 
										MyObject.C0, MyObject.C1, MyObject.C2));
	}
}