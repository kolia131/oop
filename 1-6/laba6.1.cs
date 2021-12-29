using System;
				
public class B
{
    private int a;
    private int b;
    public B(int a, int b)
    {
        this.a = a;
        this.b = b;
    }
    public static bool operator true(B obj)
    {
        return (obj.a>0 && obj.b>0);
    }
    public static bool operator false(B obj)
    {
        return (obj.a<0 || obj.b<0);
    }
    public static bool operator !(B obj)
    {
        if(obj)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}


public class Program
{
	public static void Main()
	{
		B test1 = new B(2, 4);
		if (test1)
		{
		    Console.WriteLine("true");
		}
		else
		{
		     Console.WriteLine("false");
		}
		if (!test1)
		{
		    Console.WriteLine("true");
		}
		else
		{
		     Console.WriteLine("false");
		}
		
		B test2 = new B(2, -4);
		if (test2)
		{
		    Console.WriteLine("true");
		}
		else
		{
		     Console.WriteLine("false");
		}
		if (!test2)
		{
		    Console.WriteLine("true");
		}
		else
		{
		     Console.WriteLine("false");
		}
	}
}