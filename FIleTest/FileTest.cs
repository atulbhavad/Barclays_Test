using FileData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThirdPartyTools;

namespace FileTest
{
    [TestClass]
    public class FileTest
    {
        [TestMethod]
        public void Test_prototypeFirst()
        {
            //Chane the input for test
            string[] input = @"-v C:/test.txt".Split(' ');           
            bool res = Program.prototypeFirst(input);
            Assert.AreEqual(res, true);
        }
        [TestMethod]
        public void Test_prototypeSecond()
        {
            //Chane the input for test
            string[] input = @"-v C:/test.txt".Split(' ');
            bool res = Program.prototypeFirst(input);
            Assert.AreEqual(res, true);
        }
    }
}
