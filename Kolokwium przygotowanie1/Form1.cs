using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Kolokwium_przygotowanie1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] tabela = new int[10];
        Random rnd = new Random();

        private void GenerateArray(int[] tab, int i)
        {
            for(int j=0; j<i; j++)
            {
                tab[j] = rnd.Next(0,21);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = Decimal.ToInt32(numericUpDown1.Value);
            int[] tablica2 = new int[i];
            GenerateArray(tablica2, i);
            label1.Text = ToText(tablica2);
            label1.Visible = true;
            tabela = tablica2;
        }

        private string ToText(int[] tabela)
        {
            string wynik = "";
            for(int i =0; i < tabela.Length; i++)
            {
                wynik += tabela[i] + " ";
            }
            return wynik;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                MergeSort(tabela);
                label1.Text = ToText(tabela);
            }
            else if (radioButton2.Checked == true)
            {
                InsertSort(tabela);
                label1.Text = ToText(tabela);
            }
            else if (radioButton3.Checked == true)
            {
                label1.Text = ToText(CountingSort(tabela));
            }
            else if (radioButton4.Checked == true)
            {
                QuickSort(tabela, 0, tabela.Length - 1);
                label1.Text = ToText(tabela);
            }
            else if (radioButton5.Checked == true)
            {
                BubbleSort(tabela);
                label1.Text = ToText(tabela);
            }
        }

        // Merge Sort

        private void MergeSort(int[] tabela)
        {
            int length = tabela.Length;
            if (length <= 1) return;
            int middle = length/2;
            int[] lTab = new int[middle];
            int[] rTab = new int[length - middle];
            int i = 0, j = 0;
            for (; i < length; i++)
            {
                if (i < middle)
                {
                    lTab[i] = tabela[i];
                }
                else
                {
                    rTab[j++] = tabela[i];
                }
            }
            MergeSort(lTab);
            MergeSort(rTab);
            Merge(lTab, rTab, tabela);
        }

        private void Merge(int[] lTab, int[] rTab, int[] tabela)
        {
            int lSize = tabela.Length/2;
            int rSize = tabela.Length - lSize;
            int i = 0, l = 0,r = 0;

            while(l < lSize && r < rSize)
            {
                if (lTab[l] < rTab[r])
                {
                    tabela[i++] = lTab[l++];
                }
                else
                {
                    tabela[i++] = rTab[r++];
                }
            }
            while (l < lSize)
            {
                tabela[i++] = lTab[l++];
            } 
            while (r < rSize)
            {
                tabela[i++] = rTab[r++];
            }
        }

        // Quick Sort

        private void QuickSort(int[] tabela, int start, int end)
        {
            if (start >= end) return;
            int p = Divide(tabela, start, end);
            QuickSort(tabela, start, p - 1);
            QuickSort(tabela, p+1, end);
        }

        private int Divide(int[] tabela, int start, int end)
        {
            int p = tabela[end];
            int i = start - 1;
            for(int j=start; j < end; j++)
            {
                if (tabela[j] < p)
                {
                    i++;
                    Swap(tabela, i, j);
                }
            }
            i++;
            Swap(tabela, i,end);
            return i;
        }

        private void Swap(int[] tabela, int i, int j)
        {
            int temp = tabela[i];
            tabela[i] = tabela[j];
            tabela[j] = temp;
        }

        private int GetMaxVal(int[] tabela)
        {
            int max = tabela[0];
            for(int i=1; i<tabela.Length; i++)
            {
                if(tabela[i] > max)
                {
                    max = tabela[i];
                }
            }
            return max;
        }

        // Counting Sort

        private int[] CountingSort(int[] tabela)
        {
            int max = GetMaxVal(tabela);
            int[] count = new int[max+1];
            for(int i=0; i < max; i++)
            {
                count[i] = 0;
            }
            for(int i=0; i < tabela.Length; i++)
            {
                count[tabela[i]]++;
            }
            for(int i=0,j=0; i <= max; i++)
            {
                while(count[i] > 0)
                {
                    tabela[j++] = i;
                    count[i]--;
                }
            }
            return tabela;
        }

        // Bubble Sort

        private void BubbleSort(int[] tabela)
        {
            for(int i = 0; i < tabela.Length; i++)
            {
                for(int j=0; j < tabela.Length; j++)
                {
                    if (tabela[j] > tabela[i])
                    {
                        Swap(tabela, i,j);
                    }
                }
            }
        }

        // Insert Sort

        private void InsertSort(int[] tabela)
        {
            for(int i=1; i < tabela.Length; i++)
            {
                int temp = tabela[i];
                int j = i - 1;
                while(j>= 0 && temp < tabela[j])
                {
                    tabela[j+1] = tabela[j];
                    j--;
                }
                tabela[j + 1] = temp;
            }
        }
    }
}
