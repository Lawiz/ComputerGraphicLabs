using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1
{
    class Matrix
    {
        
        public double[,] matr { get; set; }

        public Matrix(int coll, int lines)
        {
           
            Random random = new Random();
            matr = new double[coll,lines];

            for (int i = 0; i < coll; i++)
            {
                for (int k = 0; k < lines; k++)
                {
                    matr[i, k] = random.Next(10);
                }
            }

        }
        public Matrix(int coll, int lines, bool y)
        {  
            matr = new double[coll,lines];

            if (y == true)
            {
                for (int i = 0; i < coll; i++)
                {
                    for (int k = 0; k < lines; k++)
                    {
                        matr[i, k] = 0;
                    }
                }
            }
            
        }
        
        public static Matrix RotationArray(Matrix matrix) //Метод транспонирования матрицы
        {
            int line = matrix.matr.GetLength(1);
            int col = matrix.matr.GetLength(0);
            int i, j;
            Matrix tmpArray = new Matrix(line, col);

            for (i = 0; i < line; i++)
            {
                for (j = 0;j < col; j++)
                {
                    tmpArray.matr[i, j] = matrix.matr[j, i];
                }
            }

            return tmpArray;
        }
        public static void printMatrix(RichTextBox richTextBox,Matrix matrix)
        {
            for (int i = 0; i <matrix.matr.GetLength(0); i++)
            {
                for (int k = 0; k <matrix.matr.GetLength(1); k++)
                {
                    richTextBox.Text += matrix.matr[i, k]+" ";
                }

                richTextBox.AppendText("\n\r");
            }

            richTextBox.AppendText("----------------------------------------------------\n\r");
        }
        public static Matrix umnch(Matrix a, int ch)
        {
            int line = a.matr.GetLength(1);
            int col = a.matr.GetLength(0);

            Matrix resMass = new Matrix(line,col);
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j <col; j++)
                {
                    resMass.matr[i, j] = a.matr[i, j] * ch;
                }
            }
           
            return resMass;
        }
        public static Matrix umn(Matrix A, Matrix B)
        {

            if (A.matr.GetLength(1)!= B.matr.GetLength(0))
            {
                throw new Exception();
            }
            Matrix C = new Matrix(A.matr.GetLength(0), B.matr.GetLength(1),true); 
            for (int i = 0; i < A.matr.GetLength(0); ++i)
            {
                for (int j = 0; j < B.matr.GetLength(1); ++j)
                {
                    C.matr[i, j] = 0;
                    for (int k = 0; k < A.matr.GetLength(0); ++k)
                    { 
                        C.matr[i, j] += A.matr[i, k] * B.matr[k, j]; 
                    }
                }
            }
            return C;
        }
        public static Matrix razn(Matrix a, Matrix b)
        {
            Matrix resMass = new Matrix(a.matr.GetLength(0),a.matr.GetLength(1));
            for (int i = 0; i < a.matr.GetLength(0); i++)
            {
                for (int j = 0; j < b.matr.GetLength(1); j++)
                {
                    resMass.matr[i, j] = a.matr[i, j] - b.matr[i, j];
                }
            }
            return resMass;
        }
        public static Matrix Sum(Matrix a, Matrix b)
        {
            Matrix resMass = new Matrix(a.matr.GetLength(0),b.matr.GetLength(1));
            for (int i = 0; i < a.matr.GetLength(0); i++)
            {
                for (int j = 0; j < b.matr.GetLength(1); j++)
                {
                    resMass.matr[i, j] = a.matr[i, j] + b.matr[i, j];
                }
            }
            return resMass;
        }
        public static implicit operator Matrix(Vector vector)
        {
            Matrix matrix = new Matrix(vector.Length, 1);

            for(int i=0;i<vector.Length;i++)
            {
                matrix.matr[i, 0] = vector.vector[i];

            }
            return matrix;
           
        }
        public static Matrix operator +(Matrix a, Matrix b)
        {
            return Matrix.Sum(a, b);
        }
        public static Matrix operator -(Matrix a, Matrix b)
        {
            return Matrix.razn(a, b);
        }

        public static Matrix operator *(Matrix a, int b)
        {
            return Matrix.umnch(a, b);
        }
        public static Matrix operator *(Matrix a,Matrix b)
        {
            return Matrix.umn(a, b);
        }
        
       
    }
}
