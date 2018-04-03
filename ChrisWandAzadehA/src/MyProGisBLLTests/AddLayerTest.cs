using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyProGisBLL;

namespace MyProGisBLLTests
{
    [TestClass]
    public class AddLayerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            IMap newMap = new Map();
            ILayer newLayer = new Layer();
            newMap.AddLayer(newLayer);
            int Actual = newMap.LayerCount;
            int Expected = 1;
            Assert.AreEqual(Actual, Expected);

        }
    }
}
