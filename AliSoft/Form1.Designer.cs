namespace AliSoft
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
            this.PanelVertical = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PanelHorizontal = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PanelHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelVertical
            // 
            this.PanelVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.PanelVertical.Controls.Add(this.pictureBox2);
            this.PanelVertical.Controls.Add(this.button2);
            this.PanelVertical.Controls.Add(this.button1);
            this.PanelVertical.Controls.Add(this.Searchbtn);
            this.PanelVertical.Controls.Add(this.Savebtn);
            this.PanelVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelVertical.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelVertical.ForeColor = System.Drawing.Color.White;
            this.PanelVertical.Location = new System.Drawing.Point(0, 0);
            this.PanelVertical.Name = "PanelVertical";
            this.PanelVertical.Size = new System.Drawing.Size(70, 729);
            this.PanelVertical.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 137);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(56)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(269, 66);
            this.button2.TabIndex = 1;
            this.button2.Text = "  About";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(56)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "         Recherche";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Searchbtn
            // 
            this.Searchbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Searchbtn.BackColor = System.Drawing.Color.Transparent;
            this.Searchbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Searchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Searchbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Searchbtn.FlatAppearance.BorderSize = 0;
            this.Searchbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Searchbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(56)))));
            this.Searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Searchbtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Searchbtn.Location = new System.Drawing.Point(0, 271);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(269, 66);
            this.Searchbtn.TabIndex = 1;
            this.Searchbtn.Text = "         Recherche";
            this.Searchbtn.UseVisualStyleBackColor = false;
            // 
            // Savebtn
            // 
            this.Savebtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Savebtn.BackColor = System.Drawing.Color.Transparent;
            this.Savebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Savebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Savebtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Savebtn.FlatAppearance.BorderSize = 0;
            this.Savebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Savebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(56)))));
            this.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savebtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Savebtn.Location = new System.Drawing.Point(0, 186);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(269, 66);
            this.Savebtn.TabIndex = 0;
            this.Savebtn.Text = "         Enregistrement";
            this.Savebtn.UseVisualStyleBackColor = false;
            // 
            // PanelHorizontal
            // 
            this.PanelHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            this.PanelHorizontal.Controls.Add(this.pictureBox1);
            this.PanelHorizontal.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHorizontal.Location = new System.Drawing.Point(70, 0);
            this.PanelHorizontal.Name = "PanelHorizontal";
            this.PanelHorizontal.Size = new System.Drawing.Size(1290, 36);
            this.PanelHorizontal.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 729);
            this.Controls.Add(this.PanelHorizontal);
            this.Controls.Add(this.PanelVertical);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PanelHorizontal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelVertical;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel PanelHorizontal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

