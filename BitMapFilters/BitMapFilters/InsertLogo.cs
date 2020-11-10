using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitMapFilters
{
    class InsertLogo: IFilter
    {
        private Bitmap _oldImage;
        private Bitmap _newImage;
        private Bitmap _logo;

        public InsertLogo(Bitmap image, Bitmap logo)
        {
            _oldImage = image;
            _logo = logo;
        }
        public Bitmap Apply()
        {
            Color pixel;
            int height = _oldImage.Height;
            int width = _oldImage.Width;

            int hLogo = _logo.Height;
            int wLogo = _logo.Width;

            _newImage = new Bitmap(width, height);

            for (int h = 0; h < height; h++)
                for (int w = 0; w < width; w++)
                {
                    if (h<hLogo&&w<wLogo)
                        pixel = _logo.GetPixel(w, h);
                    else
                        pixel = _oldImage.GetPixel(w, h);
                    _newImage.SetPixel(w, h, pixel);
                }
            return _newImage;
        }
        public void newLogo(Bitmap logo)
        {
            _logo = logo;
        }

        public Bitmap Cancel()
        {
            return _oldImage;
        }

        public void changeImage(Bitmap image)
        {
            _oldImage = image;
        }
    }
}
