using System;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using TouchlessLib;
using ZXing;
using BarcodeReaderApp.BSLayer;
namespace BarcodeReaderApp
{
    public partial class Form1 : Form
    {
        private BarcodeReader _barcodeReader;
        private TouchlessMgr _touch;
        private const int _previewWidth = 640;
        private const int _previewHeight = 480;
        public string decoded;
        private Scan_Ticket_BS Scan_Ticket;
        private Scan_Voucher_BS Scan_Voucher;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                //dlg.Filter = "bmp files (*.bmp)|*.bmp";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bitmap = null;

                    try
                    {
                        bitmap = new Bitmap(dlg.FileName);
                        button2.Enabled = true;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("File not supported.");
                        return;
                    }
                    pictureBox1.Image = new Bitmap(dlg.FileName);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please load an image!");
                return;
            }

            ReadBarcode((Bitmap)pictureBox1.Image);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string button_text = button3.Text;
            if (button_text.Equals("Start Webcam"))
            {
                button3.Text = "Stop Webcam";
                StartCamera();
                button1.Enabled = false;
                button2.Enabled = false;
            }
            else
            {
                button3.Text = "Start Webcam";
                button1.Enabled = true;
                button2.Enabled = true;
                StopCamera();
            }
        }

        private void StartCamera()
        {
            if (_touch.Cameras.Count == 0)
            {
                MessageBox.Show("No USB webcam connected");
                button3.Text = "Start Webcam";
                return;
            }
            _touch.CurrentCamera = _touch.Cameras[0];
            _touch.CurrentCamera.CaptureWidth = _previewWidth;
            _touch.CurrentCamera.CaptureWidth = _previewHeight;
            _touch.CurrentCamera.OnImageCaptured += new EventHandler<CameraEventArgs>(OnImageCaptured);
        //    btnExit.Enabled = false;
        }

        private void StopCamera()
        {
            try
            {
                button3.Text = "Start Webcam";
                if (_touch.CurrentCamera != null)
                {
                    _touch.CurrentCamera.OnImageCaptured -= new EventHandler<CameraEventArgs>(OnImageCaptured);
                    _touch.CurrentCamera.Dispose();
                    _touch.RefreshCameraList();
                    btnExit.Enabled = true;
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void OnImageCaptured(object sender, CameraEventArgs args)
        {
            Bitmap bitmap = args.Image;
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    pictureBox1.Image = bitmap;
                    ReadBarcode(bitmap);
                });
            }
            catch {
                return;  }
        }

        private void ReadBarcode(Bitmap bitmap)
        {
            try
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)pictureBox1.Image);
                decoded = "";
                if (result != null)
                {
                    textBox1.ResetText();
                    decoded = decoded + result.ToString();
                    if (decoded != "")
                    {
                        textBox1.Text = decoded;
                    }
                }
            }
            catch (Exception) { }
        }

		private void button4_Click(object sender, EventArgs e)
		{
            string ID = textBox1.Text;
            if (radioButton1.Checked == true)
            {
                Scan_Ticket = new Scan_Ticket_BS();
                string Result = Scan_Ticket.Scan_Ticket(ID);
                if (Result == "True")
                    MessageBox.Show("Thanh toán thành công !");
                else
                    MessageBox.Show("Vé không tồn tại !");
            }
            else
            {
                Scan_Voucher = new Scan_Voucher_BS();
                string Result = Scan_Voucher.Scan_Voucher(ID);
                MessageBox.Show(Result);
            }
        }


        void GuiMail(string from, string to, string subject, string message, Attachment file = null)
        {
            MailMessage mess = new MailMessage(from, to, subject, message);
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("khanhvuongtuan37@gmail.com", "kh16111999");
            client.Send(mess);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                button4.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _barcodeReader = new BarcodeReader();
            _touch = new TouchlessMgr();
            button2.Enabled = false;
            button4.Enabled = false;
            radioButton1.Select();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            StopCamera();
            this.Hide();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
