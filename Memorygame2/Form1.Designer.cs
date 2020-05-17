namespace Memorygame2
{
    partial class GameWindow
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
			this.label1 = new System.Windows.Forms.Label();
			this.ScoreCounter = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.CardHolder = new System.Windows.Forms.Panel();
			this.DuppictureBox9 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.DuppictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.DuppictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.DuppictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.DuppictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.DuppictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.DuppictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.DuppictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.DuppictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.timer3 = new System.Windows.Forms.Timer(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.CardHolder.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DuppictureBox9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DuppictureBox8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DuppictureBox7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DuppictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DuppictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DuppictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DuppictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DuppictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DuppictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Script MT Bold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(1082, 137);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 33);
			this.label1.TabIndex = 1;
			this.label1.Text = "Score :";
			// 
			// ScoreCounter
			// 
			this.ScoreCounter.AutoSize = true;
			this.ScoreCounter.Font = new System.Drawing.Font("Script MT Bold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ScoreCounter.Location = new System.Drawing.Point(1191, 137);
			this.ScoreCounter.Name = "ScoreCounter";
			this.ScoreCounter.Size = new System.Drawing.Size(29, 33);
			this.ScoreCounter.TabIndex = 2;
			this.ScoreCounter.Text = "0";
			this.ScoreCounter.Click += new System.EventHandler(this.ScoreCounter_Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 5000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// timer2
			// 
			this.timer2.Interval = 1000;
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Script MT Bold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(1150, 191);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(0, 33);
			this.label2.TabIndex = 3;
			// 
			// CardHolder
			// 
			this.CardHolder.BackColor = System.Drawing.Color.Crimson;
			this.CardHolder.BackgroundImage = global::Memorygame2.Properties.Resources.sb_blog_programming;
			this.CardHolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.CardHolder.Controls.Add(this.DuppictureBox9);
			this.CardHolder.Controls.Add(this.pictureBox9);
			this.CardHolder.Controls.Add(this.DuppictureBox8);
			this.CardHolder.Controls.Add(this.pictureBox8);
			this.CardHolder.Controls.Add(this.DuppictureBox7);
			this.CardHolder.Controls.Add(this.pictureBox7);
			this.CardHolder.Controls.Add(this.DuppictureBox6);
			this.CardHolder.Controls.Add(this.pictureBox6);
			this.CardHolder.Controls.Add(this.DuppictureBox5);
			this.CardHolder.Controls.Add(this.pictureBox5);
			this.CardHolder.Controls.Add(this.DuppictureBox4);
			this.CardHolder.Controls.Add(this.pictureBox4);
			this.CardHolder.Controls.Add(this.DuppictureBox3);
			this.CardHolder.Controls.Add(this.pictureBox3);
			this.CardHolder.Controls.Add(this.DuppictureBox2);
			this.CardHolder.Controls.Add(this.pictureBox2);
			this.CardHolder.Controls.Add(this.DuppictureBox1);
			this.CardHolder.Controls.Add(this.pictureBox1);
			this.CardHolder.Font = new System.Drawing.Font("Script MT Bold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CardHolder.Location = new System.Drawing.Point(45, 58);
			this.CardHolder.Name = "CardHolder";
			this.CardHolder.Size = new System.Drawing.Size(962, 623);
			this.CardHolder.TabIndex = 0;
			// 
			// DuppictureBox9
			// 
			this.DuppictureBox9.BackColor = System.Drawing.Color.LavenderBlush;
			this.DuppictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.DuppictureBox9.Location = new System.Drawing.Point(719, 418);
			this.DuppictureBox9.Name = "DuppictureBox9";
			this.DuppictureBox9.Size = new System.Drawing.Size(100, 150);
			this.DuppictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.DuppictureBox9.TabIndex = 21;
			this.DuppictureBox9.TabStop = false;
			this.DuppictureBox9.Tag = "9";
			this.DuppictureBox9.Click += new System.EventHandler(this.DuppictureBox9_Click);
			// 
			// pictureBox9
			// 
			this.pictureBox9.BackColor = System.Drawing.Color.LavenderBlush;
			this.pictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox9.Location = new System.Drawing.Point(592, 418);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(100, 150);
			this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox9.TabIndex = 20;
			this.pictureBox9.TabStop = false;
			this.pictureBox9.Tag = "9";
			this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
			// 
			// DuppictureBox8
			// 
			this.DuppictureBox8.BackColor = System.Drawing.Color.LavenderBlush;
			this.DuppictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.DuppictureBox8.Cursor = System.Windows.Forms.Cursors.Default;
			this.DuppictureBox8.Location = new System.Drawing.Point(475, 418);
			this.DuppictureBox8.Name = "DuppictureBox8";
			this.DuppictureBox8.Size = new System.Drawing.Size(100, 150);
			this.DuppictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.DuppictureBox8.TabIndex = 19;
			this.DuppictureBox8.TabStop = false;
			this.DuppictureBox8.Tag = "8";
			this.DuppictureBox8.Click += new System.EventHandler(this.DuppictureBox8_Click);
			// 
			// pictureBox8
			// 
			this.pictureBox8.BackColor = System.Drawing.Color.LavenderBlush;
			this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox8.Location = new System.Drawing.Point(350, 418);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(100, 150);
			this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox8.TabIndex = 18;
			this.pictureBox8.TabStop = false;
			this.pictureBox8.Tag = "8";
			this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
			// 
			// DuppictureBox7
			// 
			this.DuppictureBox7.BackColor = System.Drawing.Color.LavenderBlush;
			this.DuppictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.DuppictureBox7.Location = new System.Drawing.Point(226, 418);
			this.DuppictureBox7.Name = "DuppictureBox7";
			this.DuppictureBox7.Size = new System.Drawing.Size(100, 150);
			this.DuppictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.DuppictureBox7.TabIndex = 17;
			this.DuppictureBox7.TabStop = false;
			this.DuppictureBox7.Tag = "7";
			this.DuppictureBox7.Click += new System.EventHandler(this.DuppictureBox7_Click);
			// 
			// pictureBox7
			// 
			this.pictureBox7.BackColor = System.Drawing.Color.LavenderBlush;
			this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox7.Location = new System.Drawing.Point(102, 422);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(100, 150);
			this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox7.TabIndex = 16;
			this.pictureBox7.TabStop = false;
			this.pictureBox7.Tag = "7";
			this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
			// 
			// DuppictureBox6
			// 
			this.DuppictureBox6.BackColor = System.Drawing.Color.LavenderBlush;
			this.DuppictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.DuppictureBox6.Location = new System.Drawing.Point(719, 250);
			this.DuppictureBox6.Name = "DuppictureBox6";
			this.DuppictureBox6.Size = new System.Drawing.Size(100, 150);
			this.DuppictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.DuppictureBox6.TabIndex = 15;
			this.DuppictureBox6.TabStop = false;
			this.DuppictureBox6.Tag = "6";
			this.DuppictureBox6.Click += new System.EventHandler(this.DuppictureBox6_Click);
			// 
			// pictureBox6
			// 
			this.pictureBox6.BackColor = System.Drawing.Color.LavenderBlush;
			this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox6.Location = new System.Drawing.Point(592, 250);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(100, 150);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox6.TabIndex = 14;
			this.pictureBox6.TabStop = false;
			this.pictureBox6.Tag = "6";
			this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click_1);
			// 
			// DuppictureBox5
			// 
			this.DuppictureBox5.BackColor = System.Drawing.Color.LavenderBlush;
			this.DuppictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.DuppictureBox5.Location = new System.Drawing.Point(475, 250);
			this.DuppictureBox5.Name = "DuppictureBox5";
			this.DuppictureBox5.Size = new System.Drawing.Size(100, 150);
			this.DuppictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.DuppictureBox5.TabIndex = 13;
			this.DuppictureBox5.TabStop = false;
			this.DuppictureBox5.Tag = "5";
			this.DuppictureBox5.Click += new System.EventHandler(this.DuppictureBox5_Click);
			// 
			// pictureBox5
			// 
			this.pictureBox5.BackColor = System.Drawing.Color.LavenderBlush;
			this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox5.Location = new System.Drawing.Point(350, 250);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(100, 150);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox5.TabIndex = 12;
			this.pictureBox5.TabStop = false;
			this.pictureBox5.Tag = "5";
			this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
			// 
			// DuppictureBox4
			// 
			this.DuppictureBox4.BackColor = System.Drawing.Color.LavenderBlush;
			this.DuppictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.DuppictureBox4.Location = new System.Drawing.Point(226, 250);
			this.DuppictureBox4.Name = "DuppictureBox4";
			this.DuppictureBox4.Size = new System.Drawing.Size(100, 150);
			this.DuppictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.DuppictureBox4.TabIndex = 11;
			this.DuppictureBox4.TabStop = false;
			this.DuppictureBox4.Tag = "4";
			this.DuppictureBox4.Click += new System.EventHandler(this.DuppictureBox4_Click);
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.LavenderBlush;
			this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox4.Location = new System.Drawing.Point(109, 250);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(100, 150);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 10;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Tag = "4";
			this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
			// 
			// DuppictureBox3
			// 
			this.DuppictureBox3.BackColor = System.Drawing.Color.LavenderBlush;
			this.DuppictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.DuppictureBox3.Location = new System.Drawing.Point(719, 78);
			this.DuppictureBox3.Name = "DuppictureBox3";
			this.DuppictureBox3.Size = new System.Drawing.Size(100, 150);
			this.DuppictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.DuppictureBox3.TabIndex = 9;
			this.DuppictureBox3.TabStop = false;
			this.DuppictureBox3.Tag = "3";
			this.DuppictureBox3.Click += new System.EventHandler(this.DuppictureBox3_Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.LavenderBlush;
			this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox3.Location = new System.Drawing.Point(592, 78);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(100, 150);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 4;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Tag = "3";
			this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click_1);
			// 
			// DuppictureBox2
			// 
			this.DuppictureBox2.BackColor = System.Drawing.Color.LavenderBlush;
			this.DuppictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.DuppictureBox2.Location = new System.Drawing.Point(475, 78);
			this.DuppictureBox2.Name = "DuppictureBox2";
			this.DuppictureBox2.Size = new System.Drawing.Size(100, 150);
			this.DuppictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.DuppictureBox2.TabIndex = 3;
			this.DuppictureBox2.TabStop = false;
			this.DuppictureBox2.Tag = "2";
			this.DuppictureBox2.Click += new System.EventHandler(this.DuppictureBox2_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.LavenderBlush;
			this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox2.Location = new System.Drawing.Point(350, 78);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(100, 150);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Tag = "2";
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// DuppictureBox1
			// 
			this.DuppictureBox1.BackColor = System.Drawing.Color.LavenderBlush;
			this.DuppictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.DuppictureBox1.Location = new System.Drawing.Point(226, 78);
			this.DuppictureBox1.Name = "DuppictureBox1";
			this.DuppictureBox1.Size = new System.Drawing.Size(100, 150);
			this.DuppictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.DuppictureBox1.TabIndex = 1;
			this.DuppictureBox1.TabStop = false;
			this.DuppictureBox1.Tag = "1";
			this.DuppictureBox1.Click += new System.EventHandler(this.DuppictureBox1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.LavenderBlush;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Image = global::Memorygame2.Properties.Resources.whatsapp;
			this.pictureBox1.Location = new System.Drawing.Point(109, 79);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Padding = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Size = new System.Drawing.Size(100, 150);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Tag = "1";
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// timer3
			// 
			this.timer3.Interval = 500;
			this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(1126, 239);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(133, 72);
			this.button1.TabIndex = 4;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// GameWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1370, 749);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.ScoreCounter);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.CardHolder);
			this.Font = new System.Drawing.Font("Script MT Bold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "GameWindow";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Memory Matching";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.CardHolder.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DuppictureBox9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DuppictureBox8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DuppictureBox7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DuppictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DuppictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DuppictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DuppictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DuppictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DuppictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CardHolder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox DuppictureBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox DuppictureBox1;
        private System.Windows.Forms.PictureBox DuppictureBox9;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox DuppictureBox8;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox DuppictureBox7;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox DuppictureBox6;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox DuppictureBox5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox DuppictureBox4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox DuppictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ScoreCounter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer3;
		private System.Windows.Forms.Button button1;
	}
}

