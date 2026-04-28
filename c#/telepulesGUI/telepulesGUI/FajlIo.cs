using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telepulesGUI
{
    internal class FajlIo
    {
        public static List<telepules> fajlbeolvasas(string link)
        {
            List<telepules> adatok = new List<telepules>();
            try { 
                StreamReader olvas = new StreamReader(link);
                olvas.ReadLine();
                while (!olvas.EndOfStream)
                {
                    adatok.Add(new telepules(olvas.ReadLine()));
                }
                olvas.Close();
            }
            catch {
                
            }
            return adatok;
        }
        public static void fajlbairas(List<string> adatok, string fajlnev)
        {
            try{
                StreamWriter iras = new StreamWriter(fajlnev, false, Encoding.UTF8);
                for (int i = 0; i < adatok.Count; i++) {
                    iras.WriteLine(adatok[i]);
                }
                iras.Close();
            }
            catch
            {

            }
        }
    }
}
