using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dragAndDrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Panel main;


        private void Form1_Load(object sender, EventArgs e)
        {
            main = new Panel();
            main.Parent = this;
            main.Size = new Size(550, 250);
            main.BackColor = Color.Red;
            panel1.Parent = main;
            panel2.Parent = main;
            panel1.Location = new Point(10, 5);
            
        }
        private void main_dragEnter(object sender, DragEventArgs e)
        {
            main.BackColor = Color.Bisque;
        }

        private void picB1_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                if (picB1.Image != null)
                {
                    picB1.DoDragDrop(picB1.Image, DragDropEffects.Move);
                }
            }
        }

        private void panel2_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }

        private void panel2_DragDrop(object sender, DragEventArgs e)
        {
            picB2.Image= (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            picB1.Image = null;
        }

        private void picB2_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button== MouseButtons.Left && picB2.Image != null)
            {
                picB2.DoDragDrop(picB2.Image, DragDropEffects.Move);
            }
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Move;
            else e.Effect = DragDropEffects.None;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            picB1.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            picB2.Image = null;
        }
    }
}
