using System;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;

namespace SpetralAmlysisForms
{
    internal enum axis
    {
        Re,
        Img,
        Ph,
        Mag
    }

    internal enum en
    {
        something
    }

    public partial class Form1 : Form
    {
        public static class Constants
        {
            public const int REAL = 0;
            public const int IMAGINARY = 1;
            public const int PHASE = 2;
            public const int MAGNITUDE = 3;
        }
        private Filter filt = new Filter();
        public static Form1 formContainer;
        public System.Windows.Forms.DataVisualization.Charting.Series series;
        public System.Windows.Forms.DataVisualization.Charting.Series originalSignal;
        public Graph graph;
        public double _SignalSample;
        public double k1;
        public double k2;
        public double gain;
        private int powerOfTwo = 8;
        public Form1()
        {
            InitializeComponent();
            _SignalSample = 300;
            hScrollBar3.Value = 50;
            formContainer = this;
            series = chart1.Series.Add("Total Income");
            for (int n = 0; n < 100; n++)
                series.Points.AddXY(n, n * n);
            graph = new Graph();
        }
        public double f(int arg)
        {
            double ARG = arg;
            ARG = arg * Math.PI * 2;
            return (Math.Sin(2 * ARG) + Math.Sin(5 * ARG));
        }

        public double FindMin(double[] input)//type = REAL,IMAGINARY,PHASE,MAGNITUDE;
        {
            double min = double.PositiveInfinity;
            for (int n = 0; n < input.Length; n++)
            {
                if (input[n] < min)
                    min = input[n];
            }
            return min;
        }

        public double FindMax(double[] input)//type = REAL,IMAGINARY,PHASE,MAGNITUDE;
        {
            double max = -double.PositiveInfinity;
            for (int n = 0; n < input.Length; n++)
            {
                if (input[n] > max)
                    max = input[n];
            }
            return max;
        }

        public void drawall()
        {
            try
            {
                this.chart1.Series.Clear();
                this.series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                this.chart1.Series.Add(series);
                this.chart1.Series[0].BorderWidth = 2;
                PointF PointComplexFirst = new PointF(0, 0);
                PointF PointComplexSecond = new PointF(0, 0);
                PointF pointbuff1 = new PointF(0, 0);
                PointF pointbuff2 = new PointF(0, 0);
            }
            catch { };
        }

        private void label1_Move(object sender, EventArgs e)
        {
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(System.Windows.Forms.Keys.A))
                test(10);
        }

        public void test(int input)//input amount;
        {
            series.Points.Clear();
            int power = (int)Math.Pow(2, input);
            filt.Sample = power * 2;
            Complex[] testvar = new Complex[power];
            double[] testvarDouble = new double[power];
            for (int n = 0; n < power; n++)
            {
                double argument = 2 * n* Math.PI;
                testvar[n] = new Complex(Math.Sin(1 * argument) + Math.Sin(5 * argument) + Math.Sin(20 * argument), 0);
                testvarDouble[n] = (Math.Sin(1 * argument) + Math.Sin(5 * argument) + Math.Sin(20 * argument));
            }
            if(originalSignal != null)
            {
                for (int n = 0; n < power; n++)
                {
                    
                    originalSignal.Points.AddXY(n, testvar[n]);
                }
            }
            
            testvarDouble = filt.Filter_Signal(testvarDouble);
            testvarDouble = filt.For_ABS(testvarDouble);
            //testvarDouble = SDFT.sdft(testvarDouble);
            //testvarDouble = SDFT.sdft(testvarDouble);

            for (int n = 0; n < power; n++)
            {
                this.series.Points.AddXY(n, 20* Math.Log(testvarDouble[n]));
                
            }
            double Max = FindMax(testvarDouble);
            //chart1.ChartAreas[0].AxisY.Maximum = 0.1;
            //chart1.ChartAreas[0].AxisY.Minimum = -0.1;
            chart1.ChartAreas[0].AxisX.Maximum = filt.maxFreq;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            drawall();
        }

        private void backgroundWorker1_DoWork(object sender, MouseEventArgs e)
        {
        }

        private void circleKnob1_Click(object sender, EventArgs e)
        {
            openChildForm();
        }

        private void openChildForm()
        {
            //Graph graph = new Graph();
            graph.WindowState = FormWindowState.Maximized;
            graph.Show();
        }

        private void circleKnob2_Click(object sender, EventArgs e)
        {
            test(powerOfTwo);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            filt.gain = (double)(hScrollBar3.Value - 50) / 91;
            filt.K1 = (double)hScrollBar1.Value / 91;
            filt.K2 = (double)hScrollBar2.Value / 91;
            test(powerOfTwo);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                k1 = Convert.ToDouble(textBox1.Text);
                test(powerOfTwo);
            }
            catch { }
        }
    }
}