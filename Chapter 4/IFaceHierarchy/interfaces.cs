namespace IFaceHierarchy
{
using System;

	interface IDraw
	{
		void Draw();
	}

	interface IDraw2 : IDraw
	{
		void DrawToPrinter();
	}

	interface IDraw3 : IDraw2
	{
		void DrawToMetaFile();
	}

	interface IBasicCar
	{
		void Drive();
	}

	interface IUnderwaterCar
	{
		void Dive();
	}

	interface IJamesBondCar : IBasicCar, IUnderwaterCar
	{
		void TurboBoost();
	}

}
