using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double exp = 2.7;
        double l1 = 0.5;
        double l2 = 0.15;
        Random rnd = new Random();
        
        public double frmx()
        {
            double fi2 = rnd.NextDouble();
            double X = Math.Acos((Math.Cos(0) + l2 * Math.Cos(fi2)) / exp);
            return (X);
        }
            
        public double frmy()
        {            
            double fi1 = rnd.NextDouble();
            double Y = Math.Asin((Math.Sin(0) + l1 * Math.Sin(fi1)) / exp);           
            return (Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {                        
            textBox3.Text = frmx().ToString();
            textBox4.Text = frmy().ToString();
        }
    }
}
