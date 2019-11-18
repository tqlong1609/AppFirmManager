using System.Text.RegularExpressions;
using System.Windows.Forms;
using ManagerCinema.BSLayer;

namespace ManagerCinema
{
    public partial class UcRegister : UserControl
    {
        private RegisterBS RegistBS;
        public UcRegister()
        {
            InitializeComponent();
        }
        public static bool isEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            string Username = bunifuMetroTextbox1.Text;
            string Numberphone = bunifuMetroTextbox2.Text;
            string Gender = "0";
            if(bunifuDropdown1.selectedValue == "Male")
            {
                Gender = "1";
            }
            string Email = bunifuMetroTextbox3.Text;
            if(!isEmail(Email))
            {
                MessageBox.Show("Your email is not in the right format");
                return;
            }
            string Password = bunifuMetroTextbox4.Text;
            string Confirm_Password = bunifuMetroTextbox8.Text;
            string Address = bunifuMetroTextbox5.Text;
            string Date_Of_Birth = bunifuDatepicker1.Value.ToLongDateString();
            string Name = bunifuMetroTextbox6.Text;
            RegistBS = new RegisterBS();
            string Username_Existed = RegistBS.Check_Username(Username);
            if (Username_Existed == "True")
            {
                MessageBox.Show("Account is already existed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Password == Confirm_Password)
            {
                RegistBS.Regist(Username, Numberphone, Gender, Email, Password, Confirm_Password, Address, Date_Of_Birth, Name);
                MessageBox.Show("Thank you for your request!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Password and confirm password must be the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void UcRegister_Load(object sender, System.EventArgs e)
        {

        }

        private void bunifuMetroTextbox6_OnValueChanged(object sender, System.EventArgs e)
        {

        }
    }
}
