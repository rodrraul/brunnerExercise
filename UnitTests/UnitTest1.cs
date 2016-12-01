using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void VerifyCheckoutIsCorrect()
        //{
        //    var result = Program.Checkout(new[] { "Orange", "Apple" });
        //    Assert.AreEqual(1.1, result);
        //}

        //[TestMethod]
        //public void VerifyCheckoutIsZero()
        //{
        //    var result = Program.Checkout(new List<string>().ToArray());
        //    Assert.AreEqual(0.0, result);
        //}

        //[TestMethod]
        //public void VerifyCheckoutIsZeroWithUnknownItems()
        //{
        //    var result = Program.Checkout(new[] { "Banana" });
        //    Assert.AreNotEqual(0.0, result);
        //}

        [TestMethod]
        public void VerifyCheckoutWithDiscount()
        {
            var result = Program.Checkout(new[] 
            { 
                "Orange", 
                "Orange",
                "Orange",
                "Apple",
                "Apple"
            }, true);
            Assert.AreEqual(result, 1.55);
        }
    }
}
