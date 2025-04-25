namespace Flappy_Bird_Game
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ScoreText = new System.Windows.Forms.Label();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.EXIT = new System.Windows.Forms.Label();
            this.Countlbl = new System.Windows.Forms.Label();
            this.pipeTop2 = new System.Windows.Forms.PictureBox();
            this.pipeBottom2 = new System.Windows.Forms.PictureBox();
            this.Speed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom2)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.BackColor = System.Drawing.Color.White;
            this.ScoreText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ScoreText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ScoreText.Font = new System.Drawing.Font("OCR A Extended", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreText.ForeColor = System.Drawing.Color.Black;
            this.ScoreText.Location = new System.Drawing.Point(12, 689);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(226, 41);
            this.ScoreText.TabIndex = 0;
            this.ScoreText.Text = "Score : 0";
            // 
            // flappyBird
            // 
            this.flappyBird.BackColor = System.Drawing.Color.Transparent;
            this.flappyBird.Image = global::Flappy_Bird_Game.Properties.Resources.bird;
            this.flappyBird.Location = new System.Drawing.Point(12, 101);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(81, 61);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.flappyBird.TabIndex = 7;
            this.flappyBird.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.BackColor = System.Drawing.Color.Transparent;
            this.pipeTop.Image = global::Flappy_Bird_Game.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(437, -123);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(99, 285);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pipeTop.TabIndex = 6;
            this.pipeTop.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.BackColor = System.Drawing.Color.Transparent;
            this.pipeBottom.Image = global::Flappy_Bird_Game.Properties.Resources.pipe;
            this.pipeBottom.Location = new System.Drawing.Point(285, 402);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(98, 291);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pipeBottom.TabIndex = 8;
            this.pipeBottom.TabStop = false;
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.Transparent;
            this.ground.Image = global::Flappy_Bird_Game.Properties.Resources.ground1;
            this.ground.Location = new System.Drawing.Point(-18, 633);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(576, 129);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 9;
            this.ground.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EXIT
            // 
            this.EXIT.AutoSize = true;
            this.EXIT.Font = new System.Drawing.Font("OCR A Extended", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT.Location = new System.Drawing.Point(56, 248);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(0, 37);
            this.EXIT.TabIndex = 11;
            // 
            // Countlbl
            // 
            this.Countlbl.AutoSize = true;
            this.Countlbl.Font = new System.Drawing.Font("OCR A Extended", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Countlbl.Location = new System.Drawing.Point(238, 197);
            this.Countlbl.Name = "Countlbl";
            this.Countlbl.Size = new System.Drawing.Size(0, 99);
            this.Countlbl.TabIndex = 10;
            // 
            // pipeTop2
            // 
            this.pipeTop2.BackColor = System.Drawing.Color.Transparent;
            this.pipeTop2.Image = global::Flappy_Bird_Game.Properties.Resources.pipedown;
            this.pipeTop2.Location = new System.Drawing.Point(640, -59);
            this.pipeTop2.Name = "pipeTop2";
            this.pipeTop2.Size = new System.Drawing.Size(99, 285);
            this.pipeTop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pipeTop2.TabIndex = 12;
            this.pipeTop2.TabStop = false;
            // 
            // pipeBottom2
            // 
            this.pipeBottom2.BackColor = System.Drawing.Color.Transparent;
            this.pipeBottom2.Image = global::Flappy_Bird_Game.Properties.Resources.pipe;
            this.pipeBottom2.Location = new System.Drawing.Point(564, 471);
            this.pipeBottom2.Name = "pipeBottom2";
            this.pipeBottom2.Size = new System.Drawing.Size(98, 291);
            this.pipeBottom2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pipeBottom2.TabIndex = 13;
            this.pipeBottom2.TabStop = false;
            // 
            // Speed
            // 
            this.Speed.AutoSize = true;
            this.Speed.Font = new System.Drawing.Font("OCR A Extended", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Speed.Location = new System.Drawing.Point(56, 350);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(0, 37);
            this.Speed.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(545, 754);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.Countlbl);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.pipeTop2);
            this.Controls.Add(this.pipeBottom2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy-Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label EXIT;
        private System.Windows.Forms.Label Countlbl;
        private System.Windows.Forms.PictureBox pipeTop2;
        private System.Windows.Forms.PictureBox pipeBottom2;
        private System.Windows.Forms.Label Speed;
    }
}

