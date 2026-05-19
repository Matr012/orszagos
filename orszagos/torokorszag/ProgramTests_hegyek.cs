using hegyekCLI13B;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hegyekCLI13B.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void taralamazTestIsTrue()
        {
            bool eredmeny = Program.taralamaz("Bükk", "Fodor-hegy", "Bükk-vidék");
            Assert.IsTrue(eredmeny);
        }

        [TestMethod()]
        public void taralamazTestIsTrue2()
        {
            bool eredmeny = Program.taralamaz("kő", "Füstös-kő-bérc", "Bükk-vidék");
            Assert.IsTrue(eredmeny);
        }

        [TestMethod()]
        public void taralamazTestIsFalse()
        {
            bool eredmeny = Program.taralamaz("Bükk", "Írott-kő", "Kőszegi-hegység");
            Assert.IsFalse(eredmeny);
        }
    }
}