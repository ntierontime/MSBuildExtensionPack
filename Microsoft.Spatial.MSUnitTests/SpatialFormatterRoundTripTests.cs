using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Xml;

namespace Microsoft.Spatial.MSUnitTests
{
    /// <summary>
    /// Summary description for SpatialFormatterRoundTripTests
    /// </summary>
    [TestClass]
    public class SpatialFormatterRoundTripTests
    {
        public SpatialFormatterRoundTripTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

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

        private static GeoJsonObjectFormatter jsonFormatter;
        private static GmlFormatter gmlFormatter;
        private static WellKnownTextSqlFormatter wktFormatter;
        private static GeoJsonObjectFormatter jsonDictionaryFormatter;
        //private static DataServicesSpatialImplementation implementation = new DataServicesSpatialImplementation();
        private static  CoordinateSystem nonDefaultGeometry = CoordinateSystem.Geometry(1234);
        private static  CoordinateSystem nonDefaultGeography = CoordinateSystem.Geography(1234);

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            jsonFormatter = GeoJsonObjectFormatter.Create();
            gmlFormatter = GmlFormatter.Create();
            wktFormatter = WellKnownTextSqlFormatter.Create();
            jsonDictionaryFormatter = GeoJsonObjectFormatter.Create();
        }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void PointRoundTrip_Geography()
        {
            this.RoundTripTest(
                //EmptyGeography(SpatialType.Point),
                GeographyFactory.Point(nonDefaultGeography, 10, 20),
                GeographyFactory.Point(10, 10),
                GeographyFactory.Point(10, 10, 10, 10),
                GeographyFactory.Point(10, 10, 10, null),
                GeographyFactory.Point(10, 10, 10, 10));
        }

        private void RoundTripTest(params Geography[] args)
        {
            RoundTripTest_Gml(args);
            RoundTripTest_Json(args);
            RoundTripTest_Wkt(args);
            RoundTripTest_JsonDictionary(args);
        }

        private void RoundTripTest_Gml(params Geography[] args)
        {
            foreach (var input in args)
            {
                var text = gmlFormatter.Write(input);
                TextReader reader = new StringReader(text);
                var r = XmlReader.Create(reader);
                var output = gmlFormatter.Read<Geography>(r);

                Assert.IsTrue(input.Equals(output));
            }
        }

        private void RoundTripTest_Json(params Geography[] args)
        {
            foreach (var input in args)
            {
                var format = jsonFormatter.Write(input);
                var output = jsonFormatter.Read<Geography>(format);

                Assert.IsTrue(input.Equals(output));
            }
        }

        private void RoundTripTest_Wkt(params Geography[] args)
        {
            foreach (var input in args)
            {
                var text = wktFormatter.Write(input);
                TextReader reader = new StringReader(text);
                var output = wktFormatter.Read<Geography>(reader);

                Assert.IsTrue(input.Equals(output));
            }
        }

        private void RoundTripTest_JsonDictionary(params Geography[] args)
        {
            foreach (var input in args)
            {
                var dictionary = jsonDictionaryFormatter.Write(input);
                var output = jsonDictionaryFormatter.Read<Geography>(dictionary);
                Assert.IsTrue(input.Equals(output));
            }
        }
    }
}
