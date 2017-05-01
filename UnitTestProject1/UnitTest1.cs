using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var class1 = new Class1();
            Assert.Equals(2, class1.Plus(1, 1));
        }

        [TestMethod]
        public void TestMethod2()
        {
            var class1 = new Class1();
            Assert.Equals(0, class1.Plus(0, 0));
        }


        [TestMethod]
        public void TestMethod3()
        {
            var class1 = new Class1();
            Assert.Equals(30, class1.Plus(10, 20));
        }
    }
}
