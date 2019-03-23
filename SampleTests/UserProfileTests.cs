using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//One of the classes to be tested, this one for a theoretical user profile
namespace SampleTests
{
    [TestFramework.TestsAttribute]
    public class UserProfileTests
    {
        [TestFramework.TestsInitialize]
        public void Login()
        {
            Console.WriteLine("Test Login completed");
        }
        [TestFramework.TestMethodAttribute(Order = 3)]
        public void TestNameChange()
        {
            Console.WriteLine("Test TestNameChange completed");
        }
        [TestFramework.TestMethodAttribute(Order =1)]
        public void TestEmailChange()
        {
            Console.WriteLine("Test TestEmailChange completed");
        }
        [TestFramework.TestMethodAttribute(Order = 2)]
        public void TestIdentityCheck()
        {
            Console.WriteLine("Test TestIdentityCheck completed");
        }
        [TestFramework.TestsTerminate]
        public void Logout()
        {
            Console.WriteLine("Test Logout completed");
        }
    }
}
