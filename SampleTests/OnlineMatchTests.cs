using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//One of the classes to be tested, this one for a theoretical Online Matchmaker service 
namespace SampleTests
{
    [TestFramework.TestsAttribute]
    public class OnlineMatchTests
    {
        [TestFramework.TestsInitialize]
        public void Initialize()
        {
            Console.WriteLine("Test Initialize completed");
        }
        [TestFramework.TestMethodAttribute(Order =1)]
        public void TestConnections()
        {
            Console.WriteLine("Test TestConnection completed");
        }
        [TestFramework.TestMethodAttribute(Order =2)]
        public void TestUploads()
        {
            Console.WriteLine("Test TestUploads completed");
        }
        [TestFramework.TestMethodAttribute(Order =3)]
        public void TestDownloads()
        {
            Console.WriteLine("Test TestDownloads completed");
        }
        [TestFramework.TestMethodAttribute(Order =4)]
        public void TestPlayerDrop()
        {
            Console.WriteLine("Test TestPlayerDrop completed");
        }
        [TestFramework.TestsTerminate]
        public void Terminate()
        {
            Console.WriteLine("Test Terminate completed");
        }
    }
}
