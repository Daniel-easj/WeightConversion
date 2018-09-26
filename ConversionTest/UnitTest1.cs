using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeightConversionDLL;

namespace ConversionTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConvertToGramTest()
        {
            Assert.AreEqual(ConverterClass.ConvertToGram(5.0), 141.7476, 0.10);
        }

        [TestMethod]
        public void ConvertToOuncesTest()
        {
            Assert.AreEqual(ConverterClass.ConvertToOunces(8), 0.2821916956, 0.10);
        }
    }
}
