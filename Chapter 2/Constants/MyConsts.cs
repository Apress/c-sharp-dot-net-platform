namespace Constants
{
using System;

/*
class MyConstants 
{
	// Some const data.
	public const int myIntConst = 5;
	public const string myStringConst = "I'm a const";
	
	// Don't let the user make this class,
	// as its only purpose is to define
	// constant values.
	private MyConstants(){}
}
*/

// Abstract definition also prevent the creation of a given type.
abstract class MyConstants 
{
	// Some const data.
	public const int myIntConst = 5;
	public const string myStringConst = "I'm a const";
}

}