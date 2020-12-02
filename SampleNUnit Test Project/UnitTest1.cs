using BMICalculator;
using NUnit.Framework;

namespace SampleNUnit_Test_Project
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [SetUp]
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
        public void TestBMIValue()
        {
            BMICalculator.BMI BMITest = new BMICalculator.BMI
            {
                WeightStones = 1,
                WeightPounds = 28,
                HeightFeet = 1,
                HeightInches = 36,
            };
            double ExpectedBMI = 12.816362091057519;
            double ActualBMI = BMITest.BMIValue;

            Assert.AreEqual(ExpectedBMI, ActualBMI);
        }
        [Test]
        public void TestBMINormal()
        {
            BMICalculator.BMI BMITest = new BMICalculator.BMI
            {
                WeightStones = 2,
                WeightPounds = 56,
                HeightFeet = 4,
                HeightInches = 72,
            };
            BMICategory expected = BMICategory.Normal;
            BMICategory actual = BMITest.BMICategory;

            Assert.AreEqual(expected, actual);
        }
    }
}
    