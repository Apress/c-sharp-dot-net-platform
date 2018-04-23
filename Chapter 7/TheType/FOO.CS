// Here are the types we will
// ponder via reflection.
namespace TheType
{
public interface IFaceOne
{
	void MethodA();
}

public interface IFaceTwo
{
	void MethodB();
}

public class Foo: IFaceOne, IFaceTwo
{
	// Fields.
	public int myIntField;
	public string myStringField;

	// A method.
	public void myMethod(int p1, string p2)
	{
		// Some impl.
	}

	// A property.
	public int MyProp
	{
		get { return myIntField; }
		set { myIntField = value; }
	}

	// IFaceOne and IFaceTwo impl.
	public void MethodA() {}
	public void MethodB() {}
}
}