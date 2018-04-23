namespace CustomAtt
{
using System;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class VehicleDescriptionAttribute : System.Attribute
{
	private string description;
	public string Desc
	{
		get { return description; }
		set { description = value; }
	}

    public VehicleDescriptionAttribute() {}
	public VehicleDescriptionAttribute(string desc) 
	{ description = desc;}
}
}
