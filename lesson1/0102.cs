using System;

namespace SampleApp
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// bool canIVote = true;
			Console.WriteLine("Samllest Integer value: {0}", int.MinValue);
			Console.WriteLine("Biggest Integer value: {0}", int.MaxValue);
			Console.WriteLine("Smallest Long value: {0}", long.MinValue);
			Console.WriteLine("Biggest Long value: {0}", long.MaxValue);
			Console.WriteLine("Smallest Float value: {0}", float.MinValue);
			Console.WriteLine("Biggest Float value: {0}", float.MaxValue);
			Console.WriteLine("Smallest Double value: {0}", Double.MinValue);
			Console.WriteLine("Biggest Double value: {0}", Double.MaxValue);
			Console.WriteLine("Smallest Decimal value: {0}", Decimal.MinValue);
			Console.WriteLine("Biggest Decimal value: {0}", Decimal.MaxValue);

			// ---------- DATA TYPES ----------

			// Bools store true or false
			bool canIVote = true;

			// INTEGERS
			// Integers are 32-bit signed integers
			Console.WriteLine("Biggest Integer : {0}", int.MaxValue);
			Console.WriteLine("Smallest Integer : {0}", int.MinValue);

			// LONGS
			// Longs are 64-bit signed integers
			Console.WriteLine("Biggest Long : {0}", long.MaxValue);
			Console.WriteLine("Smallest Long : {0}", long.MinValue);

			// DECIMALS
			// Decimals store 128-bit precise decimal values
			// It is accurate to 28 digits
			decimal decPiVal = 3.1415926535897932384626433832M;
			decimal decBigNum = 3.00000000000000000000000000011M;
			Console.WriteLine("DEC : PI + bigNum = {0}", decPiVal + decBigNum);

			Console.WriteLine("Biggest Decimal : {0}", Decimal.MaxValue);

			// DOUBLES
			// Doubles are 64-bit float types
			Console.WriteLine("Biggest Double : {0}", Double.MaxValue.ToString("#"));

			// It is precise to 14 digits
			double dblPiVal = 3.14159265358979;
			double dblBigNum = 3.00000000000002;
			Console.WriteLine("DBL : PI + bigNum = {0}", dblPiVal + dblBigNum);

			// FLOATS
			// Floats are 32-bit float types
			Console.WriteLine("Biggest Float : {0}", float.MaxValue.ToString("#"));

			// It is precise to 6 digits
			float fltPiVal = 3.141592F;
			float fltBigNum = 3.000002F;
			Console.WriteLine("FLT : PI + bigNum = {0}", fltPiVal + fltBigNum);

			// Other Data Types
			// byte : 8-bit unsigned int 0 to 255
			// char : 16-bit unicode character
			// sbyte : 8-bit signed int 128 to 127
			// short : 16-bit signed int -32,768 to 32,767
			// uint : 32-bit unsigned int 0 to 4,294,967,295
			// ulong : 64-bit unsigned int 0 to 18,446,744,073,709,551,615
			// ushort : 16-bit unsigned int 0 to 65,535

			// You can convert from string to other types with Parse
			bool boolFromStr = bool.Parse("True");
			int intFromStr = int.Parse("100");
			double dblFromStr = double.Parse("1.234");
			
		}
	}
}
‚