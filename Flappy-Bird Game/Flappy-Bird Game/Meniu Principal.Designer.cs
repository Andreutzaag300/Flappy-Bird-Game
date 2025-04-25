namespace Flappy_Bird_Game
{
    partial class Meniu_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meniu_Principal));
            this.ground = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.Dificultate = new System.Windows.Forms.Button();
            this.Mutebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.Image = global::Flappy_Bird_Game.Properties.Resources.ground1;
            this.ground.Location = new System.Drawing.Point(-19, 635);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(576, 129);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 10;
            this.ground.TabStop = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("OCR A Extended", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(31, 35);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(468, 66);
            this.Title.TabIndex = 12;
            this.Title.Text = "Flappy Bird";
            // 
            // Exitbtn
            // 
            this.Exitbtn.Font = new System.Drawing.Font("OCR A Extended", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbtn.Location = new System.Drawing.Point(170, 386);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(227, 76);
            this.Exitbtn.TabIndex = 19;
            this.Exitbtn.Text = "EXIT";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // Dificultate
            // 
            this.Dificultate.Font = new System.Drawing.Font("OCR A Extended", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dificultate.Location = new System.Drawing.Point(170, 238);
            this.Dificultate.Name = "Dificultate";
            this.Dificultate.Size = new System.Drawing.Size(227, 76);
            this.Dificultate.TabIndex = 20;
            this.Dificultate.Text = "Start";
            this.Dificultate.UseVisualStyleBackColor = true;
            this.Dificultate.Click += new System.EventHandler(this.Dificultate_Click);
            // 
            // Mutebtn
            // 
            this.Mutebtn.BackColor = System.Drawing.Color.Transparent;
            this.Mutebtn.Location = new System.Drawing.Point(417, 667);
            this.Mutebtn.Name = "Mutebtn";
            this.Mutebtn.Size = new System.Drawing.Size(91, 75);
            this.Mutebtn.TabIndex = 21;
            this.Mutebtn.UseVisualStyleBackColor = false;
            this.Mutebtn.Click += new System.EventHandler(this.Mutebtn_Click);
            // 
            // Meniu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Flappy_Bird_Game.Properties.Resources._1_YGSOeH6mCwMZIWxXyYP7uQ1;
            this.ClientSize = new System.Drawing.Size(545, 754);
            this.Controls.Add(this.Mutebtn);
            this.Controls.Add(this.Dificultate);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.ground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Meniu_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meniu_Principal";
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Button Dificultate;
        private System.Windows.Forms.Button Mutebtn;
    }
}