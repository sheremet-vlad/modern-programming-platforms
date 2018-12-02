using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace PhotoEditor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ImageOperation imageOperation;

        public MainWindow()
        {
            InitializeComponent();
            imageOperation = new ImageOperation();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";

            if (ofd.ShowDialog() == true)
            {
                try
                {
                    PictureBox1.Source = new BitmapImage(new Uri(ofd.FileName));
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка");
                }
            }
        }

        private void RotateButton_Click(object sender, EventArgs e)
        {
            Bitmap image = ConvertToBitmap(PictureBox1.Source as BitmapSource);
            int angle = int.Parse(angleField.Text);

            image = imageOperation.RotateImage(image, angle);
            PictureBox1.Source = BitmapToImageSource(image);
        }



        /*private void angleField_KeyPress(object sender, KeyPressEventArgs e)
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
            double scale = double.Parse(scaleField.Text);

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
        }*/

        public static Bitmap ConvertToBitmap(BitmapSource bitmapSource)
        {
            var width = bitmapSource.PixelWidth;
            var height = bitmapSource.PixelHeight;
            var stride = width * ((bitmapSource.Format.BitsPerPixel + 7) / 8);
            var memoryBlockPointer = Marshal.AllocHGlobal(height * stride);
            bitmapSource.CopyPixels(new Int32Rect(0, 0, width, height), memoryBlockPointer, height * stride, stride);
            var bitmap = new Bitmap(width, height, stride, System.Drawing.Imaging.PixelFormat.Format32bppPArgb, memoryBlockPointer);
            return bitmap;
        }

        public ImageSource BitmapToImageSource(Bitmap bmp)
        {
            var handle = bmp.GetHbitmap();
            try
            {
                return Imaging.CreateBitmapSourceFromHBitmap(handle, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
            }
            finally { DeleteObject(handle); }
        }

        [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteObject([In] IntPtr hObject);
    }
}
