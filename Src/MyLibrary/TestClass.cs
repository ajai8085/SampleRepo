using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class TestClass
    {
        public string Test(string @event)
        {
            return string.Concat(@event, " Completed @ ", DateTime.Now);
        }
    }
}
