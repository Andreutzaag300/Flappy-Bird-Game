namespace Flappy_Bird_Game
{
    partial class Dificulty
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Select = new System.Windows.Forms.Label();
            this.ground = new System.Windows.Forms.PictureBox();
            this.Return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("OCR A Extended", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(157, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 108);
            this.button1.TabIndex = 0;
            this.button1.Text = "EASY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("OCR A Extended", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(157, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 108);
            this.button2.TabIndex = 1;
            this.button2.Text = "MEDIUM";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("OCR A Extended", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(157, 500);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 108);
            this.button3.TabIndex = 2;
            this.button3.Text = "HARD";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Select
            // 
            this.Select.AutoSize = true;
            this.Select.BackColor = System.Drawing.Color.Transparent;
            this.Select.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select.Location = new System.Drawing.Point(26, 54);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(495, 35);
            this.Select.TabIndex = 3;
            this.Select.Text = "Selecteaza dificultatea:";
            // 
            // ground
            // 
            this.ground.Image = global::Flappy_Bird_Game.Properties.Resources.ground1;
            this.ground.Location = new System.Drawing.Point(-24, 651);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(576, 129);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 11;
            this.ground.TabStop = false;
            // 
            // Return
            // 
            this.Return.AutoSize = true;
            this.Return.BackColor = System.Drawing.Color.Transparent;
            this.Return.BackgroundImage = global::Flappy_Bird_Game.Properties.Resources.Arrow2_removebg_preview;
            this.Return.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Return.Location = new System.Drawing.Point(422, 500);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(99, 104);
            this.Return.TabIndex = 12;
            this.Return.UseVisualStyleBackColor = false;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Dificulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Flappy_Bird_Game.Properties.Resources._1_YGSOeH6mCwMZIWxXyYP7uQ1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(545, 754);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "Dificulty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dificulty";
            this.Load += new System.EventHandler(this.Dificulty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Select;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Button Return;
    }
}