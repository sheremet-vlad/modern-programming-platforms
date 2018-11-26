using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEditor
{
    class ImageOperation
    {
        public Bitmap Resize(Image img, double scale)
        {
            int width = (int)(img.Width * scale);
            int height = (int)(img.Height * scale);
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, 0, 0, result.Width, result.Height);
                return result;
            }
        }

        public Bitmap RotateImage(Image image, float angle)
        {
            if (image == null)
            {
                throw new ArgumentNullException("image");
            }                

            PointF offset = new PointF((float)image.Width / 2, (float)image.Height / 2);
            
            Bitmap rotatedBmp = new Bitmap(image.Width, image.Height);
            rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            Graphics g = Graphics.FromImage(rotatedBmp);
            g.TranslateTransform(offset.X, offset.Y);
            g.RotateTransform(angle);
            g.TranslateTransform(-offset.X, -offset.Y);
            g.DrawImage(image, new PointF(0, 0));

            return rotatedBmp;
        }


        public Bitmap ToGrayscale(Image image)
        {
            Bitmap result = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(result))
            {
                // Grayscale matrix
                ColorMatrix colorMatrix = new ColorMatrix(new float[][]
                {
                    new float[] {.3f, .3f, .3f, 0, 0},
                    new float[] {.3f, .3f, .3f, 0, 0},
                    new float[] {.3f, .3f, .3f, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1}
                });

                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(colorMatrix);

                g.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height),
                   0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
            }

            return result;
        }

        public Bitmap ChangeAttributes(Bitmap bitmap, int brightness, int contrast)
        {
            BrightnessCorrection bfilter = new BrightnessCorrection(brightness);
            ContrastCorrection cfilter = new ContrastCorrection(contrast);

            return bfilter.Apply(cfilter.Apply(bitmap.Clone(new Rectangle(0, 0, bitmap.Width, bitmap.Height), PixelFormat.Format24bppRgb)));
        }       
    }
}
