using System;
using System.Numerics;

namespace SpetralAmlysisForms
{
    public class Filter
    {
        double _maxFreq ;
        double _Sample  ;
        double _K1      ;
        double _K2      ;
        double _gain    ;
        double _bandwith;
        public Filter() 
        {
            _Sample = 300;
            _maxFreq = _Sample/2;
            _K1 = 0;
            _K2 = 0;
            _gain = 0;
            _bandwith = 0;

        }
        public double maxFreq
        {
            set
            {
                //_maxFreq = value;
            }
            get
            {
                return _maxFreq;
            }
        }
        public double Sample
        {
            set { this._Sample = value;this._maxFreq = this._Sample/2; }
            get { return this._Sample; }
        }
        public double K1
        {
            set { this._K1 = -Math.Cos(Math.PI * value / maxFreq); }
            get { return this._K1; }
        }
        public double K2
        {
            set { this._K2 = 1 - Math.Sin(Math.PI * value / this._maxFreq) / Math.Cos(Math.PI * value / this._maxFreq); }
            get { return this._K1; }
        }
        public double gain
        {
            set { this._gain = Math.Pow(10, (value / 20)); }
            get { return this._gain; }
        }
        public double bandwith { set { this._bandwith = value; } get { return this._bandwith; } }

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
        public double[] Filter_Signal(double[] Xn)
        {
            double[] xn = Xn;
            double[] yn = Xn;
            for (int number = 0; number < 1; number++)
            {
                for (int n = 0; n < Xn.Length; n++)
                {
                    if (n == 0)
                    {
                        yn[0] = 0.5f * (1 + _gain + _K2 * (1 - _gain)) * xn[n];
                    }
                    else if (n == 1)
                    {
                        yn[1] = (0.5f * ((1 + _gain) + _K2 * (1 - _gain))) * xn[n]
                            + (_K1 * (1 + _K2)) * xn[n - 1] - _K1
                            * (1 + _K2) * yn[n - 1];
                    }
                    else
                    {
                        yn[n] = (0.5f * ((1 + _gain) + _K2 * (1 - _gain))) * xn[n]
                            + (_K1 * (1 + _K2)) * xn[n - 1] + (0.5f * (_K2 * (1 + _gain) + (1 - _gain))) * xn[n - 2] - _K1
                            * (1 + _K2) * yn[n - 1] - _K2 * yn[n - 2];
                    }
                    if(yn[n]> 1.7976931348623157E+308)
                    {
                        yn[n] = 1.7976931348623157E+307;
                    }
                }

                //xn = yn;
            }
            return yn; // возвращает массив выходных значений (отклик) сигнала 
        }
        public double[] For_ABS(double[] x)
        {
            var k1 = K1;
            var k2 = K2;
            var k3 = k1 * (1 + k2);
            double[] Y = new double[x.Length];
            for (int n = 0; n < x.Length; n++)
            {
                Y[n] = 0.5 * Math.Sqrt((Math.Pow((1 + this._gain) * (1 + k3 *
               Math.Cos(Math.PI * x[n] / this._maxFreq) + k2 * Math.Cos(2 * Math.PI * x[n] / this._maxFreq)) + (1 -
                this._gain) * (k2 + k3 * Math.Cos(Math.PI * x[n] / this._maxFreq) + Math.Cos(2 * Math.PI * x[n] /
               this._maxFreq)), 2) + Math.Pow((1 + this._gain) * (-k3 * Math.Sin(Math.PI * x[n] / this._maxFreq) - k2 *
               Math.Sin(2 * Math.PI * x[n] / this._maxFreq)) + (1 - this._gain) * (-k3 * Math.Sin(Math.PI * x[n] /
               this._maxFreq) - Math.Sin(2 * Math.PI * x[n] / this._maxFreq)), 2)) / (Math.Pow((1 + k3 *
               Math.Cos(Math.PI * x[n] / this._maxFreq) + k2 * Math.Cos(2 * Math.PI * x[n] / this._maxFreq)), 2) +
               Math.Pow((-k3 * Math.Sin(Math.PI * x[n] / this._maxFreq) - k2 * Math.Sin(2 * Math.PI * x[n] /
               this._maxFreq)), 2)));
            }

            return Y;
        }
 
    }
}