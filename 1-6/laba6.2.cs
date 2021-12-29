using System;
using System.Collections;

public interface IGeometricFigure
{
    double Area{get;}
    string About();
}

public class ArrayOfFigures: IEnumerable
{
    string[] figures;
    public ArrayOfFigures(string[] gf)
    {
        figures = gf;
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return figures.GetEnumerator();
    }
}

public class Square: IGeometricFigure
{
    private int side;
    public Square(int side)
    {
        this.side = side;
    }
    public int Side
    {
       get {return side;}
    }
    public double Area
    {
        get {return Side*Side;}
    }
    public int Perimetr
    {
        get {return 4*Side;}
    }
    public string About()
    {
        string s = "Сторона квадрата: " + Side + "\n";
        string p = "Периметр квадрата: " + Perimetr + "\n";
        string a = "Площадь квадрата: " + Area + "\n";
        return "\n" + s + p + a;
    }
}

public class Circle: IGeometricFigure
{
    private int radius;
    private string color;
    public Circle(int radius, string color)
    {
        this.radius = radius;
        this.color = color;
    }
    public int Radius
    {
       get {return radius;}
    }
    public string Color
    {
       get {return color;}
    }
    public double Area
    {
        get {return 3.14*radius*radius;}
    }
    public string About()
    {
        string r = "Радиус круга: " + Radius + "\n";
        string c = "Цвет круга: " + Color + "\n";
        string a = "Площадь круга: " + Area + "\n";
        return "\n" + r + c + a;
    }
}

public class Program
{
	public static void Main()
	{
	    Square f1 = new Square(5);
	    Square f2 = new Square(8);
	    Circle f3 = new Circle(3, "red");
	    Circle f4 = new Circle(7, "green");
	    string[] figures = new string[] {f1.About(), 
	                                     f2.About(), 
	                                     f3.About(), 
	                                     f4.About()};
	    
	    ArrayOfFigures arr = new ArrayOfFigures(figures);
	    foreach (string a in arr)
	    {
	        Console.WriteLine(a);
	    }
	}
}