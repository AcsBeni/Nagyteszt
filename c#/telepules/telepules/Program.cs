using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telepules
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            NincsNagyKozosseg();
            TeljesNepesseg();
            Varmegyetext();
            LegnagyobbNepsuruseg();
            LegnagyobbVarosiNepsegAtlag();
        }

        private static void LegnagyobbVarosiNepsegAtlag()
        {
            Console.WriteLine("g) Feladat\nMelyik három területi egység rendelkezik a legnagyobb átlagos városi népességgel (város népessége/város száma), és írja ki őket csökkenő sorrendben!\n");
            List<telepules> lista = FajlIo.fajlbeolvasas("telepulesek.csv");
            List<telepules> vanVaros = lista.Where(x => (x.Varos_nep + x.Varos_szama) != 0).ToList();
            List<telepules> atlagoklista = vanVaros.OrderBy(x => (x.Varos_nep / x.Varos_szama))
                .ThenByDescending(x=>(x.Varos_nep/x.Varos_szama))
                .ToList();
            for (int i = 0; i < 3; i++) {
                Console.WriteLine($"{atlagoklista[i].Ter_egyseg_nev}");
            }

        }

        private static void LegnagyobbNepsuruseg()
        {
            Console.WriteLine($"f)\nJelenítse meg, hogy melyik vármegye rendelkezik a legmagasabb népsűrűséggel. A népsűrűséget úgy számoljuk ki, hogy a vármegye össznépességet elosztjuk a vármegye településeinek számával.\n");
            List<telepules> lista = FajlIo.fajlbeolvasas("telepulesek.csv");
            List<telepules> vármegye = lista.Where(x => x.Ter_egyseg_szint == "vármegye").ToList();
         
            int legnagyobbsűrűség= Convert.ToInt32(vármegye.Max(x => (x.Varos_nep + x.Koz_nep + x.Nagykoz_nep + x.Megyei_fovaros_nep) / (x.Varos_szama + x.Koz_szama + x.Nagykoz_nep + x.Megyei_fovaros_nep)));
            List<telepules> nepsűrűségvármegye = vármegye.Where(x => ((x.Varos_nep + x.Koz_nep + x.Nagykoz_nep + x.Megyei_fovaros_nep) / (x.Varos_szama + x.Koz_szama + x.Nagykoz_nep + x.Megyei_fovaros_nep)) == legnagyobbsűrűség).ToList();
            Console.WriteLine(nepsűrűségvármegye[0].ToString());

        }

        private static void Varmegyetext()
        {
            List<string> textfile = new List<string>();
            Console.WriteLine("e) Feladat\nÍrja ki a varmegye.txt állományba azon vármegyék adatait, amelyekben kevesebben laknak városban, mint nagyközségben és községben együttvéve (A városi lakosság száma kisebb, mint a nagyközség és község lakosságának összege.). Az állományban vesszővel elválasztva a következő adatokat jelenítse meg: vármegye neve; városok összlakossága, nagyközség és község lakossága összesen.\n");
            List<telepules> lista = FajlIo.fajlbeolvasas("telepulesek.csv");
            List<telepules> vármegye = lista.Where(x => x.Ter_egyseg_szint == "vármegye").ToList();
            List<telepules>vármegyevaros = vármegye.Where(x => (x.Koz_nep + x.Nagykoz_nep) > x.Varos_nep).ToList();
            foreach(var item in vármegyevaros)
            {
                textfile.Add(item.ToString());
            }
            FajlIo.fajlbairas(textfile,"varmegye.txt");
        }

        private static void TeljesNepesseg()
        {
            Console.WriteLine("d) Feladat\nJelenítse meg, hogy mennyi a teljes népesség az egyes területtípusokban. Írja ki a terület típusát, majd kötőjellel elválasztva a teljes népességét..\n");
            List<telepules> lista = FajlIo.fajlbeolvasas("telepulesek.csv");
            List<telepules> vármegye = lista.Where(x => x.Ter_egyseg_szint == "vármegye").ToList();
            List<telepules> régió = lista.Where(x => x.Ter_egyseg_szint == "régió").ToList();
            List<telepules> nagyrégió = lista.Where(x => x.Ter_egyseg_szint == "nagyrégió").ToList();

            int vármegyenépesség = Convert.ToInt32(vármegye.Sum(x => x.Varos_nep + x.Koz_nep + x.Nagykoz_nep +x.Megyei_fovaros_nep));
            int régióenépesség = Convert.ToInt32(régió.Sum(x => x.Varos_nep + x.Koz_nep + x.Nagykoz_nep +x.Megyei_fovaros_nep));
            int nagyrégiónépesség = Convert.ToInt32(nagyrégió.Sum(x => x.Varos_nep + x.Koz_nep + x.Nagykoz_nep +x.Megyei_fovaros_nep));


            Console.WriteLine($"Vármegye-{vármegyenépesség}\n" +
                $"Régió-{régióenépesség}\n" +
                $"NagyRégió-{nagyrégiónépesség}");
        }

        private static void NincsNagyKozosseg()
        {
            Console.WriteLine("c) Feladat\nJelenítse meg, hogy melyek azok a területi egységek, amelyekben nincs nagyközség.\n");
            List<telepules> lista = FajlIo.fajlbeolvasas("telepulesek.csv");
            List<telepules> nonagykozosseglista = lista.Where(x=>x.Nagykoz_szama==0).ToList();
            foreach(var item in nonagykozosseglista)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
