using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitMapFilters
{
    class ReflectGor: IFilter
    {
        private Bitmap _oldImage;
        private Bitmap _newImage;

        public ReflectGor(Bitmap image)
        {
            _oldImage = image;
        }
        public Bitmap Apply()
        {
            Color pixel;
            int height = _oldImage.Height;
            int width = _oldImage.Width;

            _newImage = new Bitmap(width, height);

            for (int h = 0; h < height; h++)
                for (int w = 0; w < width; w++)
                {
                    pixel = _oldImage.GetPixel(w, h);
                    _newImage.SetPixel(width-1-w, h, pixel);
                }
            return _newImage;
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
