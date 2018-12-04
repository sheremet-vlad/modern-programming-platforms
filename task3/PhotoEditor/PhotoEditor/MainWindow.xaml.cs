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

        private void ResizeButton_Click(object sender, EventArgs e)
        {
            Bitmap image = ConvertToBitmap(PictureBox1.Source as BitmapSource);
            double scale = double.Parse(scaleField.Text);

            image = imageOperation.Resize(image, scale);
            PictureBox1.Source = BitmapToImageSource(image);
        }


        private void ToGrayScale_Click(object sender, EventArgs e)
        {
            Bitmap image = ConvertToBitmap(PictureBox1.Source as BitmapSource);
            image = imageOperation.ToGrayscale(image);
            PictureBox1.Source = BitmapToImageSource(image);
        }


        private void ContrastButton_Click(object sender, EventArgs e)
        {
            int brightness = (int)BrightnessBar.Value;
            int contrast = (int)ContrastBar.Value;

            Bitmap image = ConvertToBitmap(PictureBox1.Source as BitmapSource);

            image = imageOperation.ChangeAttributes(image, brightness, contrast);

            PictureBox1.Source = BitmapToImageSource(image);
        }
}
