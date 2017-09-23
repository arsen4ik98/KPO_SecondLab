using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Queue;
using NUnit.Framework;

namespace test
{
    [TestFixture]
    public class Class1
    {

        [Test()]

        public void Test1()
        {
            IQueue asd = new Queue();
            asd.Push(2);
            int expected = 1;
            int actual = asd.count;
        }




    }
}
