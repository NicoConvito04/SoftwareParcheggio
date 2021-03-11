using System;

namespace MetodiTariffe
{
    public class Gestione
    {


        public static double Tariffa1(int ore, double costoTariffa)
        {
            double costoTot = 15;
            return costoTot;

        }
        public static double Tariffa2(int ore, double costoTariffa)
        {
            double costoTot = ore * costoTariffa;
            return costoTot;
        }

        public static double Tariffa3(int ore, double costoTariffa)
        {
            double costoTot = 0;
            if (ore == 1)
            {
                costoTot = 0;
            }
            else
            {
                costoTot = (ore-1) * costoTariffa;
            }
            return costoTot;
        }
        


        public static double TariffaConsigliata(int ore)
        {
            double costoTot = 0;
            double tariffa2 = 1;
            double tariffa3 = 1.20;
            double costoTot2 = 0;
            double costoTot3 = 0;
            if (ore > 15)
            {
                costoTot = 15;
            }
            else
            {
                costoTot2 = ore * tariffa2;
                costoTot3 = (ore - 1) * tariffa3;
            }
            if (costoTot2 > costoTot3)
            {
                costoTot = costoTot2;
            }
            else
            {
                costoTot = costoTot3;
            }
            return costoTot;
        }
    }
}
