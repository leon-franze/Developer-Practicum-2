using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Developer_Practicum_2.Program;

namespace UnitTestsDeveloperPracticum2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ProcessOrder_AllInputs_Morning()
        {
            var waiter = new Waiter();

            string result = waiter.processOrder("morning,1,2,3,4");

            Assert.AreEqual("Eggs, Toast, Coffee, Error", result);
        }
        [TestMethod]
        public void ProcessOrder_AllInputsOrdered_Night()
        {
            var waiter = new Waiter();

            string result = waiter.processOrder("night,1,2,3,4");

            Assert.AreEqual("Steak, Potato, Wine, Cake", result);
        }
        [TestMethod]
        public void ProcessOrder_MixedInputs_Morning()
        {
            var waiter = new Waiter();

            string result = waiter.processOrder("morning,1,4,2,3");

            Assert.AreEqual("Eggs, Error, Toast, Coffee", result);
        }
        [TestMethod]
        public void ProcessOrder_MixedInputs_Night()
        {
            var waiter = new Waiter();

            string result = waiter.processOrder("night,1,4,2,3");

            Assert.AreEqual("Steak, Cake, Potato, Wine", result);

        }
    }
}
