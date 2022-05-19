using Calculater;
using CalculatorWithNunit;
using NUnit.Framework;
using System;
using System.Threading.Tasks;
//https://xunit.net/docs/comparisons - Jämförelser


namespace Calculator1
{
    [TestFixture, Description("En kommentar")]
    public class Tests
    {
        //-----------------SETUP/TEARDOWN----------------------------------//
        private Calculator calculator { get; set; }
        private TestClass testClass { get; set; }
        [SetUp] // Används innanför en TestFixture
        public void Init()
        {
            calculator = new Calculator();
            testClass = new TestClass();
            Console.WriteLine("Before Test");
        }
        [TearDown]
        public void Cleanup()
        {
            calculator = null;
            testClass = null;
            Console.WriteLine("After Test");
        }
        [Test]
        public void TestingSetup()
        {
            // Arrange
            string zero = "";
            // Act
            string actual = calculator.ButtonCE(zero);
            // Assert
            Assert.AreEqual("0", actual);            
        }


        //---------------DEKORERINGAR--------------------------//
        public void Method_Scenario_ExpectedOutcome()
        {            
            // Assign
            // Act
            // Assert(expected, actual)
        }

        [Test, Order(1)]
        public void ButtonCE_GetZero_AreEqualToZero()
        {
            Calculator calculator = new Calculator();
            string zero = "";
            string actual = calculator.ButtonCE(zero);
            Assert.AreEqual("0", actual); // Classic Model
            Assert.That(actual, Is.EqualTo("0")); // Constraint Model
            Console.WriteLine("Are equal to zero");
        }        
        [Test, Order(2)]
        public void Method_Scenario_AreNotEqual()
        {
            string zero = "";
            string actual = calculator.ButtonCE(zero);
            Assert.AreNotEqual("1", actual);
        }

        [Test, Description("En kommentar")]
        public void Buttons_Return_IsTrue()
        {
            bool operation = false; // kan sättas till både true or false, påverkar inte resultatet men måste initeras för att få ett argument till metoden Button
            var actual = calculator.Buttons(operation);
            Assert.IsFalse(actual);
            Assert.That(actual, Is.True);
        }


        [Test, Description("Här kan man skriva en kommentar")]
        [Ignore("Kommentar. Kan vara kod som ska fixas")]
        public void ButtonCE_GetZero_IsNull()
        {
            string zero = "";
            string actual = calculator.ButtonCE(zero);
            Assert.IsNull(actual);
        }

        [Category("Kategorinamn")]
        [Test]
        public void ButtonCE_GetZero_ISNotNull()
        {
            string zero = "";
            string actual = calculator.ButtonCE(zero);
            Assert.IsNotNull(actual);
        }

        [Test]
        public void Buttons_ReturnFalse_IsFalse()
        {
            bool operation = true; // kan sättas till både true or false, påverkar inte resultatet men måste initeras för att få ett argument till metoden Button
            var actual = calculator.Buttons(operation);
            Assert.IsFalse(actual);
            Assert.That(actual, Is.False);
        }


        //--------------TESTCASE------------------------------//
        [TestCase(4, 2, 2)]
        public void PlusTest(int a, int x, int y)
        {
            Assert.That(a, Is.EqualTo(x + y));
        }
        [TestCase(16, 4, 4)]
        public void TimesTest(int a, int x, int y)
        {
            Assert.AreEqual(a, x * y);
        }


        [TestCase(2, 2, ExpectedResult = 4)]
        [TestCase(5, 5, ExpectedResult = 10)]
        [TestCase(7, 8, ExpectedResult = 14)]
        [TestCase(25, 75, ExpectedResult = 100)]
        public int TestingTestCase(int x, int y)
        {
            return x + y;
        }



        //-------------------HUR TESTET KÖRS----------------------------------------//
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


        //--------------KOMMENTARER----------------------------------//
        // Enkelt att kommentera. Console.WriteLine("Kommentar");
        // Syns sedan i loggen
    }
}