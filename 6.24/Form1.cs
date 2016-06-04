using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _6._24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int x = rand.Next(1, 4);//1以上4未満の乱数(1～3)
            if (x == 1)
                label1.Text = "大吉";
            else if (x == 2)
                label1.Text = "吉";
            else if (x == 3)
                label1.Text = "凶";
        }
    }
}
