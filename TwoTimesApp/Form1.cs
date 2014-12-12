using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoTimesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void twoTimesButton_Click(object sender, EventArgs e)
        {
            //string a = "656";
            //double b = Convert.ToDouble(a);
            double anumber = Convert.ToDouble(aNumberTextBox.Text);
            double result = anumber*2;
            twoTimesValueTextBox.Text = result.ToString();
        }
    }
}
