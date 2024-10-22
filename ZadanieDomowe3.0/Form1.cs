using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadanieDomowe3._0
{
    public partial class Form1 : Form
    {
        internal List list = new List();
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            list.AddFirst(Decimal.ToInt32(addFirstValue.Value));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            list.AddLast(Decimal.ToInt32(addLastValue.Value));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            list.Get(Decimal.ToInt32(GetNValue.Value));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            list.RemoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            list.RemoveLast();
        }
    }
}
