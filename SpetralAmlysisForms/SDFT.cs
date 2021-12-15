using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SpetralAmlysisForms
{
    public class SDFT//Straight Discrete Fourier Transform
    {

        public static double[] sdft(double[] x)
        {
            int arraySize = x.Length;
            Complex[] C = new Complex[arraySize];
            Complex[] sdftResult = new Complex[arraySize];
            double[] magnitude = new double[arraySize];
            for (int n = 0; n < arraySize; n++)
            {
                for (int k = 0; k < arraySize; k++)
                {
                    C[n] = new Complex(C[n].Real+x[k] * Math.Cos(2 * Math.PI * k * n / arraySize), C[n].Imaginary-x[k] * Math.Sin(2 * Math.PI * k * n / arraySize));
                    
                    //sdftResult[n] = new Complex(C[n].Real * Math.Cos(2 * Math.PI * k * n / arraySize), -C[n].Imaginary * Math.Sin(2 * Math.PI * k * n / arraySize));

                }
                //sdftResult[n] = sdftResult[n] / arraySize;
            }
            for (int n = 0; n < arraySize; n++)
                magnitude[n] = C[n].Magnitude;







                return magnitude;
        }



    }
}
