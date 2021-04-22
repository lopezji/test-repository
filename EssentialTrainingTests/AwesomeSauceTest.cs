using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EssentialTraining;


namespace EssentialTrainingTests
{
    [TestClass]
    public class AwesomeSauceTest
    {
        [ TestMethod]
        public void IsSauceAwesomeTest()
        {
            var testInstance = new AwesomeSauce();
            testInstance.Sauces.Add("Macha");
            testInstance.Sauces.Add("Cholula");
            testInstance.Sauces.Add("bad");

            // Expect to Pass

            Assert.IsTrue(testInstance.IsSauceAwesome("Macha"));

            //Expect False
            Assert.IsFalse(testInstance.IsSauceAwesome("ketchup"));
        }
    }
}
