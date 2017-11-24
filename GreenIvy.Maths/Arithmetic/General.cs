using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenIvy.Maths.Arithmetic
{
    public class General
    {
        public General()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">a is first number</param>
        /// <param name="b">b is second number</param>
        /// <returns>sum of a and b</returns>
        public float Add(float a, float b)
        {
            return a + b;
        }

        public float Add(float a, float b, float c)
        {
            return a + b + c;
        }

        public float Add(float[] a)
        {
            float sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum;
        }
    }
}
