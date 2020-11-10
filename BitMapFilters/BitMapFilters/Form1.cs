using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitMapFilters
{
    public partial class BitMapFilersForm : Form
    {
        public BitMapFilersForm()
        {
            InitializeComponent();
        }
        OpenFileDialog openFileDialog;
        Bitmap image, logo;
        List<IFilter> filters;
        ChangeImage changeImage;
        string imagePath;
        string logoPath;
        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;
                image = new Bitmap(imagePath);
                MainImagePB.SizeMode = PictureBoxSizeMode.StretchImage;
                MainImagePB.Image = image;
                filters = new List<IFilter>();
                filters.Add(new Negative(image));
                filters.Add(new BlackAndWhite(image));
                filters.Add(new ShadesOfGray(image));
                filters.Add(new ReflectGor(image));
                filters.Add(new ReflectVert(image));
                filters.Add(new RedOnly(image));
                ApplyFiltersTB.Maximum = filters.Count - 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            changeImage = new ChangeImage(MainImagePB);
            openFileDialog = new OpenFileDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (filters != null)
            {
                openFileDialog.ShowDialog();
                logoPath = openFileDialog.FileName;
                logo = new Bitmap(logoPath);
                LogoPB.SizeMode = PictureBoxSizeMode.StretchImage;
                LogoPB.Image = logo;
                filters.Add(new InsertLogo(image, logo));
                ApplyFiltersTB.Maximum = filters.Count - 1;
            }
            else
                MessageBox.Show("Сначала выберите основное изображение. Для этого нажмите на кнопку..");

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if(filters == null)
            {
                MessageBox.Show("Выберите изображение");
                ApplyFiltersTB.Value = ApplyFiltersTB.Minimum;
            }
            else 
                changeImage.applyFilter(filters[ApplyFiltersTB.Value]);
            
        }
    }
}