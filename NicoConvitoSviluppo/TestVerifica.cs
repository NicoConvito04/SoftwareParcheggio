using Microsoft.VisualStudio.TestTools.UnitTesting;
using MetodiTariffe;

namespace NicoConvitoSviluppo
{
    [TestClass]
    public class TestVerifica
    {

        [TestMethod]
        public void Tariffa1()
        {
            int ore = 3;
            double tariffa = 15;
            double rispsosta_aspettata = 15;
            double risposta_effettiva = Gestione.Tariffa1(ore, tariffa);
            Assert.AreEqual(rispsosta_aspettata, risposta_effettiva);
        }
        [TestMethod]
        public void Tariffa2()
        {
            int ore = 3;
            double tariffa = 1;
            double rispsosta_aspettata = 3;
            double risposta_effettiva = Gestione.Tariffa2(ore, tariffa);
            Assert.AreEqual(rispsosta_aspettata, risposta_effettiva);
        }

        [TestMethod]
        public void Tariffa3()
        {
            int ore = 2;
            double tariffa = 1.20;
            double rispsosta_aspettata = 1.20;
            double risposta_effettiva = Gestione.Tariffa3(ore, tariffa);
            Assert.AreEqual(rispsosta_aspettata, risposta_effettiva);
        }



        [TestMethod]
        public void CostoTotale()
        {
            int ore = 3;
            double risposta_aspettata = 3;
            double risposta_effettiva = Gestione.TariffaConsigliata(ore);
            Assert.AreEqual(risposta_aspettata, risposta_effettiva);
        }

    }
}
