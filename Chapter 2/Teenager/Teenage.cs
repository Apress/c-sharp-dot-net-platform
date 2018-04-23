using System;

class Teenager
{
	private Random r = new Random();

	// Two public methods for the teenager class
	// which both make use of a private helper function.
	public string Complain()
	{
		string[] messages = new string[5]{"Do I have to?",
										  "He started it!",
										  "I'm too tired...",
										  "I hate school!",
										  "You are sooo wrong."};
		return messages[GetRandomNumber(5)];
	}

	public string BeAgreeable()
	{
		string[] messages = new string[3]{"Sure!  No problem!",
										  "Uh uh.",
										  "I guess so."};
		return messages[GetRandomNumber(3)];
	}

	// Private function used to grab a random number.
	private int GetRandomNumber(short upperLimit)
	{
		// Return a random message.
		return r.Next(upperLimit);
	}

    public static void Main(string[] args)
    {
		// Let mike do his thing.
		Console.WriteLine("Mike says:");
		Teenager mike = new Teenager();
		for(int i = 0; i < 10; i++)
		{
			Console.WriteLine(mike.Complain());
		}

		// Let sue do her thing.
		Console.WriteLine("\n\nSue says:");
		Teenager sue = new Teenager();
		for(int i = 0; i < 10; i++)
		{
			Console.WriteLine(sue.BeAgreeable());
		}
    }
}

