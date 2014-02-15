using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzBuzz5
{
	[TestFixture]
	public class FizzBuzzerUnitTests
	{
		private FizzBuzzer _fb;

		[SetUp]
		public void Setup()
		{
			_fb = new FizzBuzzer();
		}

		[Test]
		public void FizzBuzzer_Instantiating_ShouldNotThrowAnException()
		{
			Assert.DoesNotThrow(() => new FizzBuzzer());
		}

		[Test]
		public void Convert_ValueNotDivisibleByThreeOrFive_ShouldReturnValue()
		{
			//Arrange
			int valueToConvert = 1;
			string expectedValue = "1";			

			//Act
			string result = _fb.Convert(valueToConvert);

			//Assert
			Assert.That(result, Is.EqualTo(expectedValue));
		}

		[Test]
		public void Convert_ValueDivisibleByThree_ShouldReturnFizz()
		{
			//Arrange
			int valueToConvert = 3;
			string expectedValue = "Fizz";

			//Act
			string result = _fb.Convert(valueToConvert);

			//Assert
			Assert.That(result, Is.EqualTo(expectedValue));
		}

		[Test]
		public void Convert_ValueDivisibleByFive_ShouldReturnBuzz()
		{
			//Arrange
			int valueToConvert = 5;
			string expectedValue = "Buzz";

			//Act
			string result = _fb.Convert(valueToConvert);

			//Assert
			Assert.That(result, Is.EqualTo(expectedValue));
		}

		[Test]
		public void Convert_ValueDivisibleByThreeAndFive_ShouldReturnFizzBuzz()
		{
			//Arrange
			int valueToConvert = 15;
			string expectedValue = "FizzBuzz";

			//Act
			string result = _fb.Convert(valueToConvert);

			//Assert
			Assert.That(result, Is.EqualTo(expectedValue));
		}
	}
}
