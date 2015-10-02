namespace AlstomVideo
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btVideo1 = new System.Windows.Forms.Button();
            this.btVideo2 = new System.Windows.Forms.Button();
            this.btVideo3 = new System.Windows.Forms.Button();
            this.btVideo4 = new System.Windows.Forms.Button();
            this.btVideo5 = new System.Windows.Forms.Button();
            this.btVideo6 = new System.Windows.Forms.Button();
            this.btVideo7 = new System.Windows.Forms.Button();
            this.btVideo8 = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btVideo1
            // 
            this.btVideo1.Image = ((System.Drawing.Image)(resources.GetObject("btVideo1.Image")));
            this.btVideo1.Location = new System.Drawing.Point(45, 33);
            this.btVideo1.Name = "btVideo1";
            this.btVideo1.Size = new System.Drawing.Size(168, 86);
            this.btVideo1.TabIndex = 0;
            this.btVideo1.Text = ",";
            this.btVideo1.UseVisualStyleBackColor = true;
            this.btVideo1.Click += new System.EventHandler(this.btVideo1_Click);
            // 
            // btVideo2
            // 
            this.btVideo2.Location = new System.Drawing.Point(246, 64);
            this.btVideo2.Name = "btVideo2";
            this.btVideo2.Size = new System.Drawing.Size(75, 23);
            this.btVideo2.TabIndex = 1;
            this.btVideo2.Text = "button2";
            this.btVideo2.UseVisualStyleBackColor = true;
            this.btVideo2.Click += new System.EventHandler(this.btVideo2_Click);
            // 
            // btVideo3
            // 
            this.btVideo3.Location = new System.Drawing.Point(348, 65);
            this.btVideo3.Name = "btVideo3";
            this.btVideo3.Size = new System.Drawing.Size(75, 23);
            this.btVideo3.TabIndex = 2;
            this.btVideo3.Text = "button3";
            this.btVideo3.UseVisualStyleBackColor = true;
            this.btVideo3.Click += new System.EventHandler(this.btVideo3_Click);
            // 
            // btVideo4
            // 
            this.btVideo4.Location = new System.Drawing.Point(479, 64);
            this.btVideo4.Name = "btVideo4";
            this.btVideo4.Size = new System.Drawing.Size(75, 23);
            this.btVideo4.TabIndex = 3;
            this.btVideo4.Text = "button4";
            this.btVideo4.UseVisualStyleBackColor = true;
            this.btVideo4.Click += new System.EventHandler(this.btVideo4_Click);
            // 
            // btVideo5
            // 
            this.btVideo5.Location = new System.Drawing.Point(86, 162);
            this.btVideo5.Name = "btVideo5";
            this.btVideo5.Size = new System.Drawing.Size(75, 23);
            this.btVideo5.TabIndex = 4;
            this.btVideo5.Text = "button5";
            this.btVideo5.UseVisualStyleBackColor = true;
            this.btVideo5.Click += new System.EventHandler(this.btVideo5_Click);
            // 
            // btVideo6
            // 
            this.btVideo6.Location = new System.Drawing.Point(219, 161);
            this.btVideo6.Name = "btVideo6";
            this.btVideo6.Size = new System.Drawing.Size(75, 23);
            this.btVideo6.TabIndex = 5;
            this.btVideo6.Text = "button6";
            this.btVideo6.UseVisualStyleBackColor = true;
            this.btVideo6.Click += new System.EventHandler(this.btVideo6_Click);
            // 
            // btVideo7
            // 
            this.btVideo7.Location = new System.Drawing.Point(348, 161);
            this.btVideo7.Name = "btVideo7";
            this.btVideo7.Size = new System.Drawing.Size(75, 23);
            this.btVideo7.TabIndex = 6;
            this.btVideo7.Text = "button7";
            this.btVideo7.UseVisualStyleBackColor = true;
            this.btVideo7.Click += new System.EventHandler(this.btVideo7_Click);
            // 
            // btVideo8
            // 
            this.btVideo8.Location = new System.Drawing.Point(479, 162);
            this.btVideo8.Name = "btVideo8";
            this.btVideo8.Size = new System.Drawing.Size(75, 23);
            this.btVideo8.TabIndex = 7;
            this.btVideo8.Text = "button8";
            this.btVideo8.UseVisualStyleBackColor = true;
            this.btVideo8.Click += new System.EventHandler(this.btVideo8_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(115, 307);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(611, 345);
            this.axWindowsMediaPlayer1.TabIndex = 8;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1000, 583);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.btVideo8);
            this.Controls.Add(this.btVideo7);
            this.Controls.Add(this.btVideo6);
            this.Controls.Add(this.btVideo5);
            this.Controls.Add(this.btVideo4);
            this.Controls.Add(this.btVideo3);
            this.Controls.Add(this.btVideo2);
            this.Controls.Add(this.btVideo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btVideo1;
        private System.Windows.Forms.Button btVideo2;
        private System.Windows.Forms.Button btVideo3;
        private System.Windows.Forms.Button btVideo4;
        private System.Windows.Forms.Button btVideo5;
        private System.Windows.Forms.Button btVideo6;
        private System.Windows.Forms.Button btVideo7;
        private System.Windows.Forms.Button btVideo8;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}