using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//This attribute is to be used by methods that need to be tested. Optionally, a method can set its
//order value so that that method can be run in a certain order.
namespace TestFramework
{
    [AttributeUsage(AttributeTargets.Method)]
    public class TestMethodAttribute : Attribute
    {
        private int order;

        public TestMethodAttribute()
        {
            this.order = 0;
        }
        //Allows the private variable order to be set and retrieved
        public virtual int Order
        {
            get { return order; }
            set { order = value; }
        }
    }
        
}
