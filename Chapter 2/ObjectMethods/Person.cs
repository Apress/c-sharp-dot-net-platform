using System;
using System.Text;

class Person
{
    public Person(string fname, string lname, string ssn, byte a)
    {
		FirstName = fname;
		LastName = lname;
		SSN = ssn;
		age = a;
    }

	// The state of the person.
	public string FirstName;
	public string LastName;
	public string SSN;
	public byte age;

	// Override some Object methods.
	public override bool Equals(object o)
	{
		// Does the incoming object
		// have the same values as me?
		Person temp = (Person)o;
		if(temp.FirstName == this.FirstName &&
		   temp.LastName == this.LastName &&
		   temp.SSN == this.SSN &&
		   temp.age == this.age)
		{
			return true;
		}
		else
			return false;
	}

	public override string ToString()
	{
		StringBuilder sb = new StringBuilder();
		sb.Append("[FirstName=" + this.FirstName);
		sb.Append(" LastName=" + this.LastName);
		sb.Append(" SSN=" + this.SSN);
		sb.Append(" Age=" + this.age + "]");
		return sb.ToString();
	}

	public override int GetHashCode()
	{
		return SSN.GetHashCode();
	}
}
