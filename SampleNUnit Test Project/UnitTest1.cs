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
                WeightStones = 11,
                WeightPounds = 28,
                HeightFeet = 1,
                HeightInches = 36,
            };
            double ExpectedBMI = 12.816362091057519;
            double ActualBMI = BMITest.BMIValue;

            Assert.AreEqual(ExpectedBMI, ActualBMI);
        }
        [Test]
        public void TestBMINormal() // unit test for Normal BMI function 
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
        [Test]
        public void TestBMIOverweight() //unit test for Overweight BMI function
        {
            BMICalculator.BMI BMITest = new BMICalculator.BMI
            {
                WeightStones = 12,
                WeightPounds = 56,
                HeightFeet = 6,
                HeightInches = 82,
            };
            BMICategory expected = BMICategory.Overweight;
            BMICategory actual = BMITest.BMICategory;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestBMIObese() // unit test for Obese BMI function 
        {
            BMICalculator.BMI BMITest = new BMICalculator.BMI
            {
                WeightStones = 2,
                WeightPounds = 56,
                HeightFeet = 4,
                HeightInches = 72,
            };
            BMICategory expected = BMICategory.Obese;
            BMICategory actual = BMITest.BMICategory;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestBMIUnderweight() // unit test for Underweight BMI function 
        {
            BMICalculator.BMI BMITest = new BMICalculator.BMI
            {
                WeightStones = 2,
                WeightPounds = 56,
                HeightFeet = 4,
                HeightInches = 72,
            };
            BMICategory expected = BMICategory.Underweight;
            BMICategory actual = BMITest.BMICategory;

            Assert.AreEqual(expected, actual);
        }
    }
}
    