using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz5
{
	public class FizzBuzzer
	{
		public string Convert(int valueToConvert)
		{
			bool isFizz = valueToConvert % 3 == 0;
			bool isBuzz = valueToConvert % 5 == 0;

			if (isFizz && isBuzz)
				return "FizzBuzz";
			if (isFizz)
				return "Fizz";
			if (isBuzz)
				return "Buzz";

			return valueToConvert.ToString();
		}
	}
}
