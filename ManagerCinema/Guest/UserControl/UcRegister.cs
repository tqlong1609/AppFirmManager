using System.Windows.Forms;

namespace ManagerCinema
{
    public partial class UcRegister : UserControl
    {
        public UcRegister()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            string Username = bunifuMetroTextbox1.Text;
            string Numberphone = bunifuMetroTextbox2.Text;
            string Gender = bunifuDropdown1.ToString();
            string Email = bunifuMetroTextbox3.Text;
            string Password = bunifuMetroTextbox4.Text;
            string Confirm_Password = bunifuMetroTextbox8.Text;
            string Address = bunifuMetroTextbox5.Text;
            string Date_Of_Birth = bunifuDatepicker1.ToString();
            // Cần thay đổi id
        }
    }
}
