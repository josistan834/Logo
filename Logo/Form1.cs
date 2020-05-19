using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //starting up the form
            InitializeComponent();
        }

        //function for painting using graphics
        private void formPaint(object sender, PaintEventArgs e)
        {
            //creating a graphics object
            Graphics g = this.CreateGraphics();

            //setting background color
            g.Clear(Color.LimeGreen);

            //setting up the diffrent bushes used for drawing shops/text
            Pen drawPen = new Pen(Color.DarkRed, 10);
            SolidBrush drawBrush = new SolidBrush(Color.White);

            //setting font to the label1 font (for quick testing purposes) 
            Font drawFont = label1.Font;

            //setting transform and rotation for the string (for number 7)
            g.TranslateTransform(100, 70);
            g.RotateTransform(-10);
            //writing string
            g.DrawString("7", drawFont, drawBrush, 0, 0);
            //resetting transform to 0,0
            g.ResetTransform();

            //changeing brush color and drawing a circle
            drawBrush.Color = Color.Red;
            g.FillEllipse(drawBrush, 220, 120, 80, 80);

            //changing brush color and drawing u and p with diffrent transfrom and rotations
            drawBrush.Color = Color.White;
            drawFont = label2.Font;
            g.TranslateTransform(230, 70);
            g.RotateTransform(-10);
            g.DrawString("u", drawFont, drawBrush, 0, 0);
            g.ResetTransform();
            g.TranslateTransform(285, 50);
            g.RotateTransform(-10);
            g.DrawString("p", drawFont, drawBrush, 0, 0);
        }
    }
}
