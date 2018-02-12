using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace Laba1
{
    class Helper
    {
        public Matrix matrix1 = new Matrix();
        public Matrix matrix2 = new Matrix();
        public Matrix matrixResult=new Matrix();
        
        public Matrix GetMatrix(RichTextBox richTextBox)
        {
            string[] matrix = richTextBox.Text.Split('\n');
            Matrix matrixResult = new Matrix();
            for(int i=0;i<matrix.Length;i++)
            {
                int[] buf = new int[matrix[i].Length];

                for (int j=0;j<matrix[i].Length;j++)
                {
                    int counter = 0;
                    while(matrix[i][j]!=' ')
                    {
                        buf[counter] = int.Parse(matrix[i][j].ToString());
                    }
                }
                matrixResult=
            }

            return 
        }




    }
}
