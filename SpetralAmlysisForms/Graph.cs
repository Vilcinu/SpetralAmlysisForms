using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpetralAmlysisForms
{
    public partial class Graph : Form
    {
        public static Graph formContainer;
        private System.Windows.Forms.DataVisualization.Charting.Series series;
        public Graph()
        {
            InitializeComponent();
            formContainer = this;
            series = Form1.formContainer.series;
            chart1.Series.Add(series);
        }

        private void circleKnob1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void vScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            Form1.formContainer.gain = vScrollBar3.Value - 50;
            Form1.formContainer.k1 = 20 * vScrollBar1.Value / 100;
            Form1.formContainer.k2 = 0.01 + (2 * vScrollBar2.Value / 100);
            Form1.formContainer.test(5);
        }
    }
}
