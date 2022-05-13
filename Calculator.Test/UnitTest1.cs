using Calculater;
using CalculatorWithNunit;
using NUnit.Framework;
using System;
using System.Threading.Tasks;
//https://xunit.net/docs/comparisons - J�mf�relser


namespace Calculator1
{
    [TestFixture]
    public class Tests
    {
        //-----------------SETUP/TEARDOWN----------------------------------//
        private Calculator calculator;
        private TestClass testClass;
        [SetUp] // Anv�nds innanf�r en TestFixture
        public void Init()
        {
            // new product
            // result = false;
            calculator = new Calculator();
            testClass = new TestClass();
            Console.WriteLine("Before Test");
        }
        [TearDown]
        public void Cleanup()
        {
            // product = null
            // result = false;
            calculator.Dispose();
            testClass = null;
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
        [Test]
        public void TestingSetup()
        {
            string zero = "";
            string actual = calculator.ButtonCE(zero);
            Assert.That("0", Is.EqualTo(actual));
            Console.WriteLine("Testing setup");
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
            string zero = "";
            string actual = calculator.ButtonCE(zero);
            Assert.AreEqual("0", actual); // Classic Model
            Assert.That(actual, Is.EqualTo("0")); // Constraint Model
            Console.WriteLine("Are equal to zero");
        }
        
        [Test, Order(2)]
        public void Method_Scenario_AreNotEqual()
        {           
            Console.WriteLine("Are not equal");
            //Assert.AreNotEqual();
        }
        [Test, Description("En kommentar")]
        public void ButtonSum_Operation_IsTrue()
        {
            //Assert.IsTrue();            
        }
        [Test]
        public void Buttons_ReturnFalse_IsFalse()
        {
            bool operation = false; // kan s�ttas till b�de true or false, p�verkar inte resultatet men m�ste initeras f�r att f� ett argument till metoden Button
            var actual = calculator.Buttons(operation);
            Assert.IsFalse(actual);
            Assert.That(actual, Is.False);
        }
        [Test]
        [Ignore("Kommentar. Kan vara kod som ska fixas")]
        public void ButtonCE_GetZero_IsNull()
        {
            //Assert.IsNull();
        }
        [Category("Kategorinamn")]
        [Test]
        public void ButtonCE_GetZero_ISNotNull()
        {
            string zero = "";
            string actual = calculator.ButtonCE(zero);
            Assert.IsNotNull(actual);
        }
        [Test(ExpectedResult = 4)] // Man kan inte ha exected result till en void metod
        public int TestAdd()
        {
            return 2 + 2;
        }
        [Test]
        public void Method_Scenario_Contains()
        {

        }


        //-------------TASK-------------------------//
        //[Test]
        //public async Task AddAsync()
        //{
        //    /* ... */ 
        //}
        //[Test(ExpectedResult = 4)]
        //public async Task<int> TestTask()
        //{
        //    //await 5000;
        //    return 2 + 2;
        //}


        //--------------TESTCASE------------------------------//
        // Ett annat s�tt att testa med cases. Kan �ven kalla fr�n en annan klass
        // 
        static object[] AddCases =
        {
        new object[] { 12, 6, 6 },
        new object[] { 12, 7, 5 },
        };
        [TestCaseSource(nameof(AddCases))]
        public void Testobject(int a, int x, int y)
        {
            Assert.AreEqual(a, x + y);
        }
        [TestCase(2, 2, ExpectedResult = 4)]
        [TestCase(5, 5, ExpectedResult = 10)]
        [TestCase(7, 8, ExpectedResult = 14)]
        [TestCase(25, 75, ExpectedResult = 100)]
        public int TestingTestCase(int x, int y)
        {
            return x + y;
        }


        //-------------------HUR TESTET K�RS----------------------------------------//
        // Nunit k�r alla testerna efter varandra
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


        //-----------------J�MF�RELSER-----------------------------//
        // En j�mnf�relse med Xunit
        [Test]
        public void PassingTest()
        {            
            Assert.AreEqual(4, testClass.Add(2, 2));
        }


        //--------------KOMMENTARER----------------------------------//
        // Enkelt att kommentera. Console.WriteLine("Kommentar");
        // Synd sedan i loggen
    }
}