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
        string x = "C:/Users/Aluno/Downloads/a/x.png";
        string o = @"C:\Users\Aluno\Downloads\a\image.png";
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
            VertLine1.Width = (this.Width/this.Height)*10;
            VertLine1.Left = (this.Width / 2) - (VertLine1.Width*2) - squaresize/2;
            VertLine1.Top = squaresize;

            VertLine2.Height = squaresize*3;
            VertLine2.Width = (this.Width / this.Height) * 10;
            VertLine2.Left = (this.Width /2) - (VertLine1.Width * 2) + squaresize/2;
            VertLine2.Top = squaresize;

            HorLine1.Width = squaresize*3;
            HorLine1.Height= (this.Width / this.Height) * 10;
            HorLine1.Left = (this.Width/2) - (VertLine1.Width * 2) - (HorLine1.Width / 2) ;
            HorLine1.Top = (this.Height/2) - squaresize/2;

            HorLine2.Width = squaresize * 3;
            HorLine2.Height = (this.Width / this.Height) * 10;
            HorLine2.Left = (this.Width / 2) - (VertLine1.Width * 2) - (HorLine1.Width/2);
            HorLine2.Top = (this.Height / 2) + squaresize/2;

            PictureBox[,] SquareArray = { { Square1, Square2, Square3 },
                                          { Square4, Square5, Square6 },
                                          { Square7, Square8, Square9 } };

            for(int i = 0; i<3; i++)
            {
                for (int j = 0; j<3; j++)
                {
                    SquareArray[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                    SquareArray[i,j].Width = squaresize - VertLine1.Width * 5;
                    SquareArray[i,j].Height = squaresize - VertLine1.Width * 5;
                    
                        SquareArray[i,0].Left = (this.Width / 2) - (squaresize + squaresize / 2) + VertLine1.Width;

                        SquareArray[i,1].Left = (this.Width / 2) - (squaresize / 2) + VertLine1.Width;
                
                        SquareArray[i,2].Left = (this.Width / 2) + (squaresize / 2) + VertLine1.Width;
                  
                        SquareArray[0,j].Top = squaresize + HorLine1.Height*3;
                  
                        SquareArray[1,j].Top = 2 * squaresize + 2 * HorLine1.Height + HorLine1.Height;

                        SquareArray[2,j].Top = 3 * squaresize + 2 * HorLine1.Height + HorLine1.Height ;
                    
                }
                
            }


        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Center();
        }

        private void Square1_Click(object sender, EventArgs e)
        {
            Square1.Load(x);
        }

        private void Square3_Click(object sender, EventArgs e)
        {
            Square3.Load(o);
        }

        private void Square2_Click(object sender, EventArgs e)
        {
            Square2.Load(x);
        }

        private void Square4_Click(object sender, EventArgs e)
        {
            Square4.Load(x);
        }

        private void Square5_Click(object sender, EventArgs e)
        {
            Square5.Load();
        }

        private void Square6_Click(object sender, EventArgs e)
        {
            Square6.Load();
        }

        private void Square7_Click(object sender, EventArgs e)
        {
            Square7.Load();
        }

        private void Square8_Click(object sender, EventArgs e)
        {
            Square8.Load();
        }

        private void Square9_Click(object sender, EventArgs e)
        {
            Square9.Load();
        }
    }

    
}
