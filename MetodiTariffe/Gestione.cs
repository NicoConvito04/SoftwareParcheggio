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
    }
}
