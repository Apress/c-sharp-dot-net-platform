namespace Shapes
{
	using System;

	// The pointy behavior.
	public interface IPointy
	{
		byte GetNumberOfPoints();

		// interface can also have properties...
	    // byte Points{get; set;}
	}


// The 3D drawing behavior.
public interface IDraw3D
{
	 void Draw();
}

// Base class.
public abstract class Shape
{
	protected string petName;
    
	// Constructors.
	public Shape(){petName = "NoName";}
	public Shape(string s)
	{
		this.petName = s;
	}
	
	// All child objects must define for themselves what
	// it means to be drawn.
	public abstract void Draw();

	public string PetName
	{
		get {return this.petName;}
		set {this.petName = value;}
	}
}

public class Circle : Shape, IDraw3D
{
    public Circle(){}

	// Call base class constructor.
	public Circle(string name): base(name)
	{}

	public override void Draw()
	{
		Console.WriteLine("Drawing " + PetName + " the Circle");
	}
	void IDraw3D.Draw()
	{
		Console.WriteLine("Drawing Circle in 3D!");
	}
}

public class Hexagon : Shape, IPointy, IDraw3D
{
    public Hexagon(){}
	public Hexagon(string name): base(name)
	{}
	public override void Draw()
	{
		Console.WriteLine("Drawing " + PetName + " the Hexagon");
	}

	public byte GetNumberOfPoints()
	{
		return 6;
	}
	
	void IDraw3D.Draw()
	{
		Console.WriteLine("Drawing Hexagon in 3D!");
	}
}

public class Triangle : Shape, IPointy
{
    public Triangle(string name): base(name)
	{}
	public Triangle()
	{}

	public override void Draw()
	{
		Console.WriteLine("Drawing " + PetName + " the Triangle");
	}

	public byte GetNumberOfPoints()
	{
		return 3;
	}
}

public class Oval : Circle
{
    public Oval(){base.PetName = "Joe";}

	new public void Draw()
	{
		Console.WriteLine("Drawing an Oval using a very fancy algorithm");
	}
}

public class Line : Shape, IDraw3D
{
	void IDraw3D.Draw()
	{
		Console.WriteLine("Drawing a 3D line...");
	}
	public override void Draw()
	{
		Console.WriteLine("Drawing a line...");
	}
}
}
