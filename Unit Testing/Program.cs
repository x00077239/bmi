//using NUnit.Framework;
//using BMICalculator;

//namespace Tests
//{
//    public class Tests
//    {
//        [SetUp]
//        public void Setup()
//        {
//        }

//        [Test]
//        public void TestBMIValue()
//        {
//            BMICalculator.BMI BMITest = new BMICalculator.BMI
//            {
//                WeightStones = 1,
//                WeightPounds = 1,
//                HeightFeet = 1,
//                HeightInches = 1,
//            };
//            double ExpectedBMI = 52;
//            double ActualBMI = BMITest.BMIValue;

//            Assert.AreEqual(ExpectedBMI, ActualBMI);
//        }
//        [Test]
//        public void TestBMINormal()
//        {
//            BMICalculator.BMI BMITest = new BMICalculator.BMI
//            {
//                WeightStones = 1,
//                WeightPounds = 1,
//                HeightFeet = 1,
//                HeightInches = 1,
//            };
//            BMICategory expected = BMICategory.Normal;
//            BMICategory actual = BMITest.BMICategory;

//            Assert.AreEqual(expected, actual);
//        }
//        [Test]
//        public void TestBMIUnderweight()
//        {
//            BMICalculator.BMI BMITest = new BMICalculator.BMI
//            {
//                WeightStones = 1,
//                WeightPounds = 1,
//                HeightFeet = 1,
//                HeightInches = 1,
//            };
//            BMICategory expected = BMICategory.Underweight;
//            BMICategory actual = BMITest.BMICategory;

//            Assert.AreEqual(expected, actual);
//        }
//        [Test]
//        public void TestBMIOverweight()
//        {
//            BMICalculator.BMI BMITest = new BMICalculator.BMI
//            {
//                WeightStones = 1,
//                WeightPounds = 1,
//                HeightFeet = 1,
//                HeightInches = 1,
//            };
//            BMICategory expected = BMICategory.Overweight;
//            BMICategory actual = BMITest.BMICategory;

//            Assert.AreEqual(expected, actual);
//        }
//        [Test]
//        public void TestBMIObese()
//        {
//            BMICalculator.BMI BMITest = new BMICalculator.BMI
//            {
//                WeightStones = 1,
//                WeightPounds = 1,
//                HeightFeet = 1,
//                HeightInches = 1,
//            };
//            BMICategory expected = BMICategory.Obese;
//            BMICategory actual = BMITest.BMICategory;

//            Assert.AreEqual(expected, actual);
//        }
//    }
