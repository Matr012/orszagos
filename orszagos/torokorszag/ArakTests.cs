using Microsoft.VisualStudio.TestTools.UnitTesting;
using EvVegiArakCLI_13B_Diak;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvVegiArakCLI_13B_Diak.Tests
{
    [TestClass()]
    public class ArakTests
    {
        [TestMethod()]
        [DataRow("10001\tRövidkaraj, kg\t2610\t2630", 20)]
        [DataRow("10001\tRövidkaraj, kg\t2610\t2600", -10)]
        [DataRow("10001\tRövidkaraj, kg\t2610\t2610", 0)]
        public void ValtozasTest(string init, int elvart)
        {
            Arak a=new Arak(init);
            int aktualis = a.Valtozas();
            Assert.AreEqual(elvart, aktualis );
        }
    }
}