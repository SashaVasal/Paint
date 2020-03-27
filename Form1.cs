using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Graph
{
    public partial class Form1 : Form
    {
        int count = 1;
        
        Bitmap bit;
        float x1 = 0, y1 = 0;
        int q = 1;
        Pen pen = new Pen(Color.Black);
        public Form1()
        {
            bit = new Bitmap(1000, 1000);
            x1 = y1 = 0;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if(count == 1)
            {
                
                Graphics g;
                g = Graphics.FromImage(bit);
                if (e.Button == MouseButtons.Left)
                {
                    g.DrawLine(pen, x1, y1, e.X, e.Y);
                    canvas.Image = bit;
                }
                x1 = e.X;
                y1 = e.Y;
            }
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        public void Canvas_Mouse_Move(object sender, MouseEventArgs e)
        {
            
        }
        public void PenClick(object sender, EventArgs e)
        {
            count = 1;
            q = 1;
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (count == 2)
            {
                if(q == -1)
                {
                    
                    Graphics g;
                    g = Graphics.FromImage(bit);

                    if (e.Button == MouseButtons.Left)
                    {

                        g.DrawLine(pen, x1, y1, e.X, e.Y);
                        canvas.Image = bit;
                        x1 = e.X;
                        y1 = e.Y;
                    }
                }
                else
                {
                    x1 = e.X;
                    y1 = e.Y;
                    q *= (-1);
                }
            }
            

            if (count == 3)
            {
                if (q == -1)
                {                  
                    Graphics g;
                    g = Graphics.FromImage(bit);
                    if (e.Button == MouseButtons.Left)
                    {
                        g.DrawLine(pen, x1, y1, e.X, e.Y);
                        canvas.Image = bit;
                    }
                    q *= (-1);
                }
                else
                {
                    x1 = e.X;
                    y1 = e.Y;
                    q *= (-1);
                }
            }            
        }
     
        public void BrokenClick(object sender, EventArgs e)
        {
            count = 2;
            q = 1;
        }

        private void ChangeColor_Click(object sender, EventArgs e)
        {
            
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                 return;
  
            pen = new Pen(colorDialog1.Color);

        }

        private void LineClick(object sender, EventArgs e)
        {
            count = 3;
            q = 1;
        }
    }
}
