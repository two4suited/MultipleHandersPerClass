using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Xunit;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;

using src;

namespace src.Tests
{
    public class FunctionTest
    {
        [Fact]
        public void TestToUpperFunction()
        {

            Message m = new Message();
            if (m != null)
            {
                m.key1 = "test";

                m.Upper();
                Assert.Equal("TEST", m.key1);
            }
        }
    }
}
