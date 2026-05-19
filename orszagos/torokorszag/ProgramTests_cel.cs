using Microsoft.VisualStudio.TestTools.UnitTesting;
using celloveszetCLI_13B;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celloveszetCLI_13B.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        /*22; 29; 12; 23 =>29
16; 45; 87; 33; =>87
96; 49;67; 45=>96
44; 3;12; 77=>77
*/
        [DataRow(22,29,12,23,29)]
        [DataRow(16,45,87,33,87)]
        [DataRow(96,49,67,45,96)]
        [DataRow(44,3,12,77,77)]
        public void legnagyobbTest(int elso, int masodik, int harmadik, int negyedik, int elvart)
        {
            int aktualis = Program.legnagyobb(elso, masodik, harmadik, negyedik);
            Assert.AreEqual(elvart,aktualis);
        }
    }
}