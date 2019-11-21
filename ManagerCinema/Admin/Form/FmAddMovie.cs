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
        string idMovie;

        private bool isEdit = false;

        public FmAddMovie()
        {
            InitializeComponent();
            btnSave.ButtonText = "Add";
        }

        public FmAddMovie(string idMovie)
        {
            InitializeComponent();
            isEdit = true;
            this.idMovie = idMovie;
            btnSave.ButtonText = "Edit";
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
            int time;
            int price;
            try
            {
                time = int.Parse(txtTime.Text);
                price = int.Parse(txtPrice.Text);
            }
            catch
            {
                MessageBox.Show("value time or price not accept", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (checkNotValue())
            {
                int id = CommonFunction.getIdOnTime();
                string codeImage = CommonFunction.converImgToString(path);
                if (isEdit) {
                    if(movieBS.editMovie(idMovie, txtName.Text, time, txtDirector.Text, txtCountry.Text, txtProducer.Text,
                        cbxType.selectedValue, txtActor.Text, dpkDateShowing.Value.ToLongDateString(),
                        rtxtContent.Text, price, codeImage))
                    {
                        MessageBox.Show("Edit Success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UcListMovie.isReset = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    bool isSuccess = movieBS.addMovies(id, txtName.Text, time, txtDirector.Text, txtCountry.Text, txtProducer.Text,
                        cbxType.selectedValue, txtActor.Text, dpkDateShowing.Value.ToLongDateString(),
                        rtxtContent.Text, price, codeImage);
                    if (isSuccess)
                    {
                        MessageBox.Show("Add Success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UcListMovie.isReset = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Value not empty", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private bool checkNotValue()
        {
            if (path == null || txtName.Text == "" || txtDirector.Text == "" || txtCountry.Text == "" ||
                txtProducer.Text == "" || txtActor.Text == "" || txtPrice.Text == "" ||
                txtTime.Text == "" || cbxType.selectedIndex == -1 || rtxtContent.Text == "")
            {
                return false;
            }
            return true;
        }

        private void rtxtContent_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
