using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
   
    public partial class Form1 : Form
    {
        public int speed_left = 4; //Top hızı
        public int speed_top = 4;
        public int point = 0; //Yakalanan puan
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;//Pencere silme
            this.TopMost = true;//Her zaman üste çalışması
            this.Bounds = Screen.PrimaryScreen.Bounds;//tam ekran
            racket.Top = gamescreen.Bottom - (gamescreen.Bottom / 10); //Top'un ekrandaki pozisyonu
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width / 2); //Top'un merkezi noktası
            ball.Left += speed_left; //Top'un fiziği ve hareketi
            ball.Top += speed_top;
            if (ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left >= racket.Left && ball.Right <= racket.Right)//Top'un dokunma özelliği
            {
                speed_top += 1;
                speed_left += 1;
                speed_top = -speed_top; //Yön değişimi
                point += 1;
                currentPoint.Text = point.ToString();
            }
            if (ball.Left <= gamescreen.Left)
            {
                speed_left = -speed_left;
            }
            if (ball.Right >= gamescreen.Right)
            {
                speed_left = -speed_left;
            }
            if (ball.Top <= gamescreen.Top)
            {
                speed_top = -speed_top;
            }
            if (ball.Bottom >= gamescreen.Bottom)
            {
                timer1.Enabled = false; //Eğer raketi top geçerse Oyunu durdur
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)//ESC tuşu yakalama
            {
                this.Close();//Oyundan çıkış
            }
        }
    }
}
