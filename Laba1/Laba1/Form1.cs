using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1
{
    public partial class Form1 : Form
    {
        Matrix A = new Matrix(3, 3);
        Matrix B = new Matrix(3, 3);
        Matrix V1 = new Matrix(3, 1);
        Matrix V2 = new Matrix(3, 1);

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

            richTextBox1.Clear();
               

            Matrix.printMatrix(richTextBox1, A + B);
            Matrix.printMatrix(richTextBox1, A * B);
            Matrix.printMatrix(richTextBox1, A * V1);
            Matrix.printMatrix(richTextBox1, Matrix.RotationArray(V1) * A * V2);



           
           

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Vector v1 = new Vector();
            Vector v2 = new Vector();

            richTextBox1.Text += Vector.ScalarUmn(v1, v2);

        }
    }
}
