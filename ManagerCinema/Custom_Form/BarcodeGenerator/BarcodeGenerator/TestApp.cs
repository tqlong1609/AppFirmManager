using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace BarcodeLibTest
{
    public partial class TestApp : Form
    {
        BarcodeLib.Barcode b = new BarcodeLib.Barcode();

        public TestApp()
        {
            InitializeComponent();
            btnSave.Enabled = false;
            btn_Save_Info.Enabled = false;
        }

        private void TestApp_Load(object sender, EventArgs e)
        {
        }


        private void btnEncode_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            btnSave.Enabled = true;
            btn_Save_Info.Enabled = true;
            try
            {
                barcode.Image = b.Encode(BarcodeLib.TYPE.CODE39, txtData.Text.Trim(), b.ForeColor, b.BackColor, 300, 150, BarcodeLib.AlignmentPositions.CENTER, RotateFlipType.RotateNoneFlipNone, chkGenerateLabel.Checked, BarcodeLib.LabelPositions.BOTTOMCENTER);
                barcode.Width = barcode.Image.Width;
                barcode.Height = barcode.Image.Height;
                barcode.Location = new Point((groupBox2.Location.X + groupBox2.Width / 2) - barcode.Width / 2, (groupBox2.Location.Y + groupBox2.Height / 2) - barcode.Height / 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "BMP (*.bmp)|*.bmp|GIF (*.gif)|*.gif|JPG (*.jpg)|*.jpg|PNG (*.png)|*.png|TIFF (*.tif)|*.tif";
            sfd.FilterIndex = 3;
            sfd.AddExtension = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //BarcodeLib.SaveTypes savetype = BarcodeLib.SaveTypes.UNSPECIFIED;
                ImageFormat savetype = ImageFormat.Jpeg;
                switch (sfd.FilterIndex)
                {
                    case 1: /* BMP */  savetype = ImageFormat.Bmp; break;
                    case 2: /* GIF */  savetype = ImageFormat.Gif; break;
                    case 3: /* JPG */  savetype = ImageFormat.Jpeg; break;
                    case 4: /* PNG */  savetype = ImageFormat.Png; break;
                    case 5: /* TIFF */ savetype = ImageFormat.Tiff; break;
                    default: break;
                }
                barcode.Image.Save(sfd.FileName, savetype);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thêm dữ liệu vào SQL từ Button này !");
        }

        private void TxtWidth_TextChanged(object sender, EventArgs e)
        {

        }
    }
}