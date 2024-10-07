using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zaddom
{
    public partial class Form1 : Form
    {
        int[] Lista = { 2, 7, 4, 8, 1, 5 };
        public Form1()
        {
            InitializeComponent();
            string Tytol = "";
            for (int i = 0; i < Lista.Length; i++)
            {
                Tytol = Tytol + Lista[i] + " ";
            }
            label2.Text = Tytol;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < Lista.Length; j++)
            {
                for (int i = 0; i < Lista.Length-1; i++)
                {
                    int Pamiec = 0;
                    if (Lista[i] >= Lista[i + 1])
                    {
                        Pamiec = Lista[i + 1];
                        Lista[i + 1] = Lista[i];
                        Lista[i] = Pamiec;
                    }
                }
            }
            string Tekst = "";
            for (int i = 0; i < Lista.Length; i++)
            {
                Tekst = Tekst + Lista[i] + " ";
            }
            label1.Text = Tekst;
            label1.Visible = true;
        }
    }
}
