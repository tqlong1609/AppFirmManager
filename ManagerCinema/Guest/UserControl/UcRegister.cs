using System.Data.SqlClient;
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

        public static bool isUsername(string Username)
        {
            Username = Username ?? string.Empty;
            string strRegex = @"^[A-Za-z_\.][A-Za-z0-9_\.]{6,32}$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(Username))
                return (true);
            else
                return (false);
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            string Username = bunifuMetroTextbox1.Text;
            if (!(isUsername(Username)))
            {
                MessageBox.Show("Username is not in the valid format!");
                return;
            }
            string Numberphone = bunifuMetroTextbox2.Text;
            string Gender = "0";
            if(bunifuDropdown1.selectedValue == "Male")
            {
                Gender = "1";
            }
            string Email = bunifuMetroTextbox3.Text;
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
                try
                {
                    RegistBS.Regist(Username, Numberphone, Gender, Email, Password, Confirm_Password, Address, Date_Of_Birth, Name);
                }
                catch (SqlException exception)
                {
                    MessageBox.Show(exception.Message);
                    return;
                }
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
