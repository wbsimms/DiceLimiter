using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiceLimiterLib.Test
{
    [TestClass]
    public class DiceLimitTest
    {

        [TestMethod]
        public void Test()
        {
            DiceLimit dl = new DiceLimit();
            Assert.IsNotNull(dl);
            int count = dl.GetDiceCount("jquery");
            Assert.IsTrue(count > 0);
        }
    }
}
