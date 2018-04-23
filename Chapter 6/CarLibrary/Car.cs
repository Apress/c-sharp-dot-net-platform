namespace CarLibrary
{
using System;
using System.Windows.Forms;

// Holds the state of the engine.
public enum EngineState
{
	engineAlive,
	engineDead
}

// Holds source of music.
public enum MusicMedia
{
	musicCD,
	musicTape,
	musicRadio
}

//The abstract base class for the hierarchy.
public abstract class Car
{
	// State data.
	protected string petName;
	protected short currSpeed;
	protected short maxSpeed;
	protected EngineState egnState;

    // Ctors.
	public Car(){egnState = EngineState.engineAlive;}
	public Car(string name, short max, short curr)
	{
		egnState = EngineState.engineAlive;
		petName = name; maxSpeed = max; currSpeed = curr;
	}

	// Properties.
	public string PetName
	{
		get { return petName; }
		set { petName = value; }
	}
	public short CurrSpeed
	{
		get { return currSpeed; }
		set { currSpeed = value; }
	}
	public short MaxSpeed
	{
		get { return maxSpeed; }
	}
	
	public EngineState EngineState
	{
		get { return egnState; }
	}

	// Abstract member.
	public abstract void TurboBoost();

	// Inherited method.
	public void TurnOnRadio(bool state, MusicMedia mm)
	{
		if(state)
			MessageBox.Show("Jamming " + mm.ToString());
		else
			MessageBox.Show("Quiet time...");
	}
}
}
