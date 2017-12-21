using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace PingPong
{

    public partial class Form1 : Form
    {
        public int speed_left = 4; //Top hızı
        public int speed_top = 4;
        public int point = 0; //Yakalanan puan
        public int level = 1;
        ArrayList bricks = new ArrayList();
        public int allBricks = 1;
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            //Cursor.Hide();
            //this.FormBorderStyle = FormBorderStyle.None;//Pencere silme
            //this.TopMost = true;//Her zaman üste çalışması
            this.Bounds = Screen.PrimaryScreen.Bounds;//tam ekran
            racket.Top = this.Bottom - (this.Bottom / 10); //Top'un ekrandaki pozisyonu

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            racket.Left = Cursor.Position.X - (racket.Width / 2); //Top'un merkezi noktası
            ball.Left += speed_left; //Top'un fiziği ve hareketi
            ball.Top += speed_top;
            label2.Text = speed_top.ToString();
            if (ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left >= racket.Left && ball.Right <= racket.Right)//Top'un dokunma özelliği
            {
                speed_top += 1;
                speed_left += 1;
                speed_top = -speed_top; //Yön değişimi
                point += 1;
            }

            if (ball.Left <= this.Left)
            {
                speed_left = -speed_left;
            }
            if (ball.Right >= this.Right)
            {
                speed_left = -speed_left;
            }
            if (ball.Top <= this.Top)
            {
                speed_top = -speed_top;
            }
            if (ball.Bottom >= this.Bottom)
            {
                timer1.Enabled = false; //Eğer top raketi geçerse Oyunu durdur
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)//ESC tuşu yakalama
            {
                this.Close();//Oyundan çıkış
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menu.Visible = false;
            createBrick();
            timer2.Enabled = true;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            brickTouch();
            refresh();
        }
        private void brickTouch()
        {
            Rectangle bricksPos = new Rectangle();//Tuğlaların pozisyonu
            Rectangle ballPos = new Rectangle();//Topun pozisyonu
            ballPos.Height = ball.Height;
            ballPos.Width = ball.Width;
            ballPos.X = ball.Left;
            ballPos.Y = ball.Top;

            for (int i = 0; i < bricks.Count; i++)
            {
                PictureBox brick = ((PictureBox)bricks[i]);
                brick.Visible = true;
                bricksPos.Height = brick.Height;
                bricksPos.Width = brick.Width;
                bricksPos.X = brick.Left;
                bricksPos.Y = brick.Top;
                if (bricksPos.IntersectsWith(ballPos))//Topun tuğla ile kesişimi
                {
                    bricks.RemoveAt(i);
                    allBricks--;
                    label3.Text = allBricks.ToString();
                    brick.Visible = false;
                    label4.Text = bricksPos.ToString();
                    speed_top = -speed_top; //Yön değişimi
                    point += 1;
                }
            }

        }
        public void createBrick()
        {
            for (int j = 0; j < level; j++)//Level mantığı
            {
                for (int i = 0; i < allBricks; i++)//Oluşan tuğla
                {
                    PictureBox brick = new PictureBox();
                    brick.ImageLocation = "1.png";
                    brick.Name = i.ToString();
                    brick.SizeMode = PictureBoxSizeMode.StretchImage;
                    brick.Size = new Size(70, 65);
                    brick.Location = new Point(20 + i * 120, j * 90 + 20);
                    brick.BackColor = Color.Transparent;
                    this.Controls.Add(brick);//Form'a eklenmesi
                    bricks.Add(brick);//Array halinde listelenmesi
                }
            }

        }
        public void refresh()
        {
            if (allBricks == 0)
            {
                timer1.Enabled = false;
                level++;
                allBricks = level * allBricks;
                createBrick();
                racket.Top = this.Bottom - (this.Bottom / 10);
                speed_left = 4; //Top hızı
                speed_top = 4;
                menu.Visible = true;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
