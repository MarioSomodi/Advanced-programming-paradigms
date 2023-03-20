namespace StringCalculator.Test;

[TestClass]
public class UnitTestStringCalculator
{
    IStringCalculator _stringCalculator = new StringCalculator();
    [TestMethod]
    public void TestStringCalculatorResultWithEmptyString()
    {
        Assert.AreEqual(0, _stringCalculator.Add(""));
    }

    [TestMethod]
    public void TestStringCalculatorResultWithStringContainingOneNumber()
    {
        Assert.AreEqual(4, _stringCalculator.Add("4"));
    }

    [TestMethod]
    public void TestStringCalculatorResultWithStringContainingTwoNumber()
    {
        Assert.AreEqual(9, _stringCalculator.Add("4,5"));
    }

    [TestMethod]
    public void TestStringCalculatorResultWithStringContainingAsManyNumber()
    {
        Assert.AreEqual(43, _stringCalculator.Add("4,5,6,7,4,7,4,6"));
    }

    [TestMethod]
    public void TestStringCalculatorResultWithStringContainingAsManyNumberAsWellAsNewLines()
    {
        Assert.AreEqual(30, _stringCalculator.Add("5,5,5\n5,5\n5"));
    }

    [TestMethod]
    public void TestStringCalculatorResultWithChangeOfDelimiter()
    {
        Assert.AreEqual(30, _stringCalculator.Add("\\;\n5;5;5\n5;5\n5"));
    }

    [TestMethod]
    public void TestStringCalculatorResultWithNegativeNumbers()
    {
        try
        {
            _stringCalculator.Add("\\;\n5;5;5\n5;5\n5;-5;-6;-7");
            Assert.Fail("An exception should have been thrown");
        }
        catch (Exception ex)
        {
            Assert.AreEqual("negatives not allowed: -5;-6;-7", ex.Message);
        }
    }

    [TestMethod]
    public void TestIfStringCalculatorIgnoresNumbersBiggerThan1000()
    {
        Assert.AreEqual(30, _stringCalculator.Add("\\;\n5;5;5\n5;5\n5;1001"));
    }
}