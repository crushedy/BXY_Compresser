using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;
using Svg;
using System.Windows.Media.Imaging;
using IconLib;
using System.Drawing.IconLib;

namespace BYX_Archiver
{
    public partial class Form1 : Form
    {

        
        private int posX;
        private int posY;
        public bool drag;
        private bool maximized;
        private Point previous_position;
        //Resize Window
        bool on_MinimumSize;
        short minimumWidth = 350;
        short minimumHeight = 26;
        short borderSpace = 0;
        short borderDiameter = 0;
        bool onBorderRight;
        bool onBorderLeft;
        bool onBorderTop;
        bool onBorderBottom;
        bool onCornerTopRight;
        bool onCornerTopLeft;
        bool onCornerBottomRight;
        bool onCornerBottomLeft;
        bool movingRight;
        bool movingLeft;
        bool movingTop;
        bool movingBottom;
        bool movingCornerTopRight;
        bool movingCornerTopLeft;
        bool movingCornerBottomRight;
        bool movingCornerBottomLeft;
        public int nr_of_frames;

        public Font font1;
        public Font font2;
        public Font font3;
        public Color color1;
        public Color color2;
        public Color color3;
        public int Screen_width, Screen_height;
        public string new_filename;
        public string new_filename2;
        public string png_temp_filename;
        public string png_temp_filename1;
        public bool png;
        public bool svg;
        public bool ico;

        public Form1()
        {
            
            InitializeComponent();
            IMG1.Visible = true;
            IMG2.Visible = true;

            nr_of_frames = 1;
            Screen_width= Screen.PrimaryScreen.Bounds.Width;
            Screen_height = Screen.PrimaryScreen.Bounds.Height;

            FormBorderStyle = FormBorderStyle.None;
            png = false;
            svg = false;
            ico = false;

            textBox1.Location = new Point(0, 0);
                
            this.ClientSize = new Size(1024, 635);
            this.ClientSize = new Size((int)(Screen_width*0.7), (int)(Screen_width*0.4340));
            this.StartPosition = FormStartPosition.CenterScreen;

            font1 = new Font("Calibri", 20f, FontStyle.Regular);
            color1 = Color.FromKnownColor(KnownColor.White);
            font2 = new Font("Calibri", 15f, FontStyle.Bold);
            color2 = Color.Transparent;
            font3 = new Font("Calibri", 15f, FontStyle.Regular);
            color3 = Color.FromKnownColor(KnownColor.White);
           
            label1.Font = font1;
            label1.ForeColor = color3;
            label1.BackColor = Color.Transparent;
            label1.Parent = big_Photo_2;
            label2.Font = font1;
            label2.ForeColor = color3;
            label2.BackColor = Color.Transparent;
            label2.Parent = big_Photo_2;
            label3.Font = font1;
            label3.ForeColor = color1;
            label3.BackColor = Color.Transparent;
            label3.Parent = big_Photo_2;
            label4.Font = font1;
            label4.ForeColor = color1;
            label4.BackColor = Color.Transparent;
            label4.Parent = big_Photo_2;
            label5.Font = font1;
            label5.ForeColor = color1;
            label5.BackColor = Color.Transparent;
            label5.Parent = big_Photo_2;
            label6.Font = font1;
            label6.ForeColor = color1;
            label6.BackColor = Color.Transparent;
            label6.Parent = big_Photo_2;
            label7.Font = font1;
            label7.ForeColor = color1;
            label7.BackColor = Color.Transparent;
            label7.Parent = big_Photo_2;
            label8.Font = font1;
            label8.ForeColor = color1;
            label8.BackColor = Color.Transparent;
            label8.Parent = big_Photo_2;
            label9.Font = font1;
            label9.ForeColor = color1;
            label9.BackColor = Color.Transparent;
            label9.Parent = big_Photo_2;
            label10.Font = font1;
            label10.ForeColor = color1;
            label10.BackColor = Color.Transparent;
            label10.Parent = big_Photo_2;
            label11.Font = font1;
            label11.ForeColor = color1;
            label11.BackColor = Color.Transparent;
            label11.Parent = big_Photo_2;


            Filename_textbox.Font = font3;

            
            char[] c = { '\uD83D', '\uDDD6' };
            MAX_BUT.Text = new string(c, 0, 1);
            Redraw_Controls();
            maximized = false;
            drag = false;
            previous_position = this.Location;
            screen2.Visible = false;
            screen15.Visible = false;
            screen2.AllowDrop = true;
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            //IMG1.Visible = false;
            //IMG2.Visible = false;
            Drop1.Visible = true;
            this.AllowDrop = true;
            this.screen2.AllowDrop = true;
            openFileDialog1.Filter = "ICON Files (*.ico)|*.ico|SVG Files (*.svg)|*.svg|PNG Files (*.png)|*.png|All Files (*.*)|*.*";
           // textBox1.Visible = false;    
        }

        private void Redraw_Controls()
        {
            
            int width = this.Width;
            int height = this.Height;
            Drag_Area.Size = new Size((int)(width-2*borderSpace), (int)(0.074 * height-borderSpace));
            Drag_Area.Location = new Point(borderSpace, borderSpace);
            Logo.Size = new Size((int)(0.136 * width), (int)(0.053 * height));
            Logo.Location = new Point((int)(0.019 * width), (int)(0.016 * height));

            Big_Photo.Size = new Size((int)(width) - 2 * borderSpace, (int)(0.925 * height - 2 * borderSpace));
            Big_Photo.Location = new Point((int)(borderSpace), (int)(0.074 * height + borderSpace));

            MIN_BUT.Size = new Size((int)(0.023 * width), (int)(0.036 * height));
            MIN_BUT.Location = new Point((int)(0.9220 * width - borderSpace), (int)(0.024 * height + borderSpace));

            MAX_BUT.Size = new Size((int)(0.023 * width), (int)(0.036 * height));
            MAX_BUT.Location = new Point((int)(0.9454 * width - borderSpace), (int)(0.024 * height + borderSpace));

            screen15.Size = new Size((int)(width) - 2 * borderSpace, (int)(0.925 * height - 2 * borderSpace));
            screen15.Location = new Point((int)(borderSpace), (int)(0.075 * height + borderSpace));

            screen2.Size = new Size((int)(width) - 2 * borderSpace, (int)(0.925 * height - 2 * borderSpace));
            screen2.Location = new Point((int)(borderSpace), (int)(0.075 * height + borderSpace));

            //big_Photo_2.Size = new Size(this.Width, (int)(0.925 * height - 2 * borderSpace));
            big_Photo_2.Size = new Size(screen2.Width, (int)(screen2.Height));
            big_Photo_2.Location = new Point(0, 0);

            INFO_BUT.Size = new Size((int)(0.023 * width), (int)(0.036 * height));
            INFO_BUT.Location = new Point((int)(0.8943 * width - borderSpace - 5), (int)(0.024 * height + borderSpace));

            CLOSE_APP_BUT.Size = new Size((int)(0.023 * width), (int)(0.036 * height));
            CLOSE_APP_BUT.Location = new Point((int)(0.9679 * width - borderSpace), (int)(0.024 * height + borderSpace));
            //MessageBox.Show("width=" + width + " height=" + height + " Close_but_size=" + CLOSE_APP_BUT.Width + "x" + CLOSE_APP_BUT.Height + " pos=" + CLOSE_APP_BUT.Left + "x" + CLOSE_APP_BUT.Top);

            if (ico == true || svg == true)
            {

                int screen2_width = screen2.Width;
                int screen2_height = screen2.Height;


                Filename_textbox.Size = new Size((int)(0.1050 * screen2_width), (int)(0.0598 * screen2_height));
                Filename_textbox.Location = new Point((int)(0.0750 * screen2_width), (int)(0.6780 * screen2_height));

                Drop1.Size = new Size((int)(0.1755 * screen2_width), (int)(0.2877 * screen2_height));
                Drop1.Location = new Point((int)(0.0832 * screen2_width), (int)(0.1809 * screen2_height));
                IMG1.Size = new Size((int)(0.1755 * screen2_width), (int)(0.2877 * screen2_height));
                IMG1.Location = new Point((int)(0.3748 * screen2_width), (int)(0.1809 * screen2_height));
                IMG2.Size = new Size((int)(0.1755 * screen2_width), (int)(0.2877 * screen2_height));
                IMG2.Location = new Point((int)(0.6145 * screen2_width), (int)(0.1809 * screen2_height));
                IMG1.Visible = true;
                IMG2.Visible = true;

                label1.Location = new Point((int)(0.1709 * screen2_width), (int)(0.7460 * screen2_height));
                label2.Location = new Point((int)(0.4671 * screen2_width), (int)(0.5954 * screen2_height));
                label3.Location = new Point((int)(0.7068 * screen2_width), (int)(0.5954 * screen2_height));
                label4.Location = new Point((int)(0.7068 * screen2_width), (int)(0.6699 * screen2_height));
                label5.Location = new Point((int)(0.4671 * screen2_width), (int)(0.8277 * screen2_height));
                label6.Location = new Point((int)(0.4671 * screen2_width), (int)(0.8999 * screen2_height));
                label7.Location = new Point((int)(0.7068 * screen2_width), (int)(0.8277 * screen2_height));
                label8.Location = new Point((int)(0.7068 * screen2_width), (int)(0.9030 * screen2_height));
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;


                label9.Location = new Point((int)(0.8827 * screen2_width), (int)(0.7214 * screen2_height));
                label9.Visible = false;
                label10.Location = new Point((int)(0.9108 * screen2_width), (int)(0.7690 * screen2_height));
                label10.Visible = false;
                label11.Location = new Point((int)(0.9108 * screen2_width), (int)(0.8185 * screen2_height));
                label11.Visible = false;
                IMG1.Image = null;
                IMG2.Image = null;
                if (ico == true)
                {
                    Logo.Image = BYX_Alpha.Properties.Resources.p3logo1;
                    INFO_BUT.BackgroundImage = BYX_Alpha.Properties.Resources.p3info1;
                    Drag_Area.BackColor = Color.FromName("ButtonHighlight");
                    screen2.Visible = true;
                    screen2.Location = new Point((int)(borderSpace), (int)(0.074 * this.Height + borderSpace));
                    screen2.Size = new Size((int)(this.Width) - 2 * borderSpace, (int)(0.925 * this.Height - 2 * borderSpace));
                    big_Photo_2.Image = BYX_Alpha.Properties.Resources.Slide3_ICO4;
                    openFileDialog1.Filter = "ICON Files (*.ico)|*.ico|All Files (*.*)|*.*";
                }
                if (svg == true)
                {
                    screen15.Visible = false;
                    Logo.Image = BYX_Alpha.Properties.Resources.p3logo1;
                    INFO_BUT.BackgroundImage = BYX_Alpha.Properties.Resources.p3info1;
                    Drag_Area.BackColor = Color.FromName("ButtonHighlight");
                    screen2.Visible = true;
                    screen2.Location = new Point((int)(borderSpace), (int)(0.074 * this.Height + borderSpace));
                    screen2.Size = new Size((int)(this.Width) - 2 * borderSpace, (int)(0.925 * this.Height - 2 * borderSpace));
                    big_Photo_2.Image = BYX_Alpha.Properties.Resources.Slide3_SVG3;
                    openFileDialog1.Filter = "SVG Files (*.svg)|*.svg|All Files (*.*)|*.*";
                }
            }                
            if(png==true)
            {


                int screen2_width = screen2.Width;
                int screen2_height = screen2.Height;

                
                Filename_textbox.Size = new Size((int)(0.1110 * screen2_width), (int)(0.0602 * screen2_height));
                Filename_textbox.Location = new Point((int)(0.1799 * screen2_width), (int)(0.6780 * screen2_height));

                Drop1.Size = new Size((int)(0.1761 * screen2_width), (int)(0.2898 * screen2_height));
                Drop1.Location = new Point((int)(0.1822 * screen2_width), (int)(0.1721 * screen2_height));

                IMG1.Size = new Size((int)(0.1761 * screen2_width), (int)(0.2898 * screen2_height));
                IMG1.Location = new Point((int)(0.5727 * screen2_width), (int)(0.1721 * screen2_height));
                IMG1.Visible = true;
                IMG1.Image = null;

                IMG2.Size = new Size((int)(0.1761 * screen2_width), (int)(0.2898 * screen2_height));
                IMG2.Location = new Point((int)(0.7714 * screen2_width), (int)(0.1721 * screen2_height));
                IMG2.Visible = false;

                label1.Location = new Point((int)(0.2733 * screen2_width), (int)(0.7520 * screen2_height));
                label2.Location = new Point((int)(0.6676 * screen2_width), (int)(0.5928 * screen2_height));
                label3.Location = new Point((int)(0.6676 * screen2_width), (int)(0.5968 * screen2_height));

                label4.Location = new Point((int)(0.6676 * screen2_width), (int)(0.6713 * screen2_height));
                label7.Location = new Point((int)(0.6606 * screen2_width), (int)(0.8320 * screen2_height));
                label8.Location = new Point((int)(0.6606 * screen2_width), (int)(0.9041 * screen2_height));

                label6.Location = new Point((int)(0.6327 * screen2_width), (int)(0.7690 * screen2_height));
                label9.Location = new Point((int)(0.8827 * screen2_width), (int)(0.7214 * screen2_height));
                label10.Location = new Point((int)(0.9108 * screen2_width), (int)(0.7690 * screen2_height));
                label11.Location = new Point((int)(0.9108 * screen2_width), (int)(0.8185 * screen2_height));

                label2.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;

                screen15.Visible = false;
                Logo.Image = BYX_Alpha.Properties.Resources.p3logo1;
                INFO_BUT.BackgroundImage = BYX_Alpha.Properties.Resources.p3info1;
                Drag_Area.BackColor = Color.FromName("ButtonHighlight");
                screen2.Visible = true;
                screen2.Location = new Point((int)(borderSpace), (int)(0.074 * this.Height + borderSpace));
                screen2.Size = new Size((int)(this.Width) - 2 * borderSpace, (int)(0.925 * this.Height - 2 * borderSpace));
                big_Photo_2.Image = BYX_Alpha.Properties.Resources.Slide3_PNG5;
                openFileDialog1.Filter = "PNG Files (*.png)|*.png|All Files (*.*)|*.*";
            }
            this.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            if (maximized)
            {
                Restore_Window();
                maximized = false;
          
            }
            else
            {

                Maximize_Window();
                maximized = true;

            }
        }

        private void Restore_Window()
        {
            this.Location = previous_position;
            char[] cc = { '\uD83D', '\uDDD7' };
            string a = new string(cc, 0, 1);
            this.MAX_BUT.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            MAX_BUT.Text = a;
            this.Size = new Size(1024, 665);
            maximized = false;
            Redraw_Controls();
        }

        private void Maximize_Window()
        {
            previous_position = this.Location;
            char[] cc = { '\uD83D', '\uDDD6' };
            string a = new string(cc, 0, 2);
            MAX_BUT.Text = a;
            this.Location = new Point(0, 0);
            Screen myScreen = Screen.FromControl(this);
            Rectangle area = myScreen.WorkingArea;
            int screen_width = area.Width;
            int screen_height = area.Height;
            if ((double)screen_width / screen_height >= 1.54)
            {
                this.Height = screen_height;
                this.Width = (int)(screen_height * 1.54);
                Redraw_Controls();
            }
            else
            {
                this.Width = screen_width;
                this.Height = (int)(screen_width / 1.54);
                Redraw_Controls();
            }
        }

        private void Drag_Area_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (maximized)
                {
                    Restore_Window();
                    maximized = false;

                }
                else
                {
                    Maximize_Window();
                    maximized = true;

                }
            }
        }

        private void Big_Photo_Click(object sender, EventArgs e)
        {
            int button_W = (int)(0.286 * this.Width);
            int button_H = (int)(0.065 * this.Height);
            int button_X = (int)(0.713 * this.Width)+this.Left;
            int button_Y = (int)(0.167 * this.Height)+this.Top;
            int cursor_X = System.Windows.Forms.Cursor.Position.X;
            int cursor_Y = System.Windows.Forms.Cursor.Position.Y;
            int right = button_X + button_W;
            if ((button_X < cursor_X) & (cursor_X < (button_X + button_W)))
                if ((button_Y < cursor_Y) & (cursor_Y < (button_Y + button_H)))
                {
                    screen15.Visible = true;
                    screen15.Location = new Point((int)(borderSpace), (int)(0.074 * this.Height + borderSpace));
                    screen15.Size = new Size((int)(this.Width) - 2 * borderSpace, (int)(0.925 * this.Height - 2 * borderSpace));
                    Drag_Area.BackColor = Color.FromArgb(211, 161, 212);
                    screen2.Visible = false;
                    Logo.Image = BYX_Alpha.Properties.Resources.p2logo1;
                    INFO_BUT.BackgroundImage = BYX_Alpha.Properties.Resources.p2info1;

                    Drag_Area.Invalidate();
                }
        }


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.Width <= minimumWidth) { this.Width = (minimumWidth + 5); on_MinimumSize = true; }
            if (this.Height <= minimumHeight) { this.Height = (minimumHeight + 5); on_MinimumSize = true; }
            if (on_MinimumSize) { stopResizer(); } else { startResizer(); }


            if ((Cursor.Position.X > ((this.Location.X + this.Width) - borderDiameter))
                & (Cursor.Position.Y > (this.Location.Y + borderSpace))
                & (Cursor.Position.Y < ((this.Location.Y + this.Height) - borderSpace)))
            { this.Cursor = Cursors.SizeWE; onBorderRight = true; }

            else if ((Cursor.Position.X < (this.Location.X + borderDiameter))
                & (Cursor.Position.Y > (this.Location.Y + borderSpace))
                & (Cursor.Position.Y < ((this.Location.Y + this.Height) - borderSpace)))
            { this.Cursor = Cursors.SizeWE; onBorderLeft = true; }

            else if ((Cursor.Position.Y < (this.Location.Y + borderDiameter))
                & (Cursor.Position.X > (this.Location.X + borderSpace))
                & (Cursor.Position.X < ((this.Location.X + this.Width) - borderSpace)))
            { this.Cursor = Cursors.SizeNS; onBorderTop = true; }

            else if ((Cursor.Position.Y > ((this.Location.Y + this.Height) - borderDiameter))
                & (Cursor.Position.X > (this.Location.X + borderSpace))
                & (Cursor.Position.X < ((this.Location.X + this.Width) - borderSpace)))
            { this.Cursor = Cursors.SizeNS; onBorderBottom = true; }

            else if ((Cursor.Position.X == ((this.Location.X + this.Width) - 1))
                & (Cursor.Position.Y == this.Location.Y))
            { this.Cursor = Cursors.SizeNESW; onCornerTopRight = true; }
            else if ((Cursor.Position.X == this.Location.X)
                & (Cursor.Position.Y == this.Location.Y))
            { this.Cursor = Cursors.SizeNWSE; onCornerTopLeft = true; }

            else if ((Cursor.Position.X == ((this.Location.X + this.Width) - 1))
                & (Cursor.Position.Y == ((this.Location.Y + this.Height) - 1)))
            { this.Cursor = Cursors.SizeNWSE; onCornerBottomRight = true; }

            else if ((Cursor.Position.X == this.Location.X)
                & (Cursor.Position.Y == ((this.Location.Y + this.Height) - 1)))
            { this.Cursor = Cursors.SizeNESW; onCornerBottomLeft = true; }

            else
            {
                onBorderRight = false;
                onBorderLeft = false;
                onBorderTop = false;
                onBorderBottom = false;
                onCornerTopRight = false;
                onCornerTopLeft = false;
                onCornerBottomRight = false;
                onCornerBottomLeft = false;
                this.Cursor = Cursors.Default;
            }
        }

        private void startResizer()
        {
            if (movingRight)
            {
                this.Width = Cursor.Position.X - this.Location.X;
            }

            else if (movingLeft)
            {
                this.Width = ((this.Width + this.Location.X) - Cursor.Position.X);
                this.Location = new Point(Cursor.Position.X, this.Location.Y);
            }

            else if (movingTop)
            {
                this.Height = ((this.Height + this.Location.Y) - Cursor.Position.Y);
                this.Location = new Point(this.Location.X, Cursor.Position.Y);
            }

            else if (movingBottom)
            {
                this.Height = (Cursor.Position.Y - this.Location.Y);
            }

            else if (movingCornerTopRight)
            {
                this.Width = (Cursor.Position.X - this.Location.X);
                this.Height = ((this.Location.Y - Cursor.Position.Y) + this.Height);
                this.Location = new Point(this.Location.X, Cursor.Position.Y);
            }

            else if (movingCornerTopLeft)
            {
                this.Width = ((this.Width + this.Location.X) - Cursor.Position.X);
                this.Location = new Point(Cursor.Position.X, this.Location.Y);
                this.Height = ((this.Height + this.Location.Y) - Cursor.Position.Y);
                this.Location = new Point(this.Location.X, Cursor.Position.Y);
            }

            else if (movingCornerBottomRight)
            {
                this.Size = new Size(Cursor.Position.X - this.Location.X, Cursor.Position.Y - this.Location.Y);
            }

            else if (movingCornerBottomLeft)
            {
                this.Width = ((this.Width + this.Location.X) - Cursor.Position.X);
                this.Height = (Cursor.Position.Y - this.Location.Y);
                this.Location = new Point(Cursor.Position.X, this.Location.Y);
            }
        }

        private void stopResizer()
        {
            movingRight = false;
            movingLeft = false;
            movingTop = false;
            movingBottom = false;
            movingCornerTopRight = false;
            movingCornerTopLeft = false;
            movingCornerBottomRight = false;
            movingCornerBottomLeft = false;
            this.Cursor = Cursors.Default;
            System.Threading.Thread.Sleep(300);
            on_MinimumSize = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (onBorderRight) { movingRight = true; } else { movingRight = false; }
                if (onBorderLeft) { movingLeft = true; } else { movingLeft = false; }
                if (onBorderTop) { movingTop = true; } else { movingTop = false; }
                if (onBorderBottom) { movingBottom = true; } else { movingBottom = false; }
                if (onCornerTopRight) { movingCornerTopRight = true; } else { movingCornerTopRight = false; }
                if (onCornerTopLeft) { movingCornerTopLeft = true; } else { movingCornerTopLeft = false; }
                if (onCornerBottomRight) { movingCornerBottomRight = true; } else { movingCornerBottomRight = false; }
                if (onCornerBottomLeft) { movingCornerBottomLeft = true; } else { movingCornerBottomLeft = false; }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            stopResizer();
            Redraw_Controls();
        }

        private void Big_Photo_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void INFO_BUT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BYX ALPHA is a new 32-bit image format, especially designed for enhancing the UX-UI mobile interfaces. BYX ALPHA combines the lossless archiving requirements and the lossy compression flexibility, offering better resolution for much smaller files sizes."+Environment.NewLine+ "Invented by Marc Gervais, powered by Techniswiss and in partnership with Guyenne Papier SAS, BYX ALPHA is a true novel and unique class of archiving tools." + Environment.NewLine + "The innovative BYX ALPHA proprietary technology is targeting hybrid file schemes combining lossless and near-lossless methods depending on individual file patterns, delivering a quality difference with the source that cannot be perceived, and resulting in file size reduction from 23% to 98% compared to existing products.");
        }

        private void Drag_Area_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen1 = new Pen(SystemColors.GrayText, 0.5f);
            if(screen2.Visible) g.DrawLine(pen1, new Point(0, Drag_Area.Height - 2), new Point(this.Width, Drag_Area.Height - 2)); 
        }

        private void screen2_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;

        }

        private void Drag_Area_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drag = true;
                posX = Cursor.Position.X - this.Left;
                posY = Cursor.Position.Y - this.Top;

            }
        }

        private void Drag_Area_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                this.Top = System.Windows.Forms.Cursor.Position.Y - posY;
                this.Left = System.Windows.Forms.Cursor.Position.X - posX;
            }
            this.Cursor = Cursors.Default;

        }

        private void big_Photo_2_Click(object sender, EventArgs e)
        {
            int height = screen2.Height;
            int width = screen2.Width;
            Point mouse_pos = new Point(Cursor.Position.X, Cursor.Position.Y);
            if (ico == true || svg== true)
            {
                //browse button
                int browse_button_x = (int)(0.1832 * width) + this.Left;
                int browse_button_y = (int)(0.6638 * height) + screen2.Location.Y + this.Top;
                int browse_button_width = (int)(0.0900 * width);
                int browse_button_height = (int)(0.0598 * height);
                Rectangle browse_button = new Rectangle(browse_button_x, browse_button_y, browse_button_width, browse_button_height);
                if (browse_button.Contains(mouse_pos)) openFileDialog1.ShowDialog();

                //OK button
                int OK_button_x = (int)(0.1106 * width) + this.Left;
                int OK_button_y = (int)(0.8461 * height) + screen2.Location.Y + this.Top;
                int OK_button_width = (int)(0.0572 * width);
                int OK_button_height = (int)(0.0982 * height);
                Rectangle OK_button = new Rectangle(OK_button_x, OK_button_y, OK_button_width, OK_button_height);
                if (OK_button.Contains(mouse_pos))
                    OK_BUT_Click(null, null);
                //openFileDialog1.ShowDialog();
                //Cancel Button
                int Cancel_button_x = (int)(0.1793 * width) + this.Left;
                int Cancel_button_y = (int)(0.8461 * height) + screen2.Location.Y + this.Top;
                int Cancel_button_width = (int)(0.0572 * width);
                int Cancel_button_height = (int)(0.0982 * height);
                Rectangle Cancel_button = new Rectangle(Cancel_button_x, Cancel_button_y, Cancel_button_width, Cancel_button_height);
                if (Cancel_button.Contains(mouse_pos))
                    Cancel_BUT_Click(null, null);
                //R1 Button
                int R1_button_x = (int)(0.8526 * width) + this.Left;
                int R1_button_y = (int)(0.4173 * height) + screen2.Location.Y + this.Top;
                int R1_button_width = (int)(0.0610 * width);
                int R1_button_height = (int)(0.1196 * height);
                Rectangle R1_button = new Rectangle(R1_button_x, R1_button_y, R1_button_width, R1_button_height);
                if (R1_button.Contains(mouse_pos))
                {
                    if (ico == true)
                    {
                        Cancel_BUT_Click(null, null);
                        svg = true;
                        ico = false;
                        Redraw_Controls();
                    }
                    else
                    {
                        Cancel_BUT_Click(null, null);
                        svg = false;
                        ico = true;
                        Redraw_Controls();
                    }
                }
                //R2 Button
                int R2_button_x = (int)(0.9259 * width) + this.Left;
                int R2_button_y = (int)(0.4173 * height) + screen2.Location.Y + this.Top;
                int R2_button_width = (int)(0.0610 * width);
                int R2_button_height = (int)(0.1196 * height);
                Rectangle R2_button = new Rectangle(R2_button_x, R2_button_y, R2_button_width, R2_button_height);
                if (R2_button.Contains(mouse_pos))
                {
                    Cancel_BUT_Click(null, null);
                    svg = false;
                    ico = false;
                    png = true;
                    Redraw_Controls();
                }

            } 
            else
            {
                int browse_button_x = (int)(0.2909 * width) + this.Left;
                int browse_button_y = (int)(0.6642 * height) + screen2.Location.Y + this.Top;
                int browse_button_width = (int)(0.0900 * width);
                int browse_button_height = (int)(0.0598 * height);
                Rectangle browse_button = new Rectangle(browse_button_x, browse_button_y, browse_button_width, browse_button_height);
                if (browse_button.Contains(mouse_pos)) openFileDialog1.ShowDialog();

                //OK button
                int OK_button_x = (int)(0.2166 * width) + this.Left;
                int OK_button_y = (int)(0.8507 * height) + screen2.Location.Y + this.Top;
                int OK_button_width = (int)(0.0574 * width);
                int OK_button_height = (int)(0.0989 * height);
                Rectangle OK_button = new Rectangle(OK_button_x, OK_button_y, OK_button_width, OK_button_height);
                if (OK_button.Contains(mouse_pos))
                    OK_BUT_Click(null, null);
                //openFileDialog1.ShowDialog();
                //Cancel Button
                int Cancel_button_x = (int)(0.2856 * width) + this.Left;
                int Cancel_button_y = (int)(0.8507 * height) + screen2.Location.Y + this.Top;
                int Cancel_button_width = (int)(0.0574 * width);
                int Cancel_button_height = (int)(0.0989 * height);
                Rectangle Cancel_button = new Rectangle(Cancel_button_x, Cancel_button_y, Cancel_button_width, Cancel_button_height);
                if (Cancel_button.Contains(mouse_pos))
                    Cancel_BUT_Click(null, null);
                //R1 Button
                int R1_button_x = (int)(0.8537 * width) + this.Left;
                int R1_button_y = (int)(0.4189 * height) + screen2.Location.Y + this.Top;
                int R1_button_width = (int)(0.0612 * width);
                int R1_button_height = (int)(0.1205 * height);
                Rectangle R1_button = new Rectangle(R1_button_x, R1_button_y, R1_button_width, R1_button_height);
                if (R1_button.Contains(mouse_pos))
                {
                    Cancel_BUT_Click(null, null);
                    svg = false;
                    ico = true;
                    png = false;
                    Redraw_Controls();
                }
                //R2 Button
                int R2_button_x = (int)(0.9280 * width) + this.Left;
                int R2_button_y = (int)(0.4189 * height) + screen2.Location.Y + this.Top;
                int R2_button_width = (int)(0.0612 * width);
                int R2_button_height = (int)(0.1205 * height);
                Rectangle R2_button = new Rectangle(R2_button_x, R2_button_y, R2_button_width, R2_button_height);
                if (R2_button.Contains(mouse_pos))
                {
                    Cancel_BUT_Click(null, null);
                    svg = true;
                    ico = false;
                    png = false;
                    Redraw_Controls();
                }
            }
        }

        protected virtual bool IsFileLocked(FileInfo file)
        {
            FileStream stream = null;

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None);
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }

            //file is not locked
            return false;
        }

        private void OK_BUT_Click(object sender, EventArgs e)
        {
            if ((ico==true && Filename_textbox.Text.Contains(".ico")) || (png == true && Filename_textbox.Text.Contains(".png")) || (svg == true && Filename_textbox.Text.Contains(".svg")))
            {
                
                IconImage image;
                MultiIcon multi, multi2;
                int index_max=0;

                //get original file size
                nr_of_frames = 0;
                try
                {
                    IMG1.Image = null;
                    IMG2.Image = null;
                    Drop1.Image = null;



                    //creating new filenames
                    
                    new_filename = Filename_textbox.Text;
                    new_filename = new_filename.Split('\\')[new_filename.Split('\\').Length - 1];
                    new_filename = new_filename.Insert((new_filename.LastIndexOf(".")), "1");
                    new_filename = "\""+Path.GetTempPath() + new_filename+ "\"";
                    new_filename2 = new_filename.Replace('1', '2');
                    png_temp_filename = "\"" + Path.GetTempPath() + "temp_conversion.png\"";
                    png_temp_filename1 = "\"" + Path.GetTempPath() + "temp_conversion.png\"";
                    
                    string byx_filename = "\"" + Path.GetTempPath() + "temp.byx\"";
                    string filename_ico = Path.GetTempPath() + "first.ico";
                    //display original image into the first textbox
                    Image i = null;
                    int highest_res = 0;
                    int highest_ind = 0;
                    if (Filename_textbox.Text.Contains(".svg"))
                    {
                        //svg file
                        SvgDocument svgDoc = SvgDocument.Open(Filename_textbox.Text);
                        i = svgDoc.Draw();
                        
                    }
                    else
                    {
                        if(Filename_textbox.Text.Contains(".png"))
                            //png file

                            i = Image.FromFile(Filename_textbox.Text);
                        else
                        {
                            if (Filename_textbox.Text.Contains(".ico"))
                            {
                                multi = new MultiIcon();
                                multi.SelectedIndex = -1;
                                multi.Load(Filename_textbox.Text);
                                index_max = 0;
                                int res_max = 0;
                                for (int u=0; u<multi[0].Count;u++)
                                {
                                    if(multi[0][u].Image.Width* multi[0][u].Image.Height>res_max)
                                    {
                                        res_max = multi[0][u].Image.Width * multi[0][u].Image.Height;
                                        index_max = u;
                                    }
                                }
                                multi.SelectedIndex = 0;
                                image = multi[0][index_max];

                                i = image.Image;
                                i.Save(filename_ico, System.Drawing.Imaging.ImageFormat.Icon);
                            }
                        }
                    }
                    FileInfo f;
                    if (Filename_textbox.Text.Contains(".ico"))
                        f = new FileInfo(filename_ico);
                    else
                        f = new FileInfo(Filename_textbox.Text);
                    
                    float size = ((float)f.Length / 1024);
                    label1.Text = size.ToString("0.00");

                    Drop1.Image = i;

                    //display original image size
                    //label2.Text = i.Width + "x" + i.Height;
                    
                    Image i1;
                    Image i2;
                    //IMG1 picturebox = byx image, IMG2 picturebox= png image
                    
                    Stopwatch stopwatch = new Stopwatch();
                    Stopwatch stopwatch1 = new Stopwatch();
                    Stopwatch stopwatch2 = new Stopwatch();
                    Stopwatch stopwatch3 = new Stopwatch();

                    //convert original image to png creating the file temp_conversion.png
                    stopwatch2.Start();
                    Process cmd2 = new Process();
                    cmd2.StartInfo.FileName = "test_imagemagick.exe";
                    cmd2.StartInfo.RedirectStandardOutput = true;
                    cmd2.StartInfo.RedirectStandardInput = true;
                    cmd2.StartInfo.CreateNoWindow = true;
                    cmd2.StartInfo.UseShellExecute = false;
                    string result = Path.GetTempPath();
                    cmd2.StartInfo.Arguments = "\""+Filename_textbox.Text +"\" "+ png_temp_filename;
                    if(Filename_textbox.Text.Contains(".ico"))
                        cmd2.StartInfo.Arguments = "\"" + filename_ico + "\" " + png_temp_filename;

                    cmd2.Start();
                    cmd2.StandardInput.Flush();
                    cmd2.StandardInput.Close();
                    cmd2.WaitForExit();
                    stopwatch2.Stop();
                    textBox1.AppendText(cmd2.StartInfo.FileName + " " + cmd2.StartInfo.Arguments + Environment.NewLine);
                    textBox1.AppendText(cmd2.StandardOutput.ReadToEnd());
                    Thread.Sleep(200);

                    textBox1.AppendText("png temp filename="+ png_temp_filename+Environment.NewLine);
                    
                    if (IsFileLocked(new FileInfo(png_temp_filename.Replace("\"","")))) Thread.Sleep(500);
                    if (IsFileLocked(new FileInfo(png_temp_filename.Replace("\"","")))) Thread.Sleep(500);

                    //get the largest file and display it in the png case
                    highest_ind = 0;
                    highest_res = 0;
                    /*if (Filename_textbox.Text.Contains(".ico"))
                    {
                        png_temp_filename = png_temp_filename.Insert(png_temp_filename.Length - 5, "-" + index_max.ToString());
                    }*/
                    //convert temp_conversion.png back to the original format
                    stopwatch3.Start();
                    Process cmd3 = new Process();
                    cmd3.StartInfo.FileName = "test_imagemagick.exe";
                    cmd3.StartInfo.RedirectStandardOutput = true;
                    cmd3.StartInfo.RedirectStandardInput = true;
                    cmd3.StartInfo.CreateNoWindow = true;
                    cmd3.StartInfo.UseShellExecute = false;
                    if(ico!=true)
                        cmd3.StartInfo.Arguments = png_temp_filename+ " " + new_filename;
                    else
                        cmd3.StartInfo.Arguments = png_temp_filename + " -define icon:auto-resize=\"256\" " + new_filename;
                    cmd3.Start();
                    cmd3.StandardInput.Flush();
                    cmd3.StandardInput.Close();
                    cmd3.WaitForExit();
                    stopwatch3.Stop();
                    textBox1.AppendText(cmd3.StandardOutput.ReadToEnd());
                    textBox1.AppendText(cmd3.StartInfo.FileName + " " + cmd3.StartInfo.Arguments + Environment.NewLine);
                    Thread.Sleep(200);
                    if (IsFileLocked(new FileInfo(new_filename.Replace("\"", "")))) Thread.Sleep(500);
                    if (IsFileLocked(new FileInfo(new_filename.Replace("\"", "")))) Thread.Sleep(500);
                    i1 = new Bitmap(256,256);
                    if (Filename_textbox.Text.Contains(".png"))
                        i1 = Image.FromFile(new_filename.Replace("\"", ""));
                    else
                    if(Filename_textbox.Text.Contains(".svg"))
                    {
                        SvgDocument svgDoc = SvgDocument.Open(new_filename.Replace("\"", ""));
                        i1 = svgDoc.Draw();
                    }
                    else
                    if (Filename_textbox.Text.Contains(".ico"))
                    {
                        multi2 = new MultiIcon();
                        multi2.Load(new_filename.Replace("\"",""));
                        i1 = multi2[0][0].Image;
                    }

                    IMG2.Image = i1;

                    if (nr_of_frames > 1)
                    {
                        long elaps2 = stopwatch2.ElapsedMilliseconds;
                        long elaps3 = stopwatch3.ElapsedMilliseconds;

                        label5.Text = elaps2.ToString();
                        label6.Text = elaps3.ToString();

                    }
                    else
                    {
                        label5.Text = stopwatch2.ElapsedMilliseconds.ToString();
                        label6.Text = stopwatch3.ElapsedMilliseconds.ToString();
                    }
                    stopwatch.Reset();

                    Process cmd = new Process();
                    Process cmd1 = new Process();

                    //creating byx archive. Output is temp.byx
                    stopwatch.Start();
                    cmd.StartInfo.FileName = "byx_archiver_cmd.exe";
                    cmd.StartInfo.RedirectStandardOutput = true;
                    cmd.StartInfo.RedirectStandardInput = true;
                    cmd.StartInfo.CreateNoWindow = true;
                    cmd.StartInfo.UseShellExecute = false;
                    if(Filename_textbox.Text.Contains(".ico"))
                        cmd.StartInfo.Arguments = "-i \"" + filename_ico + "\" -o " + byx_filename;
                    else
                        cmd.StartInfo.Arguments = "-i \""+ Filename_textbox.Text + "\" -o " + byx_filename;
                    cmd.Start();
                    cmd.StandardInput.Flush();
                    cmd.StandardInput.Close();
                    cmd.WaitForExit();
                    stopwatch.Stop();
                    textBox1.AppendText(cmd.StartInfo.FileName + " " + cmd.StartInfo.Arguments + Environment.NewLine);
                    textBox1.AppendText(cmd.StandardOutput.ReadToEnd());
                    textBox1.AppendText("temp.byx created" + Environment.NewLine);
                    stopwatch1.Reset(); 
                    Thread.Sleep(200);
                    if (IsFileLocked(new FileInfo(byx_filename.Replace("\"", "")))) Thread.Sleep(500);
                    if (IsFileLocked(new FileInfo(byx_filename.Replace("\"", "")))) Thread.Sleep(500);

                    Thread.Sleep(200);
                    
                    //Creating the file back from temp.byx
                    stopwatch1.Start();
                    cmd1.StartInfo.FileName = "byx_archiver_cmd.exe";
                    cmd1.StartInfo.RedirectStandardInput = true;
                    cmd1.StartInfo.RedirectStandardOutput = true;
                    cmd1.StartInfo.CreateNoWindow = true;
                    cmd1.StartInfo.UseShellExecute = false;
                    cmd1.StartInfo.Arguments = "-i " + byx_filename + " -o " + new_filename2;
                    cmd1.Start();
                    cmd1.StandardInput.Flush();
                    cmd1.StandardInput.Close();
                    cmd1.WaitForExit();
                    stopwatch1.Stop();
                    textBox1.AppendText(cmd1.StartInfo.FileName + " " + cmd1.StartInfo.Arguments + Environment.NewLine);
                    textBox1.AppendText(cmd1.StandardOutput.ReadToEnd() + Environment.NewLine);
                    textBox1.AppendText(new_filename2 + " Created" + Environment.NewLine);
                    if (IsFileLocked(new FileInfo(new_filename2.Replace("\"", "")))) Thread.Sleep(500);
                    if (IsFileLocked(new FileInfo(new_filename2.Replace("\"", "")))) Thread.Sleep(500);

                    Thread.Sleep(200);

                    //desarchived from BYX image
                    if (Filename_textbox.Text.Contains(".svg"))
                    {

                        SvgDocument svgDoc = SvgDocument.Open(new_filename2.Replace("\"", ""));
                        i2 = svgDoc.Draw();
                    }
                    else
                    {
                        if (Filename_textbox.Text.Contains(".ico"))
                         {
                            Stream iconStream = new FileStream(new_filename2.Replace("\"", ""), FileMode.Open);

                            IconBitmapDecoder decoder = new IconBitmapDecoder(
                                    iconStream,
                                    BitmapCreateOptions.PreservePixelFormat,
                                    BitmapCacheOption.None);

                            nr_of_frames = decoder.Frames.Count;
                            highest_res = decoder.Frames[0].PixelWidth * decoder.Frames[0].PixelHeight;
                            highest_ind = 0;
                            for (int j = 0; j < nr_of_frames; j++)
                            {
                                if (decoder.Frames[j].PixelWidth * decoder.Frames[j].PixelHeight > highest_res)
                                {
                                    highest_res = decoder.Frames[j].PixelWidth * decoder.Frames[j].PixelHeight;
                                    highest_ind = j;
                                }
                            }
                            iconStream.Dispose();

                            i2 = Bitmap.FromHicon(new Icon(Filename_textbox.Text, new Size(decoder.Frames[highest_ind].PixelWidth, decoder.Frames[highest_ind].PixelHeight)).Handle);

                        }
                        else
                            i2 = Image.FromFile(new_filename2.Replace("\"", ""));
                    }
                    IMG1.Image = i2;

                    //temp_conversion file info
                    FileInfo f1;
                    float size_png=0;
                    f1 = new FileInfo(png_temp_filename.Replace("\"", ""));
                    size_png = ((float)f1.Length / 1024);
                    label2.Text = size_png.ToString("0.00");

                    //desarchived from byx image file info
                    FileInfo f2 = new FileInfo(byx_filename.Replace("\"", ""));
                    float size_byx = ((float)f2.Length / 1024);
                    label3.Text = size_byx.ToString("0.00");

                    float png_ratio2;
                    if (ico == true || svg == true)
                        png_ratio2 = (size_byx / size_png) * 100;
                    else
                        png_ratio2 = size_byx / size*100;

                   
                    label4.Text = png_ratio2.ToString("0.00");

                    label7.Text = stopwatch.ElapsedMilliseconds.ToString();
                    label8.Text = stopwatch1.ElapsedMilliseconds.ToString();



                    cmd.Dispose();
                    cmd1.Dispose();
                    cmd2.Dispose();
                    cmd3.Dispose();
                   
                }
                catch (Exception ex)
                {
                    textBox1.AppendText((ex.ToString())+Environment.NewLine);
                    
                }

            }
            else
                MessageBox.Show("Please select an appropiate file");

        }

        private void Drag_Area_MouseUp_1(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Filename_textbox.Text = openFileDialog1.FileName;
        }

        private void big_Photo_2_DragDrop(object sender, DragEventArgs e)
        {
           }

        private void big_Photo_2_DragOver(object sender, DragEventArgs e)
        {
        }

        private void screen2_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Count() > 0) Filename_textbox.Text = files[0];
            OK_BUT_Click(null, null);
        }

        private void Cancel_BUT_Click(object sender, EventArgs e)
        {
            IMG1.Visible = false;
            IMG2.Visible = false;
            ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Drop1.Image = ((Image)(resources.GetObject("Drop1.Image")));
            Filename_textbox.Text = "";
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";

        }

        private void IMG2_Click(object sender, EventArgs e)
        {
            if(new_filename!=null)
                Process.Start(new_filename.Replace("\"", ""));
        }

        private void IMG1_Click(object sender, EventArgs e)
        {
            if (new_filename2 != null)
                Process.Start(new_filename2.Replace("\"", ""));
        }
        private void Drop1_click(object sender, EventArgs e)
        {
            if(Filename_textbox.Text != null)
                Process.Start(Filename_textbox.Text);
        }

        private void screen15_Click(object sender, EventArgs e)
        {
            int button_W = (int)(0.0794* this.Width);
            int button_H = (int)(0.1485 * this.Height);
            int button_X_Ico = (int)(0.7273 * this.Width) + this.Left;
            int button_X_Png = (int)(0.9228 * this.Width) + this.Left;
            int button_X_Svg = (int)(0.8269 * this.Width) + this.Left;

            int button_Y = (int)(0.7771 * this.Height) + this.Top;
            int cursor_X = Cursor.Position.X;
            int cursor_Y = Cursor.Position.Y;
            if ((button_X_Ico < cursor_X) & (cursor_X < (button_X_Ico + button_W)))
                if ((button_Y < cursor_Y) & (cursor_Y < (button_Y + button_H)))
                {
                    screen15.Visible = false;
                    
                    ico = true;
                    svg = false;
                    png = false;
                    Redraw_Controls();
                
                }
            if ((button_X_Png < cursor_X) & (cursor_X < (button_X_Png + button_W)))
                if ((button_Y < cursor_Y) & (cursor_Y < (button_Y + button_H)))
                {
                    screen15.Visible = false;
                    Logo.Image = BYX_Alpha.Properties.Resources.p3logo1;
                    INFO_BUT.BackgroundImage = BYX_Alpha.Properties.Resources.p3info1;
                    Drag_Area.BackColor = Color.FromName("ButtonHighlight");
                    screen2.Visible = true;
                    screen2.Location = new Point((int)(borderSpace), (int)(0.074 * this.Height + borderSpace));
                    screen2.Size = new Size((int)(this.Width) - 2 * borderSpace, (int)(0.925 * this.Height - 2 * borderSpace));
                    big_Photo_2.Image = BYX_Alpha.Properties.Resources.Slide3_PNG5;
                    ico = false;
                    svg = false;
                    png = true;
                    Redraw_Controls();
                    Drag_Area.Invalidate();
                }
            if ((button_X_Svg < cursor_X) & (cursor_X < (button_X_Svg + button_W)))
                if ((button_Y < cursor_Y) & (cursor_Y < (button_Y + button_H)))
                {
                    ico = false;
                    svg = true;
                    png = false;
                    Redraw_Controls();
                }
        }
    }
}
