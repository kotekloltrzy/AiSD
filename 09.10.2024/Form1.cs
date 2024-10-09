using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09._10._2024
{
    public partial class Form1 : Form
    {
        int[] tablica = { 12, 34, 2, 1, 100 , 13};
        public Form1()
        {
            InitializeComponent();
            label1.Text = CreateString(tablica);
        }

        public void InsertSort(int[] tab)
        {
            for(int i=tab.Length-1; i>0; i--)
            {
                for(int j=tab.Length-1; j>0; j--)
                {
                    if (tab[j] < tab[j - 1])
                    {
                        int pamiec = tab[j - 1];
                        tab[j - 1] = tab[j];
                        tab[j] = pamiec;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

        public string CreateString(int[] tab)
        {
            string Napis = "";
            for(int i=0; i<tab.Length; i++)
            {
                Napis = Napis + tab[i] + ", ";
            }
            return Napis;
        }

        public void MergeSort(int[] tab, int p, int r)
        {
            if (p < r)
            {
                int q = p + r / 2;
                MergeSort(tab, p, q);
                MergeSort(tab, p + 1, r);
                Connect(tab, p, q, r);
            }
        }

        public void Connect(int[] tab, int p, int q, int r)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertSort(tablica);
            label2.Text = CreateString(tablica);
            label2.Visible = true;
        }
    }
}
