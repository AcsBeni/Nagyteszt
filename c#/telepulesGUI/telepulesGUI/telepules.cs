using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telepulesGUI
{
    internal class telepules
    {
        private string ter_egyseg_nev;
        private string ter_egyseg_szint;
        private int megyei_fovaros_szama;
        private int megyei_fovaros_nep;
        private int varos_szama;
        private int varos_nep;
        private int nagykoz_szama;
        private int nagykoz_nep;
        private int koz_szama;
        private int koz_nep;

        public telepules(string sor)
        {
            Ter_egyseg_nev = sor.Split(';')[0];
            Ter_egyseg_szint = sor.Split(';')[1];
            Megyei_fovaros_szama = Convert.ToInt32(sor.Split(';')[2]);
            Megyei_fovaros_nep = Convert.ToInt32(sor.Split(';')[3]);
            Varos_szama = Convert.ToInt32(sor.Split(';')[4]);
            Varos_nep = Convert.ToInt32(sor.Split(';')[5]);
            Nagykoz_szama = Convert.ToInt32(sor.Split(';')[6]);
            Nagykoz_nep = Convert.ToInt32(sor.Split(';')[7]);
            Koz_szama = Convert.ToInt32(sor.Split(';')[8]);
            Koz_nep = Convert.ToInt32(sor.Split(';')[9]);
        }

        public string Ter_egyseg_nev { get => ter_egyseg_nev; set => ter_egyseg_nev = value; }
        public string Ter_egyseg_szint { get => ter_egyseg_szint; set => ter_egyseg_szint = value; }
        public int Megyei_fovaros_szama { get => megyei_fovaros_szama; set => megyei_fovaros_szama = value; }
        public int Megyei_fovaros_nep { get => megyei_fovaros_nep; set => megyei_fovaros_nep = value; }
        public int Varos_szama { get => varos_szama; set => varos_szama = value; }
        public int Varos_nep { get => varos_nep; set => varos_nep = value; }
        public int Nagykoz_szama { get => nagykoz_szama; set => nagykoz_szama = value; }
        public int Nagykoz_nep { get => nagykoz_nep; set => nagykoz_nep = value; }
        public int Koz_szama { get => koz_szama; set => koz_szama = value; }
        public int Koz_nep { get => koz_nep; set => koz_nep = value; }

        public override string ToString()
        {
            return $"{Ter_egyseg_nev}, {Ter_egyseg_szint}, {Megyei_fovaros_nep}, {Megyei_fovaros_szama}, {Varos_nep}, {Varos_szama}, {Nagykoz_nep}, {Nagykoz_szama}, {Koz_nep}, {Koz_szama}";
        }
        public string netpopulationToString(double growth)
        {
            return $"{Ter_egyseg_nev}, {Ter_egyseg_szint}, {Megyei_fovaros_nep* growth}, {Megyei_fovaros_szama}, {Varos_nep* growth}, {Varos_szama}, {Nagykoz_nep* growth}, {Nagykoz_szama}, {Koz_nep* growth}, {Koz_szama}";
        }
    }
}
