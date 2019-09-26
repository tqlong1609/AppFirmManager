using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCinema
{
    public partial class UcBackground : UserControl
    {
        private List<Image> mListImage;
        private int positionImage;

        private bool isLeft = true;

        public UcBackground()
        {
            InitializeComponent();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (checkPosition(isLeft))
            {
                positionImage--;
                pbxBackground.Image = mListImage[positionImage];
            }

        }

        // check position of image out of range list image background
        private bool checkPosition(bool _isLeft)
        {
            int temp = positionImage;
            if (_isLeft) {
                temp--; // left
            }
            else {
                temp++; // right
            }
            if (temp >= 0 && temp < mListImage.Count()) return true;
            return false;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (checkPosition(!isLeft))
            {
                positionImage++;
                pbxBackground.Image = mListImage[positionImage];
            }
        }

        private void UcBackground_Load(object sender, EventArgs e)
        {
            mListImage = new List<Image>();
            positionImage = 0;
            tChangeImage.Start();

            btnLeft.BringToFront();
            btnRight.BringToFront();
            addListImage();
            addImageToBackground();
        }

        private void addImageToBackground()
        {
            pbxBackground.Image = mListImage[positionImage];
        }

        private void addListImage()
        {
            mListImage.Add(Image.FromFile("Image//image1.jpg"));
            mListImage.Add(Image.FromFile("Image//image4.jpg"));
            mListImage.Add(Image.FromFile("Image//image3.jpg"));
        }

        private void tChangeImage_Tick(object sender, EventArgs e)
        {
            if (mListImage.Count() > 0)
            {
                if (checkPosition(!isLeft))
                {
                    positionImage++;
                    pbxBackground.Image = mListImage[positionImage];
                }
                else
                {
                    positionImage = 0;
                    pbxBackground.Image = mListImage[positionImage];
                }
            }
        }
    }
}
