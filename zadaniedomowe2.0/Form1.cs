using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace zadaniedomowe2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = CreateString(tablica);
        }
        int[] tablica = {10,9,8,7,6,5,4,3,2,1};
        Stopwatch stopwatch = new Stopwatch();

        Random rnd = new Random();

        public void GenerateArray(int[] tab, int i)
        {
            for(int j=0; j<i; j++)
            {
                tab[j]= rnd.Next(0,100);
            }
        }

        public void InsertSort(int[] tab)
        {
            for (int i = tab.Length - 1; i > 0; i--)
            {
                for (int j = tab.Length - 1; j > 0; j--)
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
            for (int i = 0; i < tab.Length; i++)
            {
                Napis = Napis + tab[i] + ", ";
            }
            return Napis;
        }

        public int[] MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;
                MergeSort(array, left, middle);
                MergeSort(array, middle + 1, right);
                MergeArray(array, left, middle, right);
            }
            return array;
        }

        public void MergeArray(int[] array, int left, int middle, int right)
        {
            var leftArrayLength = middle - left + 1;
            var rightArrayLength = right - middle;
            var leftTempArray = new int[leftArrayLength];
            var rightTempArray = new int[rightArrayLength];
            int i, j;
            for (i = 0; i < leftArrayLength; ++i)
                leftTempArray[i] = array[left + i];
            for (j = 0; j < rightArrayLength; ++j)
                rightTempArray[j] = array[middle + 1 + j];
            i = 0;
            j = 0;
            int k = left;
            while (i < leftArrayLength && j < rightArrayLength)
            {
                if (leftTempArray[i] <= rightTempArray[j])
                {
                    array[k++] = leftTempArray[i++];
                }
                else
                {
                    array[k++] = rightTempArray[j++];
                }
            }
            while (i < leftArrayLength)
            {
                array[k++] = leftTempArray[i++];
            }
            while (j < rightArrayLength)
            {
                array[k++] = rightTempArray[j++];
            }
        }

        public void QuickSort(int[] tab, int p, int o)
        {
            if (p < o)
            {
                int i = Divide(tab, p, o);
                QuickSort(tab, p, i - 1);
                QuickSort(tab, i + 1, o);
            }
        }

        public int Divide(int[] tab, int p, int o)
        {
            int i = p + (o - p) / 2;
            int temp = tab[i];
            Swap(tab, i, o);
            int a = p;
            for (int j = p; j <= o - 1; j++)
            {
                if (tab[j] < temp)
                {
                    Swap(tab, j, a);
                    a++;
                }
            }
            Swap(tab, a, o);
            return a;
        }

        public void Swap(int[] tab, int i1, int i2)
        {
            if (i1 != i2)
            {
                int pamiecSwap = tab[i1];
                tab[i1] = tab[i2];
                tab[i2] = pamiecSwap;
                return;
            }
        }

        public static int GetMaxVal(int[] tab, int size)
        {
            var maxVal = tab[0];
            for(int i=1; i<size;i++)
                if (tab[i] > maxVal)
                    maxVal = tab[i];
            return maxVal;
        }

        public int[] CountingSort(int[] tab)
        {
            var size = tab.Length;
            var max = GetMaxVal(tab, size);
            var ile = new int[max + 1];

            for (int i=0; i < max + 1; i++)
            {
                ile[i] = 0;
            }
            for(int i=0; i < size; i++)
            {
                ile[tab[i]]++;
            }
            for (int i = 0, j = 0; i <= max; i++)
            {
                while (ile[i] > 0)
                {
                    tab[j] = i;
                    j++;
                    ile[i]--;
                }
            }
            return tab;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
            if (radioButton1.Checked == true)
            {
                InsertSort(tablica);
                label2.Text = CreateString(tablica);
            }
            if (radioButton2.Checked ==true)
            {  
                label2.Text = CreateString(MergeSort(tablica, 0, tablica.Length-1));
            }
            if (radioButton3.Checked == true)
            {
                label2.Text = CreateString(CountingSort(tablica));
            }
            if (radioButton4.Checked == true)
            {
                QuickSort(tablica, 0, tablica.Length-1);
                label2.Text = CreateString(tablica);
            }
            else
            {
                label2.Text= CreateString(tablica);
            }
            stopwatch.Stop();
            long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
            TimeSpan time = stopwatch.Elapsed;
            label3.Text = "Czas wykonywania pracy: " + time.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateArray(tablica, tablica.Length);
            label2.Text = CreateString(tablica);
        }
    }
}
