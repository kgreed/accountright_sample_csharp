using System.Windows.Forms;

namespace MYOBApi.CSharp.Forms
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Public property to set and get Username
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string Username
        {
            get { return txtUsername.Text; }
            set { txtUsername.Text = Username; }
        }

        /// <summary>
        /// Public property to set and get Password
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = Password; }
        }

        private void OkClick(System.Object sender, System.EventArgs e)
        {
            Close();
        }

        private void CancelClick(System.Object sender, System.EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            Close();
        }

        private void LoginFormLoad(object sender, System.EventArgs e)
        {
            txtUsername.Text = "Administrator";
        }
    }
}