namespace TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tictac1 = new System.Windows.Forms.Button();
            this.tictac3 = new System.Windows.Forms.Button();
            this.tictac4 = new System.Windows.Forms.Button();
            this.tictac2 = new System.Windows.Forms.Button();
            this.tictac5 = new System.Windows.Forms.Button();
            this.tictac6 = new System.Windows.Forms.Button();
            this.tictac7 = new System.Windows.Forms.Button();
            this.tictac8 = new System.Windows.Forms.Button();
            this.tictac9 = new System.Windows.Forms.Button();
            this.rstrt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tictac1
            // 
            this.tictac1.ImageKey = "(none)";
            this.tictac1.Location = new System.Drawing.Point(171, 100);
            this.tictac1.Name = "tictac1";
            this.tictac1.Size = new System.Drawing.Size(129, 88);
            this.tictac1.TabIndex = 0;
            this.tictac1.UseVisualStyleBackColor = true;
            this.tictac1.Click += new System.EventHandler(this.button1_Click);
            this.tictac1.StyleChanged += new System.EventHandler(this.button1_Click);
            this.tictac1.SystemColorsChanged += new System.EventHandler(this.button1_Click);
            // 
            // tictac3
            // 
            this.tictac3.Location = new System.Drawing.Point(650, 100);
            this.tictac3.Name = "tictac3";
            this.tictac3.Size = new System.Drawing.Size(129, 88);
            this.tictac3.TabIndex = 2;
            this.tictac3.UseVisualStyleBackColor = true;
            this.tictac3.Click += new System.EventHandler(this.tictac3_Click);
            // 
            // tictac4
            // 
            this.tictac4.Location = new System.Drawing.Point(171, 248);
            this.tictac4.Name = "tictac4";
            this.tictac4.Size = new System.Drawing.Size(129, 88);
            this.tictac4.TabIndex = 3;
            this.tictac4.UseVisualStyleBackColor = true;
            this.tictac4.Click += new System.EventHandler(this.tictac4_Click);
            // 
            // tictac2
            // 
            this.tictac2.Location = new System.Drawing.Point(412, 100);
            this.tictac2.Name = "tictac2";
            this.tictac2.Size = new System.Drawing.Size(129, 88);
            this.tictac2.TabIndex = 4;
            this.tictac2.UseVisualStyleBackColor = true;
            this.tictac2.Click += new System.EventHandler(this.tictac2_Click);
            // 
            // tictac5
            // 
            this.tictac5.Location = new System.Drawing.Point(412, 248);
            this.tictac5.Name = "tictac5";
            this.tictac5.Size = new System.Drawing.Size(129, 88);
            this.tictac5.TabIndex = 5;
            this.tictac5.UseVisualStyleBackColor = true;
            this.tictac5.Click += new System.EventHandler(this.tictac5_Click);
            // 
            // tictac6
            // 
            this.tictac6.Location = new System.Drawing.Point(650, 248);
            this.tictac6.Name = "tictac6";
            this.tictac6.Size = new System.Drawing.Size(129, 88);
            this.tictac6.TabIndex = 6;
            this.tictac6.UseVisualStyleBackColor = true;
            this.tictac6.Click += new System.EventHandler(this.tictac6_Click);
            // 
            // tictac7
            // 
            this.tictac7.Location = new System.Drawing.Point(171, 397);
            this.tictac7.Name = "tictac7";
            this.tictac7.Size = new System.Drawing.Size(129, 88);
            this.tictac7.TabIndex = 7;
            this.tictac7.UseVisualStyleBackColor = true;
            this.tictac7.Click += new System.EventHandler(this.tictac7_Click);
            // 
            // tictac8
            // 
            this.tictac8.Location = new System.Drawing.Point(412, 397);
            this.tictac8.Name = "tictac8";
            this.tictac8.Size = new System.Drawing.Size(129, 88);
            this.tictac8.TabIndex = 8;
            this.tictac8.UseVisualStyleBackColor = true;
            this.tictac8.Click += new System.EventHandler(this.tictac8_Click);
            // 
            // tictac9
            // 
            this.tictac9.Location = new System.Drawing.Point(650, 397);
            this.tictac9.Name = "tictac9";
            this.tictac9.Size = new System.Drawing.Size(129, 88);
            this.tictac9.TabIndex = 9;
            this.tictac9.UseVisualStyleBackColor = true;
            this.tictac9.Click += new System.EventHandler(this.tictac9_Click);
            // 
            // rstrt
            // 
            this.rstrt.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rstrt.ForeColor = System.Drawing.Color.DarkGray;
            this.rstrt.Image = ((System.Drawing.Image)(resources.GetObject("rstrt.Image")));
            this.rstrt.Location = new System.Drawing.Point(29, 18);
            this.rstrt.Name = "rstrt";
            this.rstrt.Size = new System.Drawing.Size(114, 35);
            this.rstrt.TabIndex = 10;
            this.rstrt.Text = "RESTART GAME";
            this.rstrt.UseVisualStyleBackColor = true;
            this.rstrt.Click += new System.EventHandler(this.rstrt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(903, 532);
            this.Controls.Add(this.rstrt);
            this.Controls.Add(this.tictac9);
            this.Controls.Add(this.tictac8);
            this.Controls.Add(this.tictac7);
            this.Controls.Add(this.tictac6);
            this.Controls.Add(this.tictac5);
            this.Controls.Add(this.tictac2);
            this.Controls.Add(this.tictac4);
            this.Controls.Add(this.tictac3);
            this.Controls.Add(this.tictac1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.HelpButton = true;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Tic Tac Toe";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tictac1;
        private System.Windows.Forms.Button tictac3;
        private System.Windows.Forms.Button tictac4;
        private System.Windows.Forms.Button tictac2;
        private System.Windows.Forms.Button tictac5;
        private System.Windows.Forms.Button tictac6;
        private System.Windows.Forms.Button tictac7;
        private System.Windows.Forms.Button tictac8;
        private System.Windows.Forms.Button tictac9;
        private System.Windows.Forms.Button rstrt;
    }
}

