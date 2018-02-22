using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RoulettenGame
{
    [TestFixture]
    class TestBase
    {
        [SetUp]
        public void StartUpBeforeTest()
        {

        }

        [TearDown]
        public void TearDownAfterTest()
        {

        }
    }
}
