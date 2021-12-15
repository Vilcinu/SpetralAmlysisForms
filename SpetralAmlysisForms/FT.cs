using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SpetralAmlysisForms
{
    public class FT
    {
        const int N = 1024; // количество разбиений
        double[] InnerArray = new double[N];
        Complex[] Furie = new Complex[N];
        public double[] Amplitude; // Амплитуда для АЧХ
        public double[] Faze; // Фаза для ФЧХ
        public double[] Frecuensy; // Частота гармоники


        private static Complex w(int k, int N)
        {
            double arg = Math.PI*2*k/N;

            return (new Complex(Math.Cos(arg), Math.Sin(arg)));
        }
        public static Complex[] ft(Complex[] input)
        {
            //if (input1 % input2 == 0) return 1;
            //k - number;
            //N- amount;
            //T - equal intervals,discretisatuion,period;
            //omega = 2*pi/(N*T)
            Complex[] X = new Complex[input.Length];
            for (int n= 0;n<input.Length-1;n++)
            {
                X[n] = input[n] * w(n, input.Length);
            }
            return X;
        }
        public static Complex[] DPF(Complex[] Inner)
        {
            int N = Inner.Length;
            double[]Amplitude = new double[N];
            double[]Faze= new double[N];
            double[] Frecuensy = new double[N];
            Complex[] Furie = new Complex[N];
            double Arg;

            for (int k = 0; k < N; k++)
            {
                Furie[k] = new Complex();
                for (int n = 0; n < Inner.Length; n++)
                {
                    Arg = 2 * Math.PI * k * n / N;
                    Furie[k] += new Complex(Inner[n].Real * Math.Cos(Arg), -Inner[n].Imaginary * Math.Sin(Arg));
                    //Furie[k].Im -= Inner[n] * Math.Sin(Arg);
                }
                Amplitude[k] = (Math.Sqrt(Math.Pow(Furie[k].Real, 2) + Math.Pow(Furie[k].Imaginary, 2))) / N;
                Faze[k] = Math.Atan(Furie[k].Imaginary / Furie[k].Real / Math.PI * 180);
                Frecuensy[k] = ((N - 1) * (k));

            }
            return Furie;
        }

    }
}
