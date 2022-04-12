using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Center();
        }

        public void Center()
        {
            var squaresize = this.Height / 5;

            VertLine1.Height = squaresize*3;
            VertLine1.Left = (this.Width / 2) - (VertLine1.Width*2) - squaresize/2;
            VertLine1.Top = squaresize;
            VertLine2.Height = squaresize*3;
            VertLine2.Left = (this.Width /2) - (VertLine1.Width * 2) + squaresize/2;
            VertLine2.Top = squaresize;

            HorLine1.Width = squaresize*3;
            HorLine1.Left = (this.Width/2) - (VertLine1.Width * 2) - (HorLine1.Width / 2) ;
            HorLine1.Top = (this.Height/2) - squaresize/2;
            HorLine2.Width = squaresize * 3;
            HorLine2.Left = (this.Width / 2) - (VertLine1.Width * 2) - (HorLine1.Width/2);
            HorLine2.Top = (this.Height / 2) + squaresize/2;


            Square1.Width = squaresize - VertLine1.Width * 3;
            Square1.Height = squaresize - 14;
            Square1.Left = (this.Width / 2) - (squaresize+ squaresize/2);
            Square1.Top = squaresize + HorLine1.Height;

            Square2.Width = squaresize - VertLine1.Width * 3;
            Square2.Height = squaresize - 14;
            Square2.Left = (this.Width / 2) - (squaresize / 2);
            Square2.Top = squaresize + HorLine1.Height;

            Square3.Width = squaresize - VertLine1.Width * 3;
            Square3.Height = squaresize - 14;
            Square3.Left = (this.Width / 2) + (squaresize/2);
            Square3.Top = squaresize + HorLine1.Height;

            Square4.Width = squaresize - VertLine1.Width * 3;
            Square4.Height = squaresize - 14;
            Square4.Left = (this.Width / 2) - (squaresize / 2);
            Square4.Top = squaresize + HorLine1.Height;

            Square5.Width = squaresize - VertLine1.Width * 3;
            Square5.Height = squaresize - 14;
            Square5.Left = (this.Width / 2) - (squaresize / 2);
            Square5.Top = squaresize + HorLine1.Height;

            Square6.Width = squaresize - VertLine1.Width*3;
            Square6.Height = squaresize - 14;
            Square6.Left = (this.Width / 2) - (squaresize / 2);
            Square6.Top = squaresize + HorLine1.Height;

            Square7.Width = squaresize - VertLine1.Width * 3;
            Square7.Height = squaresize - 14;
            Square7.Left = (this.Width / 2) - (squaresize / 2);
            Square7.Top = squaresize + HorLine1.Height;

            Square8.Width = squaresize - VertLine1.Width * 3;
            Square8.Height = squaresize - 14;
            Square8.Left = (this.Width / 2) - (squaresize / 2);
            Square8.Top = squaresize + HorLine1.Height;

            Square9.Width = squaresize - VertLine1.Width * 3;
            Square9.Height = squaresize - 14;
            Square9.Left = (this.Width / 2) - (squaresize / 2);
            Square9.Top = squaresize + HorLine1.Height;


        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Center();
        }
    }

    
}
