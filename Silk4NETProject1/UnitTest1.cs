using Microsoft.VisualStudio.TestTools.UnitTesting;
using SilkTest.Ntf;

namespace Silk4NETProject1
{
    [SilkTestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void Initialize()
        {
        }

        [TestMethod]
        public void TestMethod1()
        {
            Agent.SystemFunctions.CreateDirectory("C:\\SILKCENTRAL");
        }
    }
}