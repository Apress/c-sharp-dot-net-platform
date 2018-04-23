namespace CustomSerialization
{
    using System;
	using System.Runtime.Serialization;

	[Serializable]
    public class CustomCarType : ISerializable
    {
		public string petName;
		public int maxSpeed;

        public CustomCarType(string s, int i)
        { petName = s; maxSpeed = i;}

		// Impl of ISerializable interface
		public void GetObjectData(SerializationInfo si, StreamingContext ctx)
		{
			// What context is the stream?
			Console.WriteLine("[GetObjectData] Context State: " + ctx.State.ToString());

			// Fill the SerializationInfo type with out info.
			si.AddValue("CapPetName", petName);
			si.AddValue("maxSpeed", maxSpeed);
		}

		// You must supply a custom ctor with this signature
		// to allow the runtime engine to
		// set the state of your object.
		private CustomCarType(SerializationInfo si, StreamingContext ctx)
		{
			// What context is the stream?
			Console.WriteLine("[ctor] Context State: " + ctx.State.ToString());

			// Re-hydrate a new object based on incoming 
			// SerializationInfo type.
			petName = si.GetString("CapPetName");
			maxSpeed = si.GetInt32("maxSpeed");
		}
    }
}
