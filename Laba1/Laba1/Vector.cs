using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows;
using System.Windows.Forms;
namespace Laba1
{
    class Vector
    {
        public double[] vector;
        public int Length = 3;
        public Vector()
        {
            vector = new double[Length];
        }
        public static void print(RichTextBox rich ,Vector vector)
        {
            foreach(var i in vector.vector)
            {
                rich.Text += i;
            }
        }
        public static Vector VectorrUmn(Vector a,Vector b)
        {
            var c = new Vector();
            for (int i = 0; i < 3; i++)
                c.vector[i] = a.vector[(i + 1) % 3] * b.vector[(i + 2) % 3] - a.vector[(i + 2) % 3] * b.vector[(i + 1) % 3];
            return c;
        }
        public static double ScalarUmn(Vector a,Vector b)
        {
            double result=default(double);
            for (int i = 0; i < 3; ++i)
                result += a.vector[i] * b.vector[i];
            return result;
        }

        

        public  double ModulOfVector()
        {
            double result = default(double);
            for(int i=0;i<3;i++)
            {
                result += Math.Pow(this.vector[i], 2);

            }
            return Math.Sqrt(result);
        }
        public static double cosinus(Vector vector1,Vector vector2)
        {
            double scalar = vector1.vector[0] * vector2.vector[1] + vector1.vector[0] * vector2.vector[1];
            double modulA = Math.Sqrt(Math.Pow(vector1.vector[0], 2) + Math.Pow(vector1.vector[1], 2));
            double modulB = Math.Sqrt(Math.Pow(vector2.vector[0], 2) + Math.Pow(vector2.vector[1], 2));
            double Cos = scalar / (modulA * modulB);
            return Cos;
        }

    }
}
