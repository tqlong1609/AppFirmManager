using ManagerCinema.BSLayer;
using ManagerCinema.ObjectFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCinema
{
    public partial class FmAddMovie : FormMain
    {
        // path load image
        string path;
        MovieBS movieBS;

        public FmAddMovie()
        {
            InitializeComponent();
        }

        private void FmAddMovie_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownForm(e, this);
        }

        private void FmAddMovie_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMoveForm(e, this);
        }

        private void FmAddMovie_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUpForm(this);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int id = CommonFunction.getIdForInsert(movieBS.loadData());
            string codeImage = CommonFunction.converImgToString(path);
            bool isSuccess = movieBS.addMovies(id,txtName.Text,int.Parse(txtTime.Text),txtDirector.Text,txtCountry.Text,txtProducer.Text,
                cbxType.selectedValue,txtActor.Text,dpkDateShowing.Value.ToLongDateString(),
                rtxtContent.Text,txtTimeStart.Text,int.Parse(txtPrice.Text), codeImage);
            if (isSuccess)
            {
                MessageBox.Show("Success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinScreen_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pbxImage.Image = Image.FromFile(fileDialog.FileName);
                path = fileDialog.FileName;
            }
        }

        private void FmAddMovie_Load(object sender, EventArgs e)
        {
            movieBS = new MovieBS();
        }
    }
}
