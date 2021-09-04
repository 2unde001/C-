using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BeakonhubLearningTest
{
    [TestClass]
    public class LogicalOperatorTest
    {
        [TestMethod]
        public void AdditionTest()
        {
            var a = 10;
            var b = 20;

            var result = a + b;

            Console.WriteLine("Addition", a + b);

            Assert.AreEqual(30,result);

        }

        [TestMethod]
        public void DivisionTest() 
        {
            var c = 3;
            var d = 7;

            Assert.AreEqual(2,3, d/c);
        }

        [TestMethod]
        public void OperatorPrecedenceTest() 
        {
            var a = 4;
            var b = 6;
            var c = 10;

            // Multiplication and division take precedence over addition and minus
            // Multiply b by c first and add the result to a
            Assert.AreEqual(64, a + b * c);
      
        }

        [TestMethod]
        public void OperatorPrecedenceUnchangedTest()
        {
            var a = 4;
            var b = 6;
            var c = 10;

            // Add parenthesis to values you want to take higer or highest precedence
            // Add a + b and multiply the resuly by c
            Assert.AreEqual(100, (a + b) * c);

        }

        [TestMethod]
        public void ComparisonOperatorGreaterThanTest()
        {
            // Change the value of a or b for negative test
            var a = 4;
            var b = 6;
            Assert.IsTrue(b > a);

        }

        [TestMethod]
        public void ComparisonOperatorLessThanTest()
        {
            // Change the value of a or b for negative test
            var a = 4;
            var b = 6;
            Assert.IsTrue(a < b);

        }

        [TestMethod]
        public void ComparisonOperatorEqualsTest()
        {
            // Change the value of a or b for negative test
            var a = 4;
            var b = 4;

            
            Assert.IsTrue(a == b);

        }

        [TestMethod]
        public void ComparisonOperatorNotEqualsTest()
        {
            // Change the value of a or b for negative test
            
            var a = 4;
            var b = 6;


            Assert.IsTrue(a !=b);

        }

     
        [TestMethod]
        public void ThreeWayComparisonOperatorGreaterThanTest()
        {
            // Change the value of a or b for negative test

            var a = 4;
            var b = 6;
            var c = 9;

            // True and True = True
            Assert.IsTrue(c > b && b > a);

        }

        [TestMethod]
        public void ThreeWayComparisonOperatorGreaterThanAndEqualToTest()
        {
            // Change the value of a or b for negative test

            var a = 4;
            var b = 6;
            var c = 9;

            // True and False = False
            Assert.IsFalse(c > b && b == a);

        }

        [TestMethod]
        public void ThreeWayComparisonOROperatorGreaterThanAndEqualTest()
        {
            // Change the value of a or b for negative test

            var a = 4;
            var b = 6;
            var c = 9;

            // True OR False = True
            Assert.IsTrue(c > b || b == a);

        }

        [TestMethod]
        public void ThreeWayComparisonNOTOperatorGreaterThanAndEqualTest()
        {
            // Change the value of a or b for negative test

            var a = 4;
            var b = 6;
            var c = 9;

            // False OR True  = False
            Assert.IsFalse(!(c > b || b == a));

        }
    }
}
