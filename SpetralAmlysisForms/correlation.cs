using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SpetralAmlysisForms
{
    class correlation
    {
        public static Complex[] corr(Complex[] x1,Complex[] x2)
        {
            int N = x1.Length;
            Complex[] Result = new Complex[N];
            double Real;
            double Imaginary;
            double productR = x1[0].Real * x2[0].Real;
            double productI = x1[0].Imaginary * x2[0].Imaginary;
            for (int n = 0; n < N - 1; n++)
            {
                if (n != 0)
                {
                    Real = Result[n - 1].Real + ((x1[n].Real * x2[n].Real/N) - (productR/N));
                    Imaginary = Result[n - 1].Imaginary + ((x1[n].Imaginary * x2[n].Imaginary/N) - (productI/N));
                    Result[n] = new Complex(Real, Imaginary);
                }
                else
                    Result[n] = new Complex(0, 0);
            }
            return Result;
        }

    }
}
