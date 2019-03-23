using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Attribute to be used by classes to be tested
namespace TestFramework
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TestsAttribute : Attribute
    {
    }
        
}
