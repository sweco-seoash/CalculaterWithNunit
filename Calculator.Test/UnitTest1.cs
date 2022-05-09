using Calculater;
using CalculatorWithNunit;
using NUnit.Framework;
using System;



namespace Calculator1
{
    [TestFixture]
    public class Tests
    {
        private Calculator calculator;
        [SetUp]
        public void TestSetup()
        {
            // new product
            // result = false;
            calculator = new Calculator();
            Console.WriteLine("Before Test");
        }
        [TearDown]
        public void TestTearDown()
        {
            // product = null
            // result = false;
            Console.WriteLine("After Test");
        }
        [Test]
        public void SetupTest1()
        {
            Console.WriteLine("Test 1");
        }
        [Test]
        public void SetupTest2()
        {
            Console.WriteLine("Test 2");
        }
        public void Method_Scenario_ExpectedOutcome()
        {
            
            // Assign
            // Act
            // Assert(expected, actual)
        }
        [Test, Order(1)]
        //[Ignore("Boken code")]
        public void ButtonCE_GetZero_AreEqualToZero()
        {
            var expected = new Calculator();
            string zero = "";
            string actual = expected.ButtonCE(zero);
            Assert.AreEqual("0", actual); // Classic Model
            Assert.That(actual, Is.EqualTo("0")); // Constraint Model
            Console.WriteLine("Are equal to zero");
        }
        
        [Test, Order(2)]
        public void Method_Scenario_AreNotEqual()
        {
            Calculator expected = new Calculator();
            Console.WriteLine("Are not equal");
            //Assert.AreNotEqual();
        }
        [Test]
        public void ButtonSum_Operation_IsTrue()
        {
            Calculator expected = new Calculator();

            //Assert.IsTrue();            
        }
        [Test]
        public void Buttons_ReturnFalse_IsFalse()
        {
            Calculator expected = new Calculator();
            bool operation = false; // kan sättas till både true or false, påverkar inte resultatet men måste initeras för att få ett argument till metoden Button
            var actual = expected.Buttons(operation);
            Assert.IsFalse(actual);
            Assert.That(actual, Is.False);
        }
        [Test]
        public void ButtonCE_GetZero_IsNull()
        {
            Calculator expected = new Calculator();

            //Assert.IsNull();
        }
        [Test]
        public void ButtonCE_GetZero_ISNotNull()
        {
            Calculator expected = new Calculator();
            string zero = "";
            string actual = expected.ButtonCE(zero);
            Assert.IsNotNull(actual);
        }
        [Test]
        public void Method_Scenario_IsNaN()
        {

        }
        [Test]
        public void Method_Scenario_Contains()
        {

        }










        // Jämförelse med xUnit
        // Nunit kör alla testerna efter varandra
        // Test2 kan inte bli 1
        private int myInt = 0;
        [Test]
        public void Test1()
        {
            myInt++;
            Assert.IsTrue(1 == myInt);
            //Assert.AreEqual(1, myInt);
            //Assert.That(myInt, Is.EqualTo(1));
        }
        [Test]
        public void Test2()
        {
            myInt++;
            Assert.That(myInt, Is.EqualTo(1));
        }




















        // En jämnförelse med Xunit
        [Test]
        public void PassingTest()
        {
            TestClass calc = new TestClass();
            Assert.AreEqual(4, calc.Add(2, 2));
        }
    }
}