using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace SpetralAmlysisForms
{
    class zTransform
    {
        
        private static Complex power(Complex input,int power)
        {
            double r = 0.3f;
            Complex Result;
            Result = new Complex(Math.Pow(r,-power)*Math.Cos(Math.PI * power / 2), Math.Pow(r, -power) * Math.Sin(Math.PI * power / 2));
            return Result;
        }
        public static Complex[] ztransform(Complex[] input)
        {
            Complex[] Result = new Complex[input.Length];
            for(int n=0;n<input.Length;n++)
            {
                Result[n] += input[n] * power(new Complex(1, 1), -n);
            }
            return Result;
        }
        

    }
}
