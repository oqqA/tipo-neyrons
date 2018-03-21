using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp26.neyrons
{
   

   public partial class Form1 : Form
   {
      public class Dot
      {
         public double x { get; set; }
         public double y { get; set; }
         public double dx { get; set; }
         public double dy { get; set; }

         public Dot(int X, int Y, double F)
         {
            x = X;
            y = Y;

            dx = Math.Sin(F);
            dy = Math.Cos(F);
         }
      }

      static int countDot = 100;
      static Dot[] h;
      static int pred = 60; // предел растояния для линий, начиная с которого они будут загаратся
      
      static double shift = 1; // шаг точки относительно предыдущего положения
      static int radKub = 2; // радиус кубиков

      static int intervalTimer = 20;
      static Bitmap bmp;
      static Graphics g;

      public void InitializeDots()
      {
         h = new Dot[countDot];
         Random r = new Random();
         for (int i = 0; i < h.Length; i++)
            h[i] = new Dot(r.Next(pictureBox1.Width), r.Next(pictureBox1.Height), r.Next(360) * Math.PI / 180);
      }

      public void InitializeGrapics()
      {
         bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
         g = Graphics.FromImage(bmp);
         g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
      }

      public Form1()
      {
         InitializeComponent();

         InitializeGrapics();
         InitializeDots();

         timer1.Interval = intervalTimer;
         timer1.Start();

         tablo();
      }

      // Algoritms

      public void Draw()
      {
         g.Clear(Color.White);

         for (int i = 0; i < h.Length; i++)
         {
            ref var v = ref h[i];

            g.FillRectangle(new SolidBrush(Color.FromArgb(50, 1, 1, 1)), (int)v.x - radKub, (int)v.y - radKub, 2*radKub, 2*radKub);
            for (int j = i + 1; j < h.Length; j++)
            {
               ref var f = ref h[j];
               int dist = (int)( Math.Sqrt( Math.Pow(v.x - f.x, 2) + Math.Pow(v.y - f.y, 2) ) );
               int a = pred - dist;
               if (a > 3)
               {
                  a = a > 255 ? 255 : a;
                  Pen p = new Pen(new SolidBrush(Color.FromArgb(a, 1, 1, 1)));
                  p.Width = 2;
                  g.DrawLine(p, (int)v.x, (int)v.y, (int)f.x, (int)f.y);
               }
   
            }

            // движение
            v.x += v.dx * shift;
            v.y += v.dy * shift;

            // замкнуть поле
            v.x = (v.x > pictureBox1.Width+pred) ? -pred : (v.x < -pred) ? pictureBox1.Width+pred : v.x;
            v.y = (v.y > pictureBox1.Height+pred) ? -pred : (v.y < -pred) ? pictureBox1.Height+pred : v.y;
         }

         pictureBox1.Image = bmp;
      }

      private void tablo()
      {
         this.Text = trackBar1.Value + " " + trackBar2.Value + " " + trackBar3.Value;
      }

      // Events

      private void timer1_Tick(object sender, EventArgs e)
      {
         Draw();
      }

      private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
      {
         h[1].x = e.X;
         h[1].y = e.Y;
      }

      private void Form1_SizeChanged(object sender, EventArgs e)
      {
         InitializeGrapics();
      }

      private void trackBar1_Scroll(object sender, EventArgs e)
      {
         countDot = trackBar1.Value;
         InitializeDots();
         tablo();
      }

      private void trackBar2_Scroll(object sender, EventArgs e)
      {
         pred = trackBar2.Value;
         tablo();
      }

      private void trackBar3_Scroll(object sender, EventArgs e)
      {
         shift = trackBar3.Value / 100f;
      }
   }
}
