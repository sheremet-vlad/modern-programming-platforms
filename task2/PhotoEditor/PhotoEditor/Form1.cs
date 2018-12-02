using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging.Filters;

namespace PhotoEditor
{
    public partial class Form1 : Form
    {
        private ImageOperation imageOperation;

        public Form1()
        {
            InitializeComponent();
            imageOperation = new ImageOperation();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    PictureBox1.Image = new Bitmap(ofd.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RotateButton_Click(object sender, EventArgs e)
        {
            Image image = PictureBox1.Image;
            int angle = int.Parse(angleField.Text);

            image = imageOperation.RotateImage(image, angle);
            PictureBox1.Image = image;
        }

        

        private void angleField_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void ResizeButton_Click(object sender, EventArgs e)
        {
            Image image = PictureBox1.Image;
            double scale= double.Parse(scaleField.Text);

            image = imageOperation.Resize(image, scale);
            PictureBox1.Image = image;
        }


        private void ToGrayScale_Click(object sender, EventArgs e)
        {
            Image image = PictureBox1.Image;
            image = imageOperation.ToGrayscale(image);
            PictureBox1.Image = image;
        }


        private void ContrastButton_Click(object sender, EventArgs e)
        {
            int brightness = BrightnessBar.Value;
            int contrast = ContrastBar.Value;

            Image image = PictureBox1.Image;
            Bitmap bitmap = new Bitmap(PictureBox1.Image);

            image = imageOperation.ChangeAttributes(bitmap, brightness, contrast);

            PictureBox1.Image = image;
        }

        List<Point> list = new List<Point>();
        bool flag = false;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {   
            if (DrawCheckBox.Checked)
            {
                if (flag)
                {
                    list.Add(new Point(e.X, e.Y));
                    Graphics g = PictureBox1.CreateGraphics();

                    g.DrawLines(new Pen(Color.Red, 3), list.ToArray());
                }
                else
                {
                    list.Add(new Point(e.X, e.Y));
                    flag = true;
                }
            }            
        }
    }
}