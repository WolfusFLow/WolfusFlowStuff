using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        double C = 2;
        //  double a = Convert.ToDouble(TextBox1.Text);
        double a = 2;
        double Cpz = 2;
        double V = 3;
        double t = 2;
        double S = 2;
        double z = 2;
        double function(double x)
        {
            double o = Convert.ToDouble(textBox1.Text);
            //function y = C*x^a
            return (C * Math.Pow(x, a));
        }

        double function1(double x1)
        {
            //function Pz=Cpz*(V^t)*(t^y)*(S^z)
            return (Cpz*(Math.Pow(V,x1))*(Math.Pow(t,function(x1)))*(Math.Pow(S, z)));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisY.ScaleView.Zoom(-15, 15);
            chart1.ChartAreas[0].AxisX.ScaleView.Zoom(-5, 20);
            chart1.ChartAreas[0].CursorX.IsUserEnabled=true;
            chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled=true;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;


            chart2.ChartAreas[0].AxisY.ScaleView.Zoom(-15, 15);
            chart2.ChartAreas[0].AxisX.ScaleView.Zoom(-5, 20);
            chart2.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart2.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart2.ChartAreas[0].AxisX.ScaleView.Zoomable = true;

            /* for (int i = 0; i< 4; i++)
             {
                 chart1.Series[0].Points.AddXY(i, function(i));

             }
             */

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double o = Convert.ToDouble(textBox1.Text);

            chart1.Series[0].Points.Clear();
            for (int i = 0; i < 4; i++)
            {
                chart1.Series[0].Points.AddXY(i, function(i));
            }

            chart2.Series[0].Points.Clear();
            for (int i = 0; i < 4; i++)
            {
                chart2.Series[0].Points.AddXY(i, function1(i));
            }

        }
                
    }
}
