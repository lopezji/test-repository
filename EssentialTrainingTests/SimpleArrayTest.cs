using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EssentialTraining;

namespace EssentialTrainingTests
{
    [TestClass]
    public class SimpleArrayTest
    {
        [TestMethod]  // this is a test decorator indicates that a test has to be done
        public void TestInstantiation ()
        {
            var TestInstance = new SimpleArray();
            Assert.AreEqual(TestInstance.GroceryList.Length, 4);
            Assert.AreEqual(TestInstance.GroceryList[0], "Bread");
            
            
        }

        [TestMethod]
        public void TestToString()
        {
            var testInstance = new SimpleArray();
            Assert.IsTrue(testInstance.ToString().StartsWith("There are")); 
        }
    }
}
