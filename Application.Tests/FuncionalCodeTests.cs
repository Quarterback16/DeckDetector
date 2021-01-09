using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Application.Tests
{
	[TestClass]
	public class FuncionalCodeTests
	{
		[TestMethod]
		public void TheFunctionObject()
		{
			Func<int, int> f = (x) => x + 2;
			int i = f(1);
			Console.WriteLine(i);
			f = (x) => 2 * x + 1;
			i = f(1);
			Console.WriteLine(i);
		}

		[TestMethod]
		public void FunctionalRecursion()
		{
			int inputNumber = 7;
			IEnumerable<int> ints = Enumerable.Range(
				1, 
				inputNumber);
			int factorialNumber = ints.Aggregate((f, s) => f * s);
			Console.WriteLine(
				"{0}! is {1}",
				inputNumber,
				factorialNumber);
		}

		[TestMethod]
		public void CurriedAdd()
		{
			Func<int, int> CurriedAdd(int a) => b => a + b;

			int add = CurriedAdd(2)(3);
			Console.WriteLine(add);
		}

		[TestMethod]
		public void CurriedAdd2()
		{
			Func<int, int> CurriedAdd(int a) => b => a + b;

			var addition = CurriedAdd(2);  // returns a function object
			int x = addition(3);
			Console.WriteLine(x);
			Assert.AreEqual(5, x);
		}

		[TestMethod]
		public void MethodChaining()
		{
			var str =
				new StringBuilder(
						value: "0123",
						capacity: 10)
					.Append(
						value: new char[] { '4', '5', '6' })
					.AppendFormat(
						"{0}{1}{2}",
						7, 
						8, 
						9)
					.Insert(
						index: 0,
						value: "number: ")
					.Replace(
						oldChar: 'n',
						newChar: 'N')
				.ToString();
			Console.WriteLine(str);

			Assert.AreEqual("Number: 0123456789", str);
		}
	}
}
