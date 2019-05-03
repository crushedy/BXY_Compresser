using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BYX_Archiver
{
    public partial class Form1 : Form
    {
        public int posX;
        public int posY;
        public bool drag;
        public bool maximized;

        public Form1()
        {

            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            char c = (char)240; 
            MAX_BUT.Text = c.ToString();
            Redraw_Controls();
            maximized = false;
            drag = false;
        }

        private void Redraw_Controls()
        {
            int width = this.Width;
            int height = this.Height;

            Logo.Size = new Size((int)(0.136 * width), (int)(0.053 * height));
            Logo.Location = new Point((int)(0.019 * width), (int)(0.016 * height));

            Big_Photo.Size = new Size((int)(width), (int)(0.925 * height));
            Big_Photo.Location = new Point((int)(0), (int)(0.074 * height));

            INFO_BUT.Size = new Size((int)(0.023 * width), (int)(0.036 * height));
            INFO_BUT.Location = new Point((int)(0.8943 * width), (int)(0.024 * height));

            MIN_BUT.Size = new Size((int)(0.023 * width), (int)(0.036 * height));
            MIN_BUT.Location = new Point((int)(0.9220 * width), (int)(0.024 * height));

            MAX_BUT.Size = new Size((int)(0.023 * width), (int)(0.036 * height));
            MAX_BUT.Location = new Point((int)(0.9454 * width), (int)(0.024 * height));

            CLOSE_APP_BUT.Size = new Size((int)(0.023 * width), (int)(0.036 * height));
            CLOSE_APP_BUT.Location = new Point((int)(0.9679 * width), (int)(0.024 * height));

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

        private void Drag_Area_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drag = true;
                posX = Cursor.Position.X - this.Left;
                posY = Cursor.Position.Y - this.Top;

            }
        }

        private void Drag_Area_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
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

        private void timer1_Tick(object sender, EventArgs e)
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
                maximized = false;
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                maximized = true;
                this.Location = new Point(0, 0);
                int screen_width = Screen.PrimaryScreen.WorkingArea.Width;
                int screen_height = Screen.PrimaryScreen.WorkingArea.Height;
                if(screen_width/screen_height >=1.54)
                {
                    this.Height = screen_height;
                    this.Width = (int)(this.Height * 1.54);
                    Redraw_Controls();
                    MessageBox.Show("ss");
                } else
                {
                    this.Width = screen_width;
                    this.Height = (int)(this.Width / 1.54);
                    MessageBox.Show("width="+screen_width + " height=" + screen_height);
                    Redraw_Controls();
                }
            }
        }

        private void Drag_Area_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (maximized)
                {
                    this.WindowState = FormWindowState.Normal;
                    maximized = false;
                }
                else
                {
                    this.WindowState = FormWindowState.Maximized;
                    maximized = true;
                }
            }
        }


    }
}
