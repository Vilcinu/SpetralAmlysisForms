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

        public float FindMin(Complex[] inputArray, int type)//type = REAL,IMAGINARY,PHASE,MAGNITUDE;
        {
            float min = 0;
            for (int n = 0; n < inputArray.Length; n++)
            {
                if (type == Constants.REAL)
                {
                    if (inputArray[n].Real < min)
                        min = (float)inputArray[n].Real;
                }
                if (type == Constants.IMAGINARY)
                {
                    if (inputArray[n].Imaginary < min)
                        min = (float)inputArray[n].Imaginary;
                }
                if (type == Constants.PHASE)
                {
                    if (inputArray[n].Phase < min)
                        min = (float)inputArray[n].Phase;
                }
                if (type == Constants.MAGNITUDE)
                {
                    if (inputArray[n].Magnitude < min)
                        min = (float)inputArray[n].Magnitude;
                }
            }
            return min;
        }

        public float FindMax(Complex[] inputArray, int type)//type = REAL,IMAGINARY,PHASE,MAGNITUDE;
        {
            float max = 0;
            for (int n = 0; n < inputArray.Length; n++)
            {
                if (type == Constants.REAL)
                {
                    if (inputArray[n].Real > max)
                        max = (float)inputArray[n].Real;
                }
                if (type == Constants.IMAGINARY)
                {
                    if (inputArray[n].Imaginary > max)
                        max = (float)inputArray[n].Imaginary;
                }
                if (type == Constants.PHASE)
                {
                    if (inputArray[n].Phase > max)
                        max = (float)inputArray[n].Phase;
                }
                if (type == Constants.MAGNITUDE)
                {
                    if (inputArray[n].Magnitude > max)
                        max = (float)inputArray[n].Magnitude;
                }
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
            Complex[] testvar = new Complex[power];
            double[] testvarDouble = new double[power];
            for (int n = 0; n < power; n++)
            {
                double argument = 2 * n;
                testvar[n] = new Complex(Math.Sin(1 * argument) + Math.Sin(5 * argument) + Math.Sin(20 * argument), 0);
                testvarDouble[n] = (Math.Sin(1 * argument) + Math.Sin(5 * argument) + Math.Sin(20 * argument));
            }
            if(originalSignal != null)
            {
                for (int n = 0; n < power; n++)
                {
                    originalSignal.Points.AddXY(n / _SignalSample, testvar[n]);
                }
            }
            testvarDouble = Filter.Filter_Signal(testvarDouble,filt.K1 ,filt.K2 ,filt.gain );
            //testvarDouble = SDFT.sdft(testvarDouble);
            for (int n = 0; n < power; n++)
            {
                this.series.Points.AddXY(n / _SignalSample, testvarDouble[n]);
            }

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
            filt.gain = 90*(hScrollBar3.Value-50)/100;
            filt.K1 = ((double)hScrollBar1.Value/100)*20;
            filt.K2 = 10 * hScrollBar2.Value / 100;
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