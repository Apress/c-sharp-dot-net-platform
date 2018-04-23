using System;

[assembly:System.CLSCompliantAttribute(true)]

namespace CustomAtt
{
	[VehicleDescription("A very long, slow but feature rich auto")]
    public class Winnebago
    {
        public Winnebago()
        {
        }

		// Uncomment to generate error...
		// public ulong notCompliant;
    }
}
