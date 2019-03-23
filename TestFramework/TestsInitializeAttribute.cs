using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Attribute to be used by Initializer methods
namespace TestFramework
{
    [AttributeUsage(AttributeTargets.Method)]
    public class TestsInitializeAttribute : Attribute
    {
    }
        
}
