using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPróba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = ToText(tabela);
        }

        int[] tabela = { 2, 4, 7, 8, 6, 5, 3, 1, 0, 9 };
        Random rnd = new Random();

        private string ToText(int[] tabela)
        {
            string wynik = "";
            for(int i=0; i<tabela.Length; i++)
            {
                wynik += tabela[i] + " ";
            }
            return wynik;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for(int i =0;i < tabela.Length; i++)
            {
                tabela[i] = rnd.Next(0,101); 
            }
            label1.Text= ToText(tabela);
        }

        // Merge Sort

        private void MergeSort(int[] tabela)
        {
            int length = tabela.Length;
            if (length <= 1) return;
            int middle = length / 2;
            int[] lTab = new int[middle];
            int[] rTab = new int[length - middle];
            int i = 0,j = 0;

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
            int lSize = tabela.Length / 2;
            int rSize = tabela.Length - lSize;
            int l = 0, r = 0, i = 0;
            while(l <lSize && r < rSize)
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
            while(l < lSize)
            {
                tabela[i++] = lTab[l++];
            }
            while(r < rSize)
            {
                tabela[i++] = rTab[r++];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MergeSort(tabela);
            label1.Text = ToText(tabela);
        }

        // Counting Sort

        private int GetMaxVal(int[] tabela)
        {
            int wynik = tabela[0];
            for(int i = 1; i < tabela.Length; i++)
            {
                if(wynik < tabela[i])
                {
                    wynik = tabela[i];
                }
            }
            return wynik;
        }

        private int[] CountingSort(int[] tabela)
        {
            int max = GetMaxVal(tabela);
            int[] count = new int[max + 1];

            for(int i =0; i<max; i++)
            {
                count[i] = 0;
            }
            for(int i =0; i<tabela.Length; i++)
            {
                count[tabela[i]]++;
            }
            for(int i=0, j=0; i<=max; i++)
            {
                while (count[i] > 0)
                {
                    tabela[j++] = i;
                    count[i]--;
                }
            }
            return tabela;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = ToText(CountingSort(tabela));
        }

        private void Swap(int[] tabela, int x, int y)
        {
            int pamiec = tabela[x];
            tabela[x] = tabela[y];
            tabela[y] = pamiec;
        }

        // Bubble Sort

        private void BubbleSort(int[] tabela)
        {
            for(int i=0; i<tabela.Length; i++)
            {
                for(int j=0; j<tabela.Length; j++)
                {
                    if(tabela[i] < tabela[j])
                    {
                        Swap(tabela, i, j);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BubbleSort(tabela);
            label1.Text = ToText(tabela);
        }

        // Quick Sort

        private void QuickSort(int[] tabela, int start, int end)
        {
            if (start >= end) return;
            int p = Divide(tabela, start, end);
            QuickSort(tabela, start, p-1);
            QuickSort(tabela, p+1, end);
        }

        private int Divide(int[] tabela, int start, int end)
        {
            int p = tabela[end];
            int i = start - 1;

            for(int j = start; j<=end -1; j++)
            {
                if (tabela[j] < p)
                {
                    i++;
                    Swap(tabela, i, j);
                }
            }
            i++;
            Swap(tabela, i, end);
            return i;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QuickSort(tabela, 0, tabela.Length-1);
            label1.Text = ToText(tabela);
        }

        // Insert Sort

        private void InsertSort(int[] tabela)
        {
            for(int i=1; i < tabela.Length; i++)
            {
                int temp = tabela[i];
                int j = i - 1;

                while (j>=0 && tabela[j]>temp)
                {
                    tabela[j + 1] = tabela[j];
                    j--;
                }
                tabela[j + 1] = temp;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InsertSort(tabela);
            label1.Text= ToText(tabela);
        }
    }
}
