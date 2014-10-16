using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CsStatsCalculator;

namespace StatsCalculatorGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.TextChanged += button1_Click;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && textBox1.Text.Trim().Length > 0)
            {
                listBox1.Items.Add(textBox1.Text.Trim());
                textBox1.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculateStats();
        }

        private void calculateStats()
        {
            if (listBox1.Items.Count > 0)
            {
                List<Int32> intList = new List<Int32>();
                foreach (String i in listBox1.Items)
                    intList.Add(Convert.ToInt32(i));
                StatsCalculator sc = new StatsCalculator(intList);
                textBoxMean.Text = sc.Mean.ToString();
                textBoxMode.Text = sc.Mode.ToString();
                textBoxFrequency.Text = sc.ModeFrequency.ToString();
                textBoxMedian.Text = sc.Median.ToString();
            }
        }
    }
}
