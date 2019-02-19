using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedProgramming;


namespace TextStatistics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<int, int> list = 
                ObjectOrientedProgramming.StringStatistics.statisticsOfStringStat(textBox1.Text);

            foreach (KeyValuePair<int, int> kvp in list)
            {
                richTextBox1.Text += (char)kvp.Key + " " + kvp.Value + "\n";
            }
        }
    }
}
