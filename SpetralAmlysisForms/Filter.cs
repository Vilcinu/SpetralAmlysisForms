using System;
using System.Numerics;

namespace SpetralAmlysisForms
{
    public class Filter
    {
        public Filter() 
        {
            maxFreq = 0;
            Sample = 0;
            K1 = 0;
            K2 = 0;
            gain = 0;
            bandwith = 0;

        }
        public double maxFreq;
        public double Sample
        {
            set { Sample = value;}
            get { return Sample; }
        }
        public double K1
        {
            set { K1 = -Math.Cos(Math.PI * value / maxFreq); }
            get { return K1; }
        }
        public double K2
        {
            set { K2 = 1 - Math.Sin(Math.PI * value / maxFreq) / Math.Cos(Math.PI * value / maxFreq); }
            get { return K1; }
        }
        public double gain
        {
            set { gain = Math.Pow(10, (value / 20)); }
            get { return gain; }
        }
        public double bandwith { set; get; }

        Complex e(double arg)
        {
            Complex Result;
            Result = new Complex(Math.Cos(arg), Math.Sin(arg));
            return Result;
        }
        public static Complex[] filter(Complex[] X, double w, double B, double alpha, double maxw)
        {

            int filteParamsLength = 3;
            alpha = Math.Pow(10, alpha / 20);
            double accFuncArg = Math.PI / maxw;

            double k1 = -Math.Cos(w * accFuncArg);
            double k2 = (1 - Math.Sin(B * accFuncArg)) / Math.Cos(B * accFuncArg);

            double[] a = new double[filteParamsLength];
            double[] b = new double[filteParamsLength];

            Complex[] Y = new Complex[X.Length];
            Complex A_Part = new Complex(0, 0);
            Complex B_Part = new Complex(0, 0);

            Y[0] = new Complex(0, 0);

            {
                b[0] = ((1 + alpha) + ((1 - alpha) * k2)) / 2;
                a[0] = 1;

                b[1] = k1 * (1 + k2);
                a[1] = b[1];

                b[2] = ((1 - alpha) + ((1 + alpha) * k2)) / 2;
                a[2] = k2;
            }

            for (int n = filteParamsLength; n < X.Length; n++)
            {
                for (int k = 0; k < filteParamsLength; k++)
                {
                    B_Part = new Complex(b[k] * X[n - k].Real, 0);
                }
                for (int i = 1; i < filteParamsLength; i++)
                {
                    A_Part = new Complex(a[i] * Y[n - i - 1].Real, 0);
                }
                Y[n] = Complex.Subtract(A_Part, B_Part);
            }

            return Y;
        }
        public static double[] Filter_Signal(double[] Xn, double k1, double k2, double gain)
        {
            double[] xn = Xn;
            double[] yn = Xn;
            for (int number = 0; number < 1; number++)
            {
                for (int n = 0; n < Xn.Length; n++)
                {
                    if (n == 0)
                    {
                        yn[0] = 0.5f * (1 + gain + k2 * (1 - gain)) * xn[n];
                    }
                    else if (n == 1)
                    {
                        yn[1] = (0.5f * ((1 + gain) + k2 * (1 - gain))) * xn[n]
                            + (k1 * (1 + k2)) * xn[n - 1] - k1
                            * (1 + k2) * yn[n - 1];
                    }
                    else
                    {
                        yn[n] = (0.5f * ((1 + gain) + k2 * (1 - gain))) * xn[n]
                            + (k1 * (1 + k2)) * xn[n - 1] + (0.5f * (k2 * (1 + gain) + (1 - gain))) * xn[n - 2] - k1
                            * (1 + k2) * yn[n - 1] - k2 * yn[n - 2];
                    }
                }

                xn = yn;
            }
            return yn; // возвращает массив выходных значений (отклик) сигнала 
        }
        private double For_ABS(float x)
        {
            var k1 = K1;
            var k2 = K2;
            var k3 = k1 * (1 + k2);
            return float.Parse(Convert.ToString(0.5 * Math.Sqrt((Math.Pow((1 + gain) * (1 + k3 *
           Math.Cos(Math.PI * x / maxFreq) + k2 * Math.Cos(2 * Math.PI * x / maxFreq)) + (1 -
           gain) * (k2 + k3 * Math.Cos(Math.PI * x / maxFreq) + Math.Cos(2 * Math.PI * x /
           maxFreq)), 2) + Math.Pow((1 + gain) * (-k3 * Math.Sin(Math.PI * x / maxFreq) - k2 *
           Math.Sin(2 * Math.PI * x / maxFreq)) + (1 - gain) * (-k3 * Math.Sin(Math.PI * x /
           maxFreq) - Math.Sin(2 * Math.PI * x / maxFreq)), 2)) / (Math.Pow((1 + k3 *
           Math.Cos(Math.PI * x / maxFreq) + k2 * Math.Cos(2 * Math.PI * x / maxFreq)), 2) +
           Math.Pow((-k3 * Math.Sin(Math.PI * x / maxFreq) - k2 * Math.Sin(2 * Math.PI * x /
           maxFreq)), 2)))));
        }
 
    }
}