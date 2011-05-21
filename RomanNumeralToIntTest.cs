using RomanNumeralToInt;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RomanNumeralToIntTest
{
    
    
    /// <summary>
    ///This is a test class for RomanNumeralToIntTest and is intended
    ///to contain all RomanNumeralToIntTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RomanNumeralToIntTest
    {


        private TestContext testContextInstance;

        private RomanNumeralToInt.RomanNumeralToInt instance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        [TestInitialize()]
        public void MyTestInitialize()
        {
            instance = new RomanNumeralToInt.RomanNumeralToInt();
        }
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for RomanNumeralToInt Constructor
        ///</summary>
        [TestMethod()]
        public void RomanNumeralToIntConstructorTest()
        {
            Assert.IsNotNull(instance);
        }

        /// <summary>
        ///A test for Main
        ///</summary>
        [TestMethod()]
        [DeploymentItem("RomanNumeralToInt.exe")]
        public void MainTest()
        {
            string[] args = null; 
            RomanNumeralToInt_Accessor.Main(args);
            Assert.IsNotNull(instance);
        }

        [TestMethod()]
        public void testI()
        {
            Assert.Equals(1, instance.convert("I"));
        }
    }
}
