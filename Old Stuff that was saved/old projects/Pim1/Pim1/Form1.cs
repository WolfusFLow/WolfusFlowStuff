using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const string message =
        "Попробуйте другие значения";

        double frmx()
        {

            try
            {
                double Cpz = Convert.ToDouble(textBox1.Text);
                double Pz = Convert.ToDouble(textBox2.Text);
                double t = Convert.ToDouble(textBox3.Text);
                return (((Math.Log10(Pz) - Cpz) / Math.Log10(t)) * (-1));
            }
            catch (FormatException) { MessageBox.Show(message); }
            return (0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisY.ScaleView.Zoom(0, 15);
            chart1.ChartAreas[0].AxisX.ScaleView.Zoom(0, 20);
            chart1.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;

        }
    }
}
