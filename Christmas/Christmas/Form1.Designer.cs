namespace Christmas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Obst4 = new System.Windows.Forms.PictureBox();
            this.Santa = new System.Windows.Forms.PictureBox();
            this.Obst2 = new System.Windows.Forms.PictureBox();
            this.Obst1 = new System.Windows.Forms.PictureBox();
            this.Obst3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ground = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Obst4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Santa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obst2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obst1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obst3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // Obst4
            // 
            this.Obst4.Image = ((System.Drawing.Image)(resources.GetObject("Obst4.Image")));
            this.Obst4.Location = new System.Drawing.Point(142, 0);
            this.Obst4.Name = "Obst4";
            this.Obst4.Size = new System.Drawing.Size(104, 93);
            this.Obst4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Obst4.TabIndex = 0;
            this.Obst4.TabStop = false;
            // 
            // Santa
            // 
            this.Santa.Image = ((System.Drawing.Image)(resources.GetObject("Santa.Image")));
            this.Santa.Location = new System.Drawing.Point(70, 187);
            this.Santa.Name = "Santa";
            this.Santa.Size = new System.Drawing.Size(126, 64);
            this.Santa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Santa.TabIndex = 1;
            this.Santa.TabStop = false;
            this.Santa.Click += new System.EventHandler(this.Santa_Click);
            // 
            // Obst2
            // 
            this.Obst2.Image = ((System.Drawing.Image)(resources.GetObject("Obst2.Image")));
            this.Obst2.Location = new System.Drawing.Point(628, 248);
            this.Obst2.Name = "Obst2";
            this.Obst2.Size = new System.Drawing.Size(108, 107);
            this.Obst2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Obst2.TabIndex = 2;
            this.Obst2.TabStop = false;
            // 
            // Obst1
            // 
            this.Obst1.Image = ((System.Drawing.Image)(resources.GetObject("Obst1.Image")));
            this.Obst1.Location = new System.Drawing.Point(331, 248);
            this.Obst1.Name = "Obst1";
            this.Obst1.Size = new System.Drawing.Size(144, 140);
            this.Obst1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Obst1.TabIndex = 3;
            this.Obst1.TabStop = false;
            this.Obst1.Click += new System.EventHandler(this.Obst1_Click);
            // 
            // Obst3
            // 
            this.Obst3.Image = ((System.Drawing.Image)(resources.GetObject("Obst3.Image")));
            this.Obst3.Location = new System.Drawing.Point(569, 0);
            this.Obst3.Name = "Obst3";
            this.Obst3.Size = new System.Drawing.Size(103, 93);
            this.Obst3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Obst3.TabIndex = 4;
            this.Obst3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer_tick1);
            // 
            // ground
            // 
            this.ground.Location = new System.Drawing.Point(0, 394);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(801, 56);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 5;
            this.ground.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 415);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = " PLAY AGAIN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.Obst3);
            this.Controls.Add(this.Obst1);
            this.Controls.Add(this.Obst2);
            this.Controls.Add(this.Santa);
            this.Controls.Add(this.Obst4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Obst4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Santa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obst2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obst1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obst3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Obst4;
        private System.Windows.Forms.PictureBox Santa;
        private System.Windows.Forms.PictureBox Obst2;
        private System.Windows.Forms.PictureBox Obst1;
        private System.Windows.Forms.PictureBox Obst3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Button button1;
    }
}




       

