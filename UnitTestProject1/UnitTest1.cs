using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Test2.C.AdventureWorks _A = new Test2.C.AdventureWorks();

            var _B =
                (from t in _A.Addresses
                select t).FirstOrDefault();
            var _C = _B.SpatialLocation.AsGml();
        }
    }
}
