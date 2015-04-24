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
    public partial class VisForm : Form
    {
        double[,] AB,X;
        double A1, A2, B1, B2, C1, C2;
        double k, b;
        public VisForm()
        {
            InitializeComponent();
        }

        public void InitMatrix(double[,] A, double[] B)
        {
            int i,j;
            Out_vis.Image = new Bitmap(Out_vis.Width, Out_vis.Height);
            Graphics g = Graphics.FromImage(Out_vis.Image);
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            Pen p = Pens.Black;
            Brush br = new SolidBrush(Color.Black);
            Font f = new Font("Times New Roman", 10);
            float H = Out_vis.Height, W = Out_vis.Width;
            A1 = A[0, 0]; A2 = A[1, 0];
            B1 = A[0, 1]; B2 = A[1, 1];
            C1 = B[0]; C2 = B[1];
            double Scale = 10;
            
            //grid
            g.DrawLine(Pens.Black, 0, H / 2, W, H / 2);
            g.DrawLine(Pens.Black, W / 2, 0, W / 2, H);
            for (i = 0; i <= W; i++)
            {
                if ((W / 2 - i) % Scale == 0)
                    g.DrawLine(p,i,H/2+2,i,H/2-2);
            }
            for (i = 0; i <= H; i++)
            {
                if ((H / 2 - i) % Scale == 0)
                    g.DrawLine(p, W / 2 + 2, i, W / 2 - 2, i);
            }
            //line1
            if (B1 != 0)
            {
                k = -A1 / B1;
                b = C1 / B1;
                g.DrawLine(Pens.Red, 0, Convert.ToSingle(-(-W / 2 * k + b * Scale) + H / 2),
                    Convert.ToSingle(W), Convert.ToSingle(-(W / 2 * k + b * Scale) + H / 2));
            }
            else
            {
                g.DrawLine(Pens.Red, Convert.ToSingle(C1 / A1 * Scale + W / 2), 0, Convert.ToSingle(C1 / A1 * Scale + W / 2), H);
            }
            //line2
            if (B2 != 0)
            {
                k = -A2 / B2;
                b = C2 / B2;
                g.DrawLine(Pens.Blue, 0, Convert.ToSingle(-(-W / 2 * k + b * Scale) + H / 2),
                    Convert.ToSingle(W), Convert.ToSingle(-(W / 2 * k + b * Scale) + H / 2));
            }
            else
            {
                g.DrawLine(Pens.Blue, Convert.ToSingle(C2 / A2 * Scale + W / 2), 0, Convert.ToSingle(C2 / A2 * Scale + W / 2), H);
            }

            if ((A1==0 && A2==0 && C1/B1==C2/B2) || (B1==0 && B2==0 && C1/A1==C2/A2) || (B1!=0 && B2!=0 && A1/B1==A2/B2 && C1/B1==C2/B2))
                g.DrawString("Графики накладываеются", f, br, 15, 15);
            else if ((A1==0 && A2==0 && C1/B1!=C2/B2) || (B1==0 && B2==0 && C1/A1!=C2/A2) || (B1!=0 && B2!=0 && A1/B1==A2/B2 && C1/B1!=C2/B2))
                g.DrawString("Графики параллельны", f, br, 15, 15);
            else
            {
                double x, y;

                if (A1==0 && B2==0)
                {
                    x = C2 / A2;
                    y = C1 / B1;
                }
                else if (A2 == 0 && B1 == 0)
                {
                    x = C1 / A1;
                    y = C2 / B2;
                }
                else
                {
                    y = (C1 / A1 - C2 / A2) / (B1 / A1 - B2 / A2);
                    x = C1 / A1 - B1 * y / A1;
                }
                g.DrawString("Точка пересечения [" + Convert.ToString(x) + ";" + Convert.ToString(y) + "]", f, br, 15, 15);
                g.FillEllipse(Brushes.Yellow, 
                    Convert.ToSingle(W / 2 + x * Scale - 3), Convert.ToSingle(H / 2 - y * Scale - 3), 6, 6);
                g.DrawEllipse(Pens.Black,
                    Convert.ToSingle(W / 2 + x * Scale - 3), Convert.ToSingle(H / 2 - y * Scale - 3), 6, 6);
            }
        }
    }
}
/* свалка
    LooooooL
*/