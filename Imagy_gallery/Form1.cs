using System;
using System.Windows.Forms;

namespace Imagy_gallery
{
    public partial class Form1 : Form
    {
        int currentIndex = 0;

        private readonly object[] images =
        {
            Properties.Resources._1,
            Properties.Resources._2,
            Properties.Resources._3,
            Properties.Resources._4
        };
        public Form1()
        {
            InitializeComponent();
            ShowImage();
        }

        private void buttonNext(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex > images.Length - 1) currentIndex = 0;
            ShowImage();
        }

        private void buttonBack(object sender, EventArgs e)
        {
            currentIndex--;
            if (currentIndex < 0) currentIndex = images.Length - 1;
            ShowImage();
        }
        private void ShowImage()
        {
            pictureBox1.Image = (System.Drawing.Image)images[currentIndex];
        }
    }
}
