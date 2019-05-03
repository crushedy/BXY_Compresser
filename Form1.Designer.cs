namespace BYX_Archiver
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
            this.CLOSE_APP_BUT = new System.Windows.Forms.Button();
            this.MIN_BUT = new System.Windows.Forms.Button();
            this.MAX_BUT = new System.Windows.Forms.Button();
            this.Drag_Area = new System.Windows.Forms.Panel();
            this.screen2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Filename_textbox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.screen15 = new System.Windows.Forms.Panel();
            this.IMG2 = new System.Windows.Forms.PictureBox();
            this.IMG1 = new System.Windows.Forms.PictureBox();
            this.Drop1 = new System.Windows.Forms.PictureBox();
            this.big_Photo_2 = new System.Windows.Forms.PictureBox();
            this.INFO_BUT = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Big_Photo = new System.Windows.Forms.PictureBox();
            this.Drag_Area.SuspendLayout();
            this.screen2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMG2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.big_Photo_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Big_Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // CLOSE_APP_BUT
            // 
            this.CLOSE_APP_BUT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CLOSE_APP_BUT.BackColor = System.Drawing.Color.Transparent;
            this.CLOSE_APP_BUT.FlatAppearance.BorderSize = 0;
            this.CLOSE_APP_BUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CLOSE_APP_BUT.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLOSE_APP_BUT.Location = new System.Drawing.Point(976, 10);
            this.CLOSE_APP_BUT.Name = "CLOSE_APP_BUT";
            this.CLOSE_APP_BUT.Size = new System.Drawing.Size(32, 31);
            this.CLOSE_APP_BUT.TabIndex = 0;
            this.CLOSE_APP_BUT.Text = "X";
            this.CLOSE_APP_BUT.UseVisualStyleBackColor = false;
            this.CLOSE_APP_BUT.Click += new System.EventHandler(this.button1_Click);
            // 
            // MIN_BUT
            // 
            this.MIN_BUT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MIN_BUT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MIN_BUT.BackColor = System.Drawing.Color.Transparent;
            this.MIN_BUT.FlatAppearance.BorderSize = 0;
            this.MIN_BUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MIN_BUT.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MIN_BUT.Location = new System.Drawing.Point(908, 10);
            this.MIN_BUT.Name = "MIN_BUT";
            this.MIN_BUT.Size = new System.Drawing.Size(26, 27);
            this.MIN_BUT.TabIndex = 1;
            this.MIN_BUT.Text = "_";
            this.MIN_BUT.UseVisualStyleBackColor = false;
            this.MIN_BUT.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // MAX_BUT
            // 
            this.MAX_BUT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MAX_BUT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MAX_BUT.BackColor = System.Drawing.Color.Transparent;
            this.MAX_BUT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MAX_BUT.FlatAppearance.BorderSize = 0;
            this.MAX_BUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MAX_BUT.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAX_BUT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MAX_BUT.Location = new System.Drawing.Point(939, 6);
            this.MAX_BUT.Name = "MAX_BUT";
            this.MAX_BUT.Size = new System.Drawing.Size(34, 32);
            this.MAX_BUT.TabIndex = 2;
            this.MAX_BUT.Text = "+";
            this.MAX_BUT.UseVisualStyleBackColor = false;
            this.MAX_BUT.Click += new System.EventHandler(this.Maximize_Click);
            // 
            // Drag_Area
            // 
            this.Drag_Area.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Drag_Area.Controls.Add(this.INFO_BUT);
            this.Drag_Area.Controls.Add(this.Logo);
            this.Drag_Area.Controls.Add(this.MAX_BUT);
            this.Drag_Area.Controls.Add(this.MIN_BUT);
            this.Drag_Area.Controls.Add(this.CLOSE_APP_BUT);
            this.Drag_Area.Location = new System.Drawing.Point(0, -3);
            this.Drag_Area.Name = "Drag_Area";
            this.Drag_Area.Size = new System.Drawing.Size(1029, 58);
            this.Drag_Area.TabIndex = 7;
            this.Drag_Area.Paint += new System.Windows.Forms.PaintEventHandler(this.Drag_Area_Paint);
            this.Drag_Area.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Drag_Area_MouseDoubleClick);
            this.Drag_Area.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag_Area_MouseDown);
            this.Drag_Area.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag_Area_MouseMove);
            this.Drag_Area.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Drag_Area_MouseUp_1);
            // 
            // screen2
            // 
            this.screen2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.screen2.Controls.Add(this.textBox1);
            this.screen2.Controls.Add(this.IMG2);
            this.screen2.Controls.Add(this.IMG1);
            this.screen2.Controls.Add(this.Drop1);
            this.screen2.Controls.Add(this.label11);
            this.screen2.Controls.Add(this.label10);
            this.screen2.Controls.Add(this.label9);
            this.screen2.Controls.Add(this.label8);
            this.screen2.Controls.Add(this.label7);
            this.screen2.Controls.Add(this.label6);
            this.screen2.Controls.Add(this.label5);
            this.screen2.Controls.Add(this.label4);
            this.screen2.Controls.Add(this.label3);
            this.screen2.Controls.Add(this.label2);
            this.screen2.Controls.Add(this.label1);
            this.screen2.Controls.Add(this.Filename_textbox);
            this.screen2.Controls.Add(this.big_Photo_2);
            this.screen2.Location = new System.Drawing.Point(31, 83);
            this.screen2.Name = "screen2";
            this.screen2.Size = new System.Drawing.Size(1032, 592);
            this.screen2.TabIndex = 8;
            this.screen2.DragDrop += new System.Windows.Forms.DragEventHandler(this.screen2_DragDrop);
            this.screen2.DragOver += new System.Windows.Forms.DragEventHandler(this.screen2_DragOver);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 471);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 69);
            this.textBox1.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label11.Location = new System.Drawing.Point(927, 416);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 9);
            this.label11.TabIndex = 15;
            this.label11.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label10.Location = new System.Drawing.Point(927, 398);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 9);
            this.label10.TabIndex = 14;
            this.label10.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label9.Location = new System.Drawing.Point(909, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 9);
            this.label9.TabIndex = 13;
            this.label9.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label8.Location = new System.Drawing.Point(857, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 9);
            this.label8.TabIndex = 12;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label7.Location = new System.Drawing.Point(712, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 9);
            this.label7.TabIndex = 11;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label6.Location = new System.Drawing.Point(712, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 9);
            this.label6.TabIndex = 10;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label5.Location = new System.Drawing.Point(712, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 9);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label4.Location = new System.Drawing.Point(681, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 9);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label3.Location = new System.Drawing.Point(641, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 9);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(41)))), ((int)(((byte)(28)))));
            this.label2.Location = new System.Drawing.Point(422, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(41)))), ((int)(((byte)(28)))));
            this.label1.Location = new System.Drawing.Point(398, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // Filename_textbox
            // 
            this.Filename_textbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Filename_textbox.BackColor = System.Drawing.Color.White;
            this.Filename_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Filename_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filename_textbox.Location = new System.Drawing.Point(69, 243);
            this.Filename_textbox.Name = "Filename_textbox";
            this.Filename_textbox.Size = new System.Drawing.Size(128, 19);
            this.Filename_textbox.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // screen15
            // 
            this.screen15.BackgroundImage = global::BYX_Alpha.Properties.Resources.Slide2;
            this.screen15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.screen15.Location = new System.Drawing.Point(0, 57);
            this.screen15.Name = "screen15";
            this.screen15.Size = new System.Drawing.Size(749, 416);
            this.screen15.TabIndex = 7;
            this.screen15.Click += new System.EventHandler(this.screen15_Click);
            // 
            // IMG2
            // 
            this.IMG2.BackColor = System.Drawing.Color.White;
            this.IMG2.Location = new System.Drawing.Point(847, 232);
            this.IMG2.Name = "IMG2";
            this.IMG2.Size = new System.Drawing.Size(97, 83);
            this.IMG2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IMG2.TabIndex = 18;
            this.IMG2.TabStop = false;
            this.IMG2.Click += new System.EventHandler(this.IMG2_Click);
            // 
            // IMG1
            // 
            this.IMG1.BackColor = System.Drawing.Color.White;
            this.IMG1.Location = new System.Drawing.Point(630, 232);
            this.IMG1.Name = "IMG1";
            this.IMG1.Size = new System.Drawing.Size(97, 83);
            this.IMG1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IMG1.TabIndex = 17;
            this.IMG1.TabStop = false;
            this.IMG1.Click += new System.EventHandler(this.IMG1_Click);
            // 
            // Drop1
            // 
            this.Drop1.BackColor = System.Drawing.Color.White;
            this.Drop1.Image = ((System.Drawing.Image)(resources.GetObject("Drop1.Image")));
            this.Drop1.Location = new System.Drawing.Point(360, 232);
            this.Drop1.Name = "Drop1";
            this.Drop1.Size = new System.Drawing.Size(97, 83);
            this.Drop1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Drop1.TabIndex = 16;
            this.Drop1.TabStop = false;
            this.Drop1.Click += new System.EventHandler(this.Drop1_click);
            // 
            // big_Photo_2
            // 
            this.big_Photo_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.big_Photo_2.Image = global::BYX_Alpha.Properties.Resources.Slide3_SVG3;
            this.big_Photo_2.Location = new System.Drawing.Point(-31, 49);
            this.big_Photo_2.Name = "big_Photo_2";
            this.big_Photo_2.Size = new System.Drawing.Size(1029, 592);
            this.big_Photo_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.big_Photo_2.TabIndex = 0;
            this.big_Photo_2.TabStop = false;
            this.big_Photo_2.Click += new System.EventHandler(this.big_Photo_2_Click);
            this.big_Photo_2.DragDrop += new System.Windows.Forms.DragEventHandler(this.big_Photo_2_DragDrop);
            this.big_Photo_2.DragOver += new System.Windows.Forms.DragEventHandler(this.big_Photo_2_DragOver);
            // 
            // INFO_BUT
            // 
            this.INFO_BUT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.INFO_BUT.BackColor = System.Drawing.Color.White;
            this.INFO_BUT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("INFO_BUT.BackgroundImage")));
            this.INFO_BUT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.INFO_BUT.FlatAppearance.BorderSize = 0;
            this.INFO_BUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.INFO_BUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INFO_BUT.Location = new System.Drawing.Point(872, 6);
            this.INFO_BUT.Name = "INFO_BUT";
            this.INFO_BUT.Size = new System.Drawing.Size(37, 37);
            this.INFO_BUT.TabIndex = 6;
            this.INFO_BUT.UseVisualStyleBackColor = false;
            this.INFO_BUT.Click += new System.EventHandler(this.INFO_BUT_Click);
            // 
            // Logo
            // 
            this.Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(12, 6);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(210, 48);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 5;
            this.Logo.TabStop = false;
            // 
            // Big_Photo
            // 
            this.Big_Photo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Big_Photo.Image = ((System.Drawing.Image)(resources.GetObject("Big_Photo.Image")));
            this.Big_Photo.InitialImage = null;
            this.Big_Photo.Location = new System.Drawing.Point(0, 57);
            this.Big_Photo.Name = "Big_Photo";
            this.Big_Photo.Size = new System.Drawing.Size(1020, 542);
            this.Big_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Big_Photo.TabIndex = 4;
            this.Big_Photo.TabStop = false;
            this.Big_Photo.Click += new System.EventHandler(this.Big_Photo_Click);
            this.Big_Photo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Big_Photo_MouseMove);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1024, 635);
            this.Controls.Add(this.screen15);
            this.Controls.Add(this.screen2);
            this.Controls.Add(this.Drag_Area);
            this.Controls.Add(this.Big_Photo);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.Drag_Area.ResumeLayout(false);
            this.screen2.ResumeLayout(false);
            this.screen2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMG2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.big_Photo_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Big_Photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CLOSE_APP_BUT;
        private System.Windows.Forms.Button MIN_BUT;
        private System.Windows.Forms.Button MAX_BUT;
        private System.Windows.Forms.PictureBox Big_Photo;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button INFO_BUT;
        private System.Windows.Forms.Panel Drag_Area;
        private System.Windows.Forms.Panel screen2;
        private System.Windows.Forms.PictureBox big_Photo_2;
        private System.Windows.Forms.TextBox Filename_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox IMG2;
        private System.Windows.Forms.PictureBox IMG1;
        private System.Windows.Forms.PictureBox Drop1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel screen15;
    }
}

