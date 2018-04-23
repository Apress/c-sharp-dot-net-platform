namespace OverLoadOps
{
using System;

public class Point
{
	public int x, y;

    public Point(){}
	
	public Point(int xPos, int yPos)
	{
		x = xPos;
		y = yPos;
	}
	
	// The Point class has overloaded the + and - operators.
	public static Point operator + (Point p1, Point p2)
	{
		return AddPoints(p1, p2);
	}

	// Operator + as AddPoints()
	public static Point AddPoints (Point p1, Point p2)
	{
		return new Point(p1.x + p2.x, p1.y + p2.y);
	}
	
	// Operator - as SubtractPoints()
	public static Point SubtractPoints (Point p1, Point p2)
	{
		// Figure new X.
		int newX = p1.x - p2.x;
		if(newX < 0)
			throw new ArgumentOutOfRangeException();

		// Figure new Y.
		int newY = p1.y - p2.y;
		if(newY < 0)
			throw new ArgumentOutOfRangeException();

		return new Point(newX, newY);
	}


	public static Point operator - (Point p1, Point p2)
	{
		return SubtractPoints(p1, p2);
	}
	
	// Override some Object methods.
	public override bool Equals(object o)
	{
		// Does the incoming object
		// have the same values as me?
		if( ((Point)o).x == this.x &&
		    ((Point)o).y == this.y)
		{
			return true;
		}
		else
			return false;
	}

	public override int GetHashCode()
	{
		return this.ToString().GetHashCode();
	}

	// Now let's overload the == and != operators.
	public static bool operator ==(Point p1, Point p2)
	{
		return p1.Equals(p2);
	}

	public static bool operator !=(Point p1, Point p2)
	{	
		return !p1.Equals(p2);
	}

	// Object override.
	public override string ToString()
	{
		return "X pos: " + this.x + " Y pos: " + this.y;
	}
}
}
