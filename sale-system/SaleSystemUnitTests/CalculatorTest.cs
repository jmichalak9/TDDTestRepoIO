
using System;
using Xunit;
using sale_system;

namespace SaleSystemUnitTests
{
	public class CalculatorTest
	{
		[Theory]
		[InlineData("", 0)]
		[InlineData(null, 0)]
		[InlineData("4", 4)]
		[InlineData("4,5", 9)]
		[InlineData("4\n5", 9)]
		[InlineData("1\n3,5", 9)]
		[InlineData("1,3,5", 9)]
		[InlineData("1,3\n5", 9)]
		[InlineData("1\n3\n5", 9)]
		[InlineData("0", 0)]
		[InlineData("1000", 1000)]
		[InlineData("//*4*5", 9)]
		[InlineData("//*4,5", 9)]
		[InlineData("//*4\n5", 9)]
		[InlineData("//*1*5\n3", 9)]
		[InlineData("//*1,5*3", 9)]
		[InlineData("//[*?!]1*?!5*?!3", 9)]
		[InlineData("//[*?!]1\n5*?!3", 9)]
		[InlineData("//[*?!]1*?!5,3", 9)]
		[InlineData("//[*?!]1,5\n3", 9)]
		[InlineData("//[*?!][^$#]1,5^$#3", 9)]
		[InlineData("//[*?!][^$#]1*?!5^$#3", 9)]
		[InlineData("//[*?!][^$#]1*?!5^$#3\n122", 131)]
		public void AddTest(string value, int expected)
		{
			Assert.Equal(expected, Calculator.Add(value));
		}

		[Theory]
		[InlineData("-1")]
		[InlineData("1001")]
		[InlineData("//[*?!]1*5,3")]
		[InlineData("//[*?!]1*5*?!3")]
		public void AddError(string value)
		{
			Assert.Throws<ArgumentException>(() => Calculator.Add(value));
		}
	}
}
