using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SpetralAmlysisForms
{
    class Convolution
    {
        public static Complex[] convolution(Complex[] g, Complex[] f)
        {
            double result1;
            double result2;
            int N = g.Length;
            if(g.Length != f.Length)
            {
                return (g);
            }
            Complex[] Result = new Complex[N];
            for ( int n = 1;n<g.Length;n++)
            {
                Result[n] = Result[n-1] + new Complex((g[n].Real * f[N - n - 1].Real), (g[n].Imaginary * f[N - n - 1].Imaginary));
            }


            return Result;
        }
            
            

    }
}
