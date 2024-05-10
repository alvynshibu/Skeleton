using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create an insstance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //test to see that it exists
            Assert.IsNotNull(aSupplier);
        }
    }
}
