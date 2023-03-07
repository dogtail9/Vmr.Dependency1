namespace Vmr.Dependency1.UnitTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Calculator_Add()
        {
            // Arrange
            var arg1 = 1;
            var arg2 = 2;
            var expectedResult = 3;

            // Act
            var calculator = new Calculator();
            var result = calculator.Add(arg1, arg2);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}