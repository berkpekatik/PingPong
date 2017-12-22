namespace PingPong
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.currentPoint = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.racket = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Label();
            this.restart = new System.Windows.Forms.Label();
            this.nextLevel = new System.Windows.Forms.Label();
            this.newGame = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // currentPoint
            // 
            this.currentPoint.AutoSize = true;
            this.currentPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPoint.Location = new System.Drawing.Point(97, 11);
            this.currentPoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentPoint.Name = "currentPoint";
            this.currentPoint.Size = new System.Drawing.Size(24, 25);
            this.currentPoint.TabIndex = 11;
            this.currentPoint.Text = "0";
            this.currentPoint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Point;";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Red;
            this.ball.Location = new System.Drawing.Point(625, 350);
            this.ball.Margin = new System.Windows.Forms.Padding(4);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(33, 31);
            this.ball.TabIndex = 9;
            this.ball.TabStop = false;
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.racket.Location = new System.Drawing.Point(584, 593);
            this.racket.Margin = new System.Windows.Forms.Padding(4);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(267, 25);
            this.racket.TabIndex = 8;
            this.racket.TabStop = false;
            // 
            // menu
            // 
            this.menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menu.Controls.Add(this.exit);
            this.menu.Controls.Add(this.restart);
            this.menu.Controls.Add(this.nextLevel);
            this.menu.Controls.Add(this.newGame);
            this.menu.Location = new System.Drawing.Point(757, 245);
            this.menu.Margin = new System.Windows.Forms.Padding(4);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(439, 284);
            this.menu.TabIndex = 15;
            this.menu.Visible = false;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exit.Location = new System.Drawing.Point(191, 220);
            this.exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(62, 35);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // restart
            // 
            this.restart.AutoSize = true;
            this.restart.Enabled = false;
            this.restart.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.restart.Location = new System.Drawing.Point(170, 86);
            this.restart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(103, 35);
            this.restart.TabIndex = 2;
            this.restart.Text = "Restart";
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // nextLevel
            // 
            this.nextLevel.AutoSize = true;
            this.nextLevel.Enabled = false;
            this.nextLevel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nextLevel.Location = new System.Drawing.Point(151, 168);
            this.nextLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nextLevel.Name = "nextLevel";
            this.nextLevel.Size = new System.Drawing.Size(145, 35);
            this.nextLevel.TabIndex = 1;
            this.nextLevel.Text = "Next Level";
            this.nextLevel.Click += new System.EventHandler(this.nextLevel_Click);
            // 
            // newGame
            // 
            this.newGame.AutoSize = true;
            this.newGame.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newGame.Location = new System.Drawing.Point(151, 42);
            this.newGame.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(144, 35);
            this.newGame.TabIndex = 0;
            this.newGame.Text = "New Game";
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1804, 650);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.currentPoint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.racket);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label currentPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Label nextLevel;
        private System.Windows.Forms.Label newGame;
        private System.Windows.Forms.Label restart;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

