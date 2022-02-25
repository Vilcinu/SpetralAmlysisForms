using System;
using System.Drawing;
using System.Numerics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace SpetralAmlysisForms
{
    internal enum axis
    {
        Re,
        Img,
        Ph,
        Mag
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
        private int powerOfTwo = 7;
        private int evrywhereValue = 25;
        private int __audioDuration = 10;
        private int __FilterOption = 0;
        private int boxcount = 0;
        private double[] Signal;
        private double[] Signalphase;
        private double[] originalSignal;
        private int samplesPerSecond = 1024;
        private double beforeChartWillBreakValue = 10E10;
        public static Form1 formContainer;
        public System.Windows.Forms.DataVisualization.Charting.Series series;
        public System.Windows.Forms.DataVisualization.Charting.Series seriesphase;
        public Graph graph;
        public double _SignalSample;
        public double k1;
        public double k2;
        public double gain;
        MemoryStream mStrm;
        BinaryWriter writer;

        public Form1()
        {
            InitializeComponent();
            this.charts[0] = this.FUNCTIONCHART;
            this.charts[1] = this.WAVECHART;
            this.charts[2] = this.FREQCHART;
            this.charts[3] = this.EQCHART;
            _SignalSample = 5000;
            hScrollBar3.Value = 50;
            formContainer = this;
            series = charts[0].Series.Add("Test Text");
            seriesphase = chart2.Series.Add("Test Text");
            for (int n = 0; n < Math.Pow(2, powerOfTwo); n++)
            {
                series.Points.AddXY(n, f(n));
                seriesphase.Points.AddXY(n, n);
            }
            this.series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            this.charts[0].Series[0].MarkerSize = 4;
            graph = new Graph();
            originalSignal = new double[(int)Math.Pow(2, powerOfTwo)];
            for (int n = 0; n < Math.Pow(2,powerOfTwo); n++)
            {
                //testvar[n] = new Complex(Math.Sin(1 * argument) + Math.Sin(5 * argument) + Math.Sin(20 * argument), 0);
                originalSignal[n] = f(n);

            }
        }

        public double f(int arg)
        {
            return 25 * Math.Cos(arg)+ 5*Math.Cos(2 * arg) +  Math.Cos(2 * arg) + 3 * Math.Cos(2 * arg) + 4* Math.Cos(2 * arg);
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

        public async Task drawcahrt()
        {
            this.charts[boxcount].Series.Clear();
            this.chart2.Series.Clear();

            //setChartMinAndMax(Signal);

            this.series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            //chart1.ChartAreas[0].AxisY.Minimum = 0;
            //chart1.ChartAreas[0].AxisY.Maximum = 100;
            this.charts[boxcount].Series.Add(series);
            this.chart2.Series.Add(seriesphase);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(System.Windows.Forms.Keys.A))
                fill_series(powerOfTwo);
        }

        public async Task fill_series(int input)//input amount;
        {
            series.Points.Clear();
            seriesphase.Points.Clear();
            int power = (int)Math.Pow(2, input);
            Signal = new double[power];
            filt.Sample = power*2;
            switch(boxcount)
            {
                case 0:
                    signalFilter().Wait();
                    break;

                case 1:
                    fftFilter().Wait();
                    break;

                case 2:
                    eqFilter().Wait();
                    break;

                default:
                    justFunction().Wait();
                    break;


            }
            for (int n = 0; n < power; n++)
            {
                this.series.Points.AddXY(n, Signal[n]);
                this.seriesphase.Points.AddXY(n, Signalphase[n]);
            }
            //_ = Round(Signal, 7);
            await drawcahrt();
        }

        private void circleKnob1_Click(object sender, EventArgs e)
        {
            openChildForm();
        }

        private void openChildForm()
        {
            graph = new Graph();
            formContainer = this;
            graph.WindowState = FormWindowState.Maximized;
            graph.Activate();
            graph.Show();
        }

        private void circleKnob2_Click(object sender, EventArgs e)
        {
            fill_series(powerOfTwo).Wait() ;
        }
        private void FilterOptionComboBox_VisibleChanged(object sender, EventArgs e)
        {
            GetValuesFromScrollBoxes();
        }
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
                GetValuesFromScrollBoxes();
        }

        private async Task GetValuesFromScrollBoxes()
        {
            
            filt.gain = hScrollBar3.Value - 50;
            filt.K1 = (double)hScrollBar1.Value*filt.maxFreq/91;
            filt.K2 = (double)(hScrollBar2.Value)*42/91;
            label4.Text = filt.K1.ToString();
            label5.Text = filt.K2.ToString();
            label6.Text = filt.gain.ToString();
            textBox1.Text = hScrollBar1.Value.ToString();
            textBox2.Text = hScrollBar2.Value.ToString();
            textBox3.Text = (hScrollBar3.Value-50).ToString();
            __FilterOption = FilterOptionComboBox.SelectedIndex;
            //getAsandBs();
            //audio();
            fill_series(powerOfTwo);
        }

        private void fadeAnim()
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //openChildForm();
            playAudio();
        }

        private async void button_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).Tag = "1";
            var color = ((Button)sender).BackColor.R;
            while (color > 180)
            {
                if (color - color / 45 <= 180)
                {
                    ((Button)sender).Tag = "0";
                    return;
                }
                ((Button)sender).BackColor = Color.FromArgb(color - color / 45,
                                                            color - color / 45,
                                                            color - color / 45);
                color = ((Button)sender).BackColor.R;
                await Task.Delay(1);
            }

            //button_MouseLeave(sender, e);
        }

        private async void button_MouseLeave(object sender, EventArgs e)
        {
            while (((Button)sender).Tag == "1")
            {
                await Task.Delay(20);
            }
            var color = ((Button)sender).BackColor.R;
            while (color < 255)
            {
                if (color + color / 25 > 255)
                {
                    color = 255;
                    ((Button)sender).BackColor = Color.FromArgb(color,
                                                                color,
                                                                color);
                    break;
                }

                ((Button)sender).BackColor = Color.FromArgb(color + color / 45,
                                                            color + color / 45,
                                                            color + color / 45);
                color = ((Button)sender).BackColor.R;
                await Task.Delay(1);
            }
            fadeAnim();
        }

        private async void panel1_MouseEnter(object sender, EventArgs e)
        {
            //414, 456

            int growUntily = 456;
            ((Panel)sender).Tag = "1";
            while (panel1.Size.Height < growUntily)
            {
                if (((Panel)sender).Tag.ToString() != "1")
                {
                    return;
                }
                panel1.Size = new Size(414, panel1.Size.Height + panel1.Size.Height / 25);
                await Task.Delay(1);
                if (panel1.Size.Height > 440)
                {
                    panel1.Size = new Size(panel1.Size.Width, 456);
                }
            }
        }

        private async void panel1_MouseLeave(object sender, EventArgs e)
        {
            /*int growUntily = 64;
            ((Panel)sender).Tag = "0";
            while (panel1.Size.Height > growUntily)
            {
                if (((Panel)sender).Tag.ToString() != "0")
                {
                    return;
                }
                panel1.Size = new Size(414, panel1.Size.Height - panel1.Size.Height/25) ;
                await Task.Delay(1);
            }*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
            filt.Sample = Convert.ToDouble(textBox4.Text);
            filt.gain = Convert.ToDouble(textBox3.Text);
            filt.K1 = Convert.ToDouble(textBox1.Text);
            filt.K2 = Convert.ToDouble(textBox2.Text);
            label4.Text = filt.K1.ToString();
            label5.Text = filt.K2.ToString();
            label6.Text = filt.gain.ToString();
            getAsandBs();
            test(powerOfTwo);*/
        }

        private void getAsandBs()
        {
            b0_text.Text = String.Format("{0:0.0000000}", (0.5 * (1 + filt.gain + filt.K2 * (1 - filt.gain))));
            b1_text.Text = String.Format("{0:0.0000000}", (0.5 * (1 - filt.gain + filt.K2 * (1 + filt.gain))));
            b2_text.Text = String.Format("{0:0.0000000}", (filt.K1 * (1 + filt.K2)));
            a1_text.Text = String.Format("{0:0.0000000}", (filt.K1 * (1 + filt.K2)));
            a2_text.Text = String.Format("{0:0.0000000}", (filt.K2));
        }

        private double[] Round(double[] input, int round)
        {
            double[] Result = input;

            for (int n = 0; n < Result.Length; n++)
            {
                Result[n] = Math.Round(Result[n], round);
                if(Result[n]> beforeChartWillBreakValue)
                {
                    Result[n] = beforeChartWillBreakValue;
                }
                if (Result[n] < -beforeChartWillBreakValue)
                {
                    Result[n] = -beforeChartWillBreakValue;
                }
            }

            return Result;
        }

        private void setChartMinAndMax(double[] input)
        {
            double minvalue = input[input.Length / 2];
            double maxvalue = input[input.Length / 2];

            for (int n = 0; n < input.Length; n++)
            {
                if (input[n] > maxvalue)
                {
                    maxvalue = input[n];
                }
                if (input[n] < minvalue)
                {
                    minvalue = input[n];
                }
            }
            textBox5.Text = minvalue.ToString();
            textBox6.Text = maxvalue.ToString();
            minvalue = Math.Round(minvalue, 7);
            maxvalue = Math.Round(maxvalue, 7);
            if(maxvalue>10E7)
            {
                maxvalue = 10E7;
            }
            if(minvalue<-10E7)
            {
                minvalue = -10E7;
            }

        }
        private void audio()
        {
            /*System.Media.SoundPlayer mw = new System.Media.SoundPlayer("C://Users//User//Documents//Image-Line//FL Studio//Audio//Sliced audio//Untitled project - 2020-Apr-29_3.wav");
            mw.Play();*/
            UInt16 frequency = 200; 
            int msDuration = 10;
            UInt16 volume = 16000;
            mStrm = new MemoryStream();
            writer = new BinaryWriter(mStrm);

            int formatChunkSize = 16;
            int headerSize = 1;
            short formatType = 1;
            short tracks = 1;
            
            short bitsPerSample = 16;
            short frameSize = (short)(tracks * ((bitsPerSample + 7) / 8));
            int bytesPerSecond = samplesPerSecond * frameSize;
            int waveSize = 1;
            int samples = (int)((decimal)samplesPerSecond * msDuration / 1000);
            int dataChunkSize = samples * frameSize;
            int fileSize = waveSize + headerSize + formatChunkSize + headerSize + dataChunkSize;
            filt.Sample = samples;
            ////////////////////////////////////////////////////f//ill_series(samples);
            // var encoding = new System.Text.UTF8Encoding();
            writer.Write(0x46464952); // = encoding.GetBytes("RIFF")
            writer.Write(fileSize);
            writer.Write(0x45564157); // = encoding.GetBytes("WAVE")
            writer.Write(0x20746D66); // = encoding.GetBytes("fmt ")
            writer.Write(formatChunkSize);
            writer.Write(formatType);
            writer.Write(tracks);
            writer.Write(samplesPerSecond);
            writer.Write(bytesPerSecond);
            writer.Write(frameSize);
            writer.Write(bitsPerSample);
            writer.Write(0x61746164); // = encoding.GetBytes("data")
            writer.Write(dataChunkSize);
            {
               // double theta = frequency * TAU / (double)samplesPerSecond;
                // 'volume' is UInt16 with range 0 thru Uint16.MaxValue ( = 65 535)
                // we need 'amp' to have the range of 0 thru Int16.MaxValue ( = 32 767)
                double amp = volume >> 2; // so we simply set amp = volume / 2
                for (int step = 0; step < filt.Sample/2; step++)
                {
                    short s = (short)(amp * Signal[step]);
                    writer.Write(s);
                }
            }




        }
        private async void playAudio()
        {
            if(mStrm==null|| mStrm==null)
            {
                audio();
            }
            
            for (int n = 0; n < __audioDuration; n++)
            {
                mStrm.Seek(0, SeekOrigin.Begin);

                new System.Media.SoundPlayer(mStrm).Play();
                await Task.Delay(1);
            }
            //writer.Close();
            //mStrm.Close();
        }
        private async void autoFilter()
        {
            signalFilter().Wait();
        }        

        private async Task justFunction()
        {
            Signal = originalSignal;
        }
        private async Task signalFilter()
        {
            Signal = filt.Filter_Signal(originalSignal);
        }
        private async Task fftFilter()
        {
            Signalphase = SDFT.sdft(originalSignal);
        }
        private async Task eqFilter()
        {
            for (int n = 0; n < filt.Sample / 2; n++)
            {
                Signal[n] = n/2;
            }
            Signal = filt.For_ABS(Signal);
        }

        private void panel5_MouseEnter(object sender, EventArgs e)
        {
            
            
        }

        private void panel5_MouseCaptureChanged(object sender, EventArgs e)
        {
            
           // if()
        }


        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            
            


        }
        private async void panel5_MouseWheel(object sender, MouseEventArgs e)
        {
           

            textBox4.Text = boxcount.ToString();//button5678[0]
            var dirrection = e.Delta/120;

           
            if(dirrection > 0)//scroll UP
            {
                moveup();
            }
            if(dirrection<0) //scroll DOWN
            {
                movedown();
            }
            label7.Text = boxcount.ToString();
        }
        private async void moveup()
        {
            double buttonLocation = 0;
            if (boxcount != 0)
            {
                boxcount--;
                fill_series(powerOfTwo);
                boxcount++;
            }
            if (charts[boxcount].Location.Y == 0)
            {
                charts[boxcount].Location = new Point(charts[boxcount].Location.X, -1);
            }
            while (charts[boxcount].Location.Y > panel5.Height * -1)
            {
                buttonLocation = (double)(charts[boxcount].Location.Y + (double)(charts[boxcount].Location.Y) / 6);
                buttonLocation = Math.Floor(buttonLocation);
                charts[boxcount].Location = new Point(charts[boxcount].Location.X, (int)buttonLocation);
                await Task.Delay(5);
            }
            if (charts[boxcount].Location.Y <= panel5.Height * -1)
            {
                charts[boxcount].Location = new Point(charts[boxcount].Location.X, panel5.Height * -1);

                boxcount++;
                if (boxcount > 3)
                    boxcount--;
                else
                    this.charts[boxcount - 1].Series.Clear();

                fill_series(powerOfTwo);
            }
        }
        private async void movedown()
        {
            double buttonLocation = 0;
            fill_series(powerOfTwo);


            while (charts[boxcount].Location.Y < 0)
            {

                buttonLocation = (double)(charts[boxcount].Location.Y - (double)charts[boxcount].Location.Y / 6);
                charts[boxcount].Location = new Point(charts[boxcount].Location.X, (int)buttonLocation);
                await Task.Delay(5);
            }
            if (charts[boxcount].Location.Y <= 0)
            {
                charts[boxcount].Location = new Point(charts[boxcount].Location.X, -1);


                fill_series(powerOfTwo);
                if (boxcount != 0)
                    boxcount--;
            }
        }
    }
}