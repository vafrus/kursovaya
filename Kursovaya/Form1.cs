using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya
{
    public partial class Form1 : Form
    {
        public int N = 2;
        public System.Windows.Forms.Control[,] In_matrix, In_matrix_L;
        
        private Graphics g;
        private VisForm vs;
        public Form1()
        {
            InitializeComponent();
        }
        public double[] solve(double[,] A, double[] X, int N)
        {
            
            double r = 0, R = 0;
            int i, j, k;

            //

            for (i = 0; i < N; i++)
            {
                k = i;
                r = A[i, i];
                for (j = i + 1; j < N; j++)
                {
                    if (A[j, i] > r)
                    {
                        k = j;
                        r = A[j, i];
                    }
                }

                if (r == 0)
                {
                    break;
                }
                //
                if (k != i)
                {
                    R = X[k];
                    X[k] = X[i];
                    X[i] = R;
                    for (j = 0; j < N; j++)
                    {
                        R = A[k, j];
                        A[k, j] = A[i, j];
                        A[i, j] = R;
                    }
                }
                //
                r = A[i, i];
                X[i] = X[i] / r;
                for (j = i; j < N; j++)
                    A[i, j] = A[i, j] / r;
                //
                for (k = i + 1; k < N; k++)
                {
                    r = A[k, i];
                    X[k] = X[k] - r * X[i];
                    for (j = i; j < N; j++)
                        A[k, j] = A[k, j] - r * A[i, j];
                }
            }
            //
            if (r != 0)
            {
                for (i = N - 2; i >= 0; i--)
                    for (j = i + 1; j < N; j++)
                        X[i] = X[i] - A[i, j] * X[j];
                return X;
            }
            else
            {
                throw new System.Exception();
            }
        }
        private void print_false()
        {
            Out_pic.Image = new Bitmap(Out_pic.Width, Out_pic.Height);
            Brush b = Brushes.Black;
            
            try
            {
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.AssumeLinear;
            }
            catch { }
            
            g = Graphics.FromImage(Out_pic.Image);
            g.DrawString("Матрица вырождена", new Font("Arial",10,FontStyle.Regular), b, 15, 15);
            //g.DrawString("Матрица вырождена", new Font("Consolas", 10), b, new PointF(10, 15));v
        }
        private void print_X(double[] X)
        {
            Out_pic.Image = new Bitmap(Out_pic.Width, Out_pic.Height);
            g = Graphics.FromImage(Out_pic.Image);
            int H = Out_pic.Height, W = Out_pic.Width;
            
            int i;
            for (i = 0; i < N; i++)
            {
                g.DrawString("x[" + Convert.ToString(i) + "]=" + Convert.ToString(X[i]), new Font("Times New Roman", 10), Brushes.Black, new PointF(10, i * 15));
            }
        }
        private void Init_Input_Field(object sender, EventArgs e)
        {
            int i, j;
            if (In_matrix!=null)
            for (j = 0; j < N; j++)
                for (i = 0; i < N + 1; i++)
                {
                    In_matrix[i, j].Dispose();
                    In_matrix_L[i, j].Dispose();
                }

            N=Convert.ToInt16(Rang.Text);
            if (N > 10) N = 10;

            In_matrix = new System.Windows.Forms.Control[N + 1, N];
            In_matrix_L = new System.Windows.Forms.Control[N + 1, N];

            for (j = 0; j < N; j++)
                for (i = 0; i < N+1; i++)
                {
                    In_matrix[i, j] = new System.Windows.Forms.TextBox();
                    In_area.Controls.Add(In_matrix[i, j]);
                    In_matrix[i, j].Location = new Point(i * 65 + 50, j * 20 + 15);
                    In_matrix[i, j].Size = new Size(25, 20);
                    In_matrix[i, j].Text = "0";

                    In_matrix_L[i, j] = new System.Windows.Forms.Label();
                    In_area.Controls.Add(In_matrix_L[i, j]);
                    In_matrix_L[i, j].Location = new Point(i * 65 + 15, j * 20 + 17);
                    In_matrix_L[i, j].Size = new Size(40, 20);
                    if (i != N) In_matrix_L[i, j].Text = "a[" + Convert.ToString(i + 1) + "," + Convert.ToString(j + 1) + "]=";
                    else In_matrix_L[i, j].Text = "b[" + Convert.ToString(j + 1) + "]=";

                }
        }

        private void Solve_SLAU(object sender, EventArgs e)
        {
            double[,] A = new double[N, N];
            double[] B = new double[N];
            double[] X;
            int i, j;

            try
            {
                for (j = 0; j < N; j++)
                    for (i = 0; i < N; i++)
                        A[j, i] = Convert.ToDouble(In_matrix[i, j].Text);
                for (i = 0; i < N; i++)
                    B[i] = Convert.ToDouble(In_matrix[N, i].Text);
                X = solve(A, B, N);
                print_X(X);
            }
            catch 
            {
                print_false();
            }
        }

        private void btn_vis(object sender, EventArgs e)
        {
            if (N == 2)
            {
                int i, j;
                double[,] A = new double[N, N];
                double[] B = new double[N];
                for (i = 0; i < N; i++)
                    for (j = 0; j < N; j++)
                        A[j, i] = Convert.ToDouble(In_matrix[j, i].Text);
                for (i = 0; i < N; i++)
                    B[i] = Convert.ToDouble(In_matrix[N, i].Text);
                vs = new VisForm();
                vs.InitMatrix(A, B);
                vs.Show();
            }
        }
    }
}
