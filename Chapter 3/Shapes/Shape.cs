namespace Shapes
{
using System;

// Abstract base class.
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

public class Circle : Shape
{
    public Circle(){}

	// Call base class constructor.
	public Circle(string name): base(name){}

	public override void Draw()
	{
		Console.WriteLine("Drawing " + PetName + " the Circle");
	}
}

public class Oval : Circle
{
    public Oval(){base.PetName = "Joe";}

	// Hide base class impl if they create an Oval.
	new public void Draw()
	{
		Console.WriteLine("Drawing an Oval using a very fancy algorithm");
	}
}

public class Hexagon : Shape
{
    public Hexagon(){}
	public Hexagon(string name): base(name){}

	public override void Draw()
	{
		Console.WriteLine("Drawing " + PetName + " the Hexagon");
	}
}

}
