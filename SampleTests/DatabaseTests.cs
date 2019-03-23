using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//One of the classes to be tested, this one for a theoretical Database
namespace SampleTests
{
    [TestFramework.TestsAttribute]
    public class DatabaseTests
    {
        [TestFramework.TestMethodAttribute(Order =2)]
        public void ConnectionTest()
        {
            Console.WriteLine("Test ConnectionTest completed");
        }
        [TestFramework.TestMethodAttribute(Order =3)]
        public void TestUpload()
        {
            Console.WriteLine("Test TestUpload completed");
        }
        [TestFramework.TestMethodAttribute(Order =4)]
        public void TestDownload()
        {
            Console.WriteLine("Test TestDownload completed");
        }
        [TestFramework.TestMethodAttribute(Order =1)]
        public void TestSearch()
        {
            Console.WriteLine("Test TestSearch completed");
        }
        //A method to make sure testing engine doesnt test non-test methods
        public void examples()
        {
            Console.WriteLine("This should not print");
        }
    }
}
