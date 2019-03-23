using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//One of the classes to be tested, this one for a theoretical server
namespace SampleTests
{
    [TestFramework.TestsAttribute]
    public class ServerTests
    {
        [TestFramework.TestsInitialize]
        public void OpenConnection()
        {
            Console.WriteLine("Test OpenConnection completed");
        }
        [TestFramework.TestsTerminate]
        public void CloseConnection()
        {
            Console.WriteLine("Test CloseConnection completed");
        }
        [TestFramework.TestMethodAttribute(Order = 1)]
        public void TestUpload()
        {
            Console.WriteLine("Test TestUpload completed");
        }
        [TestFramework.TestMethodAttribute(Order = 2)]
        public void TestDownload()
        {
            Console.WriteLine("Test TestDownload completed");
        }
    }
}
