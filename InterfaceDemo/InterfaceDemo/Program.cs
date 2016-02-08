using System;
using System.Collections.Generic;

namespace InterfaceDemo
{
	class FourFuncs
	{
		public float Add(float a, float b){ return a + b;}
		public float Subtract(float a, float b){ return a - b;}
		public float Multiply(float a, float b){ return a * b;}
		public float Divide(float a, float b){ return a / b;}

	}

	class Calculator: FourFuncs, IStats
	{
		public int Remainder(int a, int b){return a % b;}

		public float Average (List<float> numbers)
		{
			float total = 0;
			foreach (float n in numbers)
				total += n;
			return total / numbers.Count;
		}

		public float Max (List<float> numbers)
		{
			throw new NotImplementedException ();
		}
	}

	interface IStats
	{
		float Average (List<float> numbers);
		float Max (List<float> numbers);
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			Calculator calc = new Calculator ();
			Console.WriteLine ("2 + 2 = " + calc.Add(2,2).ToString());
			Console.WriteLine (string.Format("Average of 3, 4, 5 is {0}", calc.Average(new List<float>(){3,4,5})));
		}
	}
}
