using PasswordStrengthCheckerLogic;

namespace PasswordStrengthChecker
{
    public partial class Main : Form
    {
        PWStrengthLogic _pwStrengthLogic;

        public Main()
        {
            InitializeComponent();
            _pwStrengthLogic = new PWStrengthLogic();
        }

        // This happens when the form first starts
        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            // Do logic here to change lblStrength

            lblStrength.Text = _pwStrengthLogic.GetPasswordStrengthLabel(txtPassword.Text); // Just an example...
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Text = string.Empty;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutMe aboutMe = new AboutMe();
            aboutMe.ShowDialog();
        }
    }
}
