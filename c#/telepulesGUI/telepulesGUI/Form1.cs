using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telepulesGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Listafeltoltese();
        }

        private void Listafeltoltese()
        {
            
            List<telepules> lista = FajlIo.fajlbeolvasas("telepulesek.csv");
            foreach (var item in lista)
            {
                Listbox.Items.Add(item.ToString());
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listbox.Items.Clear();
            List<telepules> lista = FajlIo.fajlbeolvasas("telepulesek.csv");
            List<telepules> szűrtlista = lista.Where(x => x.Ter_egyseg_szint == comboBox1.Text).ToList();
 
            foreach (var item in szűrtlista)
            {
                Listbox.Items.Add(item.ToString());
            }
        }

        private void minvarszamBtn_Click(object sender, EventArgs e)
        {
            Listbox.Items.Clear();
            List<telepules> lista = FajlIo.fajlbeolvasas("telepulesek.csv");
            int minnumber = Convert.ToInt32(lista.Min(x => x.Varos_szama));
            List<telepules> szűrtlista = lista.Where(x => x.Varos_szama == minnumber).ToList();

            foreach (var item in szűrtlista)
            {
                Listbox.Items.Add(item.ToString());
            }
        }

        private void minkozszamBtn_Click(object sender, EventArgs e)
        {
            Listbox.Items.Clear();
            List<telepules> lista = FajlIo.fajlbeolvasas("telepulesek.csv");
            int minnumber = Convert.ToInt32(lista.Min(x => x.Koz_szama));
            List<telepules> szűrtlista = lista.Where(x => x.Koz_szama == minnumber).ToList();

            foreach (var item in szűrtlista)
            {
                Listbox.Items.Add(item.ToString());
            }
        }

        private void dateBtn_Click(object sender, EventArgs e)
        {
            Listbox.Items.Clear();
            populationgrowthLbl.Text = "";
            List<telepules> lista = FajlIo.fajlbeolvasas("telepulesek.csv");
            int givendate = Convert.ToInt32(datetxt.Text);
            int date = 2024;
            double netgrowth = 0.5;
            if( givendate <= 2024)
            {
                populationgrowthLbl.Text = "az adott év nem lehet kevesebb, vagy 2024!";
                return;
            }
            if (givendate == 2025)
            {
                netgrowth = 0.5;
            }
            else
            {
                while (givendate != date)
                {
                    netgrowth /= 0.5;
                    --givendate;
                }
            }
            foreach(var item in lista)
            {
                Listbox.Items.Add(item.netpopulationToString(netgrowth));
            }
           
           

        }
    }
}
