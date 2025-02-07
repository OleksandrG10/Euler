using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SumMultiplesThreeFiveBelowThousand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public int[] array = new int[1000];
        public int result = 0;

        public void Sum()
        {                         
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += i;
            }

            for (int i = 0; i < array.Length; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    result += i;
                    richTextBox1.Text += string.Format("array[{0}] = {1}", i, i) + "\n";
                }                
            }
            textBox1.Text = Convert.ToString(result);            
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            Sum();
            btnSum.Enabled = false;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            result = 0;
            textBox1.Text = "";
            richTextBox1.Text = "";
            btnSum.Enabled = true;
        }
    }
}
