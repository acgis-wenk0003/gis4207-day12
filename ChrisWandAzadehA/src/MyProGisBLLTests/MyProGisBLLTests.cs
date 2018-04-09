using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyProGisBLL;

namespace MyProGisBLLTests
{
    [TestClass]
    public class MyProGisBLLTests
    {
        [TestMethod]
        public void MapsAddLayer_Working()
        {
            int Expected = 2;
            int Actual;

            ILayer TestLayer = new Layer();
            ILayer TestLAyer2 = new Layer();
            IMap TestMap = new Map();
            TestMap.AddLayer(TestLayer);
            TestMap.AddLayer(TestLAyer2);
            

            Actual = TestMap.LayerCount;
            Assert.AreEqual(Expected, Actual);   
        }
        [TestMethod]
        public void TestRemoveLayer_Working()
        {
            int Expected = 1;
            int Actual;

            ILayer TestLayer = new Layer();
            ILayer TestLayer2 = new Layer();
            IMap TestMap = new Map();
            TestMap.AddLayer(TestLayer);
            TestMap.AddLayer(TestLayer2);
            TestMap.RemoveLayer(2);

            Actual = TestMap.Layers.Length;
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void MapsDocAddMap_Working()
        {
            int expected = 2;

            IMap testmap = new Map();
            IMap testmap2 = new Map();
            IMapManager TestMapDoc = new MapDocument();
            
            TestMapDoc.AddMap(testmap);
            TestMapDoc.AddMap(testmap2);
            IMapDocument MapDoc = (IMapDocument)TestMapDoc;

            int actual = MapDoc.Maps.Length;

            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void MapsDocRemoveMap_Working()
        {
            int expected = 1;

            IMap testmap = new Map();
            IMap testmap2 = new Map();
            IMapManager TestMapDoc = new MapDocument();

            TestMapDoc.AddMap(testmap);
            TestMapDoc.AddMap(testmap2);
            TestMapDoc.RemoveMap(1);

            IMapDocument MapDoc = (IMapDocument)TestMapDoc;
                        
            int actual = MapDoc.Maps.Length;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MapsDocSetFocusMap()
        {
            string expected = null;

            IMap testmap = new Map();
            IMap testmap2 = new Map();
            IMapManager TestMapDoc = new MapDocument();

            TestMapDoc.AddMap(testmap);
            TestMapDoc.AddMap(testmap2);
            TestMapDoc.RemoveMap(1);

            IMapDocument MapDoc = (IMapDocument)TestMapDoc;

            int actual = MapDoc.Maps.Length;
            Assert.AreNotEqual(expected, actual);
        }
        [TestMethod]
        public void MapsDocGetMap()
        {
            string expected = "Cuba";

            IMap testmap = new Map();
            testmap.Name = "Canada";
            IMap testmap2 = new Map();
            testmap2.Name = "Cuba";
            IMapManager TestMapDoc = new MapDocument();

            TestMapDoc.AddMap(testmap);
            TestMapDoc.AddMap(testmap2);
            

            IMapDocument MapDoc = (IMapDocument)TestMapDoc;
           
            IMap actual = MapDoc.GetMap("Cuba");
            
            Assert.AreEqual(expected, actual.Name);
        }
    }
}
