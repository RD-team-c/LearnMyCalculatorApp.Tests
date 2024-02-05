namespace LearnMyCalculatorApp.Tests
{

	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using LearnMyCalculatorApp;


	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void CalculatorNullTest()
		{
			var calculator = new Calculator();
			Assert.IsNotNull(calculator);
		}

		[TestMethod]
		public void AddTest()
		{
			// Arrange
			var calculator = new Calculator();

			// Act
			var actual = calculator.Add(1, 1);

			// Assert
			Assert.AreEqual(2, actual);
		}
		[TestMethod]
		public void SubtractTest()
		{
			var calculator = new Calculator();
			var actual = calculator.Subtract(1, 1);
			Assert.AreEqual(0, actual);
		}
		[TestMethod]
		public void MultiplyTest()
		{
			var calculator = new Calculator();
			var actual = calculator.Multiply(1, 1);
			Assert.AreEqual(1, actual);
		}
		[TestMethod]
		public void DivideTest()
		{
			var calculator = new Calculator();
			var actual = calculator.Divide(4, 2);
			Assert.AreEqual(2, actual);
		}
		[TestMethod]
		public void DivideByZeroTest()
		{
			var calculator = new Calculator();
			var actual = calculator.Divide(2, 0);
			Assert.AreEqual(null, actual);
		}
	}

}