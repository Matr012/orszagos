using LolCLI_V2;

namespace LolCLI_V2.Tests
{
    [TestClass]
    public class HosTests
    {
        private Hos tesztHos;

        [TestInitialize]
        public void Setup()
        {
            tesztHos = new Hos("Parzival;a mágányos Hõs;Fighter;A cél a kulcs! A cél a tojás!;500;100");
        }

        [TestMethod]
        public void HpErtek_10Szint_1400HpVart()
        {
            // Arrange
            int szint = 10;
            double vartHp = 1400;

            // Act
            double eredmeny = tesztHos.HpErtek(szint);

            // Assert
            Assert.AreEqual(vartHp, eredmeny);
        }

        [TestMethod]
        public void HpErtek_1Szint_500HpVart()
        {
            // Arrange
            int szint = 1;
            double vartHp = 500;

            // Act
            double eredmeny = tesztHos.HpErtek(szint);

            // Assert
            Assert.AreEqual(vartHp, eredmeny);
        }

        [TestMethod]
        public void HpErtek_5Szint_900HpVart()
        {
            // Arrange
            int szint = 5;
            double vartHp = 900;

            // Act
            double eredmeny = tesztHos.HpErtek(szint);

            // Assert
            Assert.AreEqual(vartHp, eredmeny);
        }

        [TestMethod]
        public void HpErtek_18Szint_2200HpVart()
        {
            // Arrange
            int szint = 18;
            double vartHp = 2200;

            // Act
            double eredmeny = tesztHos.HpErtek(szint);

            // Assert
            Assert.AreEqual(vartHp, eredmeny);
        }

        [TestMethod]
        public void HpErtek_0Szint_Minus1Vart()
        {
            // Arrange
            int szint = 0;
            double vartErtek = -1;

            // Act
            double eredmeny = tesztHos.HpErtek(szint);

            // Assert
            Assert.AreEqual(vartErtek, eredmeny);
        }

        [TestMethod]
        public void HpErtek_19Szint_Minus1Vart()
        {
            // Arrange
            int szint = 19;
            double vartErtek = -1;

            // Act
            double eredmeny = tesztHos.HpErtek(szint);

            // Assert
            Assert.AreEqual(vartErtek, eredmeny);
        }
    }
}