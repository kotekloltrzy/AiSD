﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drzewko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Tree Drzewko = new Tree();

        private void button1_Click(object sender, EventArgs e)
        {
            Drzewko.Insert(Decimal.ToInt32(numericUpDown1.Value));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Drzewko.InOrderTraversal();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Drzewko.Find(Decimal.ToInt32(numericUpDown2.Value));
        }
    }
}
