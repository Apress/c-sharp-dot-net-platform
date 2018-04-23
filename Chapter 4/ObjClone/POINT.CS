namespace ObjClone
{
using System;

// The Point class supports deep copy
// semantics ala ICloneable.
public class Point : ICloneable
{
	// State data.
	public int x, y;

	// Ctors.
    public Point(){}
	public Point(int x, int y)
    {this.x = x; this.y = y;}


	// The sole method of ICloneable.
	public object Clone()
	{
		return new Point(this.x, this.y);
	}

	// Override Object.ToString().
	public override string ToString()
	{
		return "X: " + x + " Y: " + y;
	}
}
}
