using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CatScratchFever
{
    public partial class FormView : Form
    {
        bool right, left;
        bool jump;
        int G = 30;
        int Force;

     /*  enum Position
        {
            Left, Right, Up, Down
        }
        */
        private int _x;
        private int _y;
       
       
        public FormView()
        {
            InitializeComponent();

            _x = 50;
            _y = 50;
            
         }

        private void FormView_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        { }


        private void FormView_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.FillRectangle(Brushes.BlueViolet, _x, _y, 100, 100);
            //e.Graphics.DrawImage(new Bitmap("yarn.png"), _x, _y, 32, 56);
        }


        
        private void FormView_KeyDown(object sender, KeyEventArgs e)
        {
            //Right
            if (e.KeyCode == Keys.Right)
            {
                pictureBox1.Left += 5;
            }
            if (pictureBox1.Right >= panel1.Width)
            {
                pictureBox1.Left = panel1.Width - pictureBox1.Width;
                }

            //Left
            if (e.KeyCode == Keys.Left)
            {
                pictureBox1.Left -= 5;
            }
           if (pictureBox1.Left <= 0)
                {
                    pictureBox1.Left = 0;
                }
           if (pictureBox1.Left <= 0)
           {
               pictureBox1.Left = 0;
            }

            //Down
            if (e.KeyCode == Keys.Down)
            {
                pictureBox1.Top += 5;
            }
           if (pictureBox1.Top + pictureBox1.Height >= panel1.Height)
           {
                 pictureBox1.Top = panel1.Height - pictureBox1.Height;
              }
            
            //Up
            if (e.KeyCode == Keys.Up)
            {
                pictureBox1.Top -= 5;
            }
            if (pictureBox1.Top <= 0)
            {
                pictureBox1.Top = 0;
            }
          



            //Diagonal\\

            //UpRight
            //Up
            if (e.KeyCode == (Keys.Up & Keys.Right))
            {
                ///left = true;
          
                pictureBox1.Left += 5;
                pictureBox1.Top -= 5;
            }
            
            //UpLeft
            if (e.KeyCode == (Keys.Up & Keys.Left))
            {
                ///left = true;
                
                pictureBox1.Left -= 5;
                pictureBox1.Top -= 5;
            }

            //DownRight
            if (e.KeyCode == (Keys.Down & Keys.Right))
            {
                //left = true;
                pictureBox1.Top += 5;
                pictureBox1.Left += 5;
            }

            //DownLeft
            if (e.KeyCode == (Keys.Down | Keys.Left))
            {
                //left = true;
                pictureBox1.Top += 5;
                pictureBox1.Left -= 5;
            }


            //Jump
            if (e.KeyCode == Keys.Space)
                {
                    //jump = true;
                    Force = G;
                    pictureBox1.Top -= Force;
                    Force -= 1;
                }
            
            
            //Quit
            if (e.KeyCode == Keys.Escape) { this.Close(); }

      
        }
       
        
        private void tmrMoving_Tick(object sender, EventArgs e)
        {
            /*if (right==true)
            {
                pictureBox1.Left += 5;
            }
            if (left == true)
            {
                pictureBox1.Left -= 5;
            }
            if (jump == true) { 
                //falling if players has jumped already
                pictureBox1.Top -= Force;
                Force -= 1;
            }
            if (pictureBox1.Top + pictureBox1.Height >= panel1.Height)
            {
                pictureBox1.Top = panel1.Height - pictureBox1.Height;
                jump = false;
            }
            else {
                pictureBox1.Top += 5; //Falling
            }*/

           /* if (_objPosition == Position.Right) {
                _x += 10;
            }
            if (_objPosition == Position.Left) {
                _x -= 10;
            }
            if (_objPosition == Position.Up)
            {
                _y -= 10;
            }
            if (_objPosition == Position.Down)
            {
                _y += 10;
            }*/
            _x += 10;
            Invalidate();
            
        }


     /*  //pictureBox1.Location = new Point(_xCat, _yCat);
        }
        */
       
        /*Change colour of yarn?
         * 
         * Color color = Color.Black; //Your desired colour

byte r = color.R; //For Red colour

Bitmap bmp = new Bitmap(this.BackgroundImage);
for (int x = 0; x < bmp.Width; x++)
{
    for (int y = 0; y < bmp.Height; y++)
    {
        Color gotColor = bmp.GetPixel(x, y);
        gotColor = Color.FromArgb(r, gotColor.G, gotColor.B);
        bmp.SetPixel(x, y, gotColor);
    }
}
         * */

        private void FormView_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


    }
}
