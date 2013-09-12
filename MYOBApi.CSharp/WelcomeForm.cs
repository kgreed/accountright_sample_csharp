using System;
using System.Windows.Forms;
using MYOBApi.CSharp.Forms;

namespace MYOBApi.CSharp
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void LnkGetStartedLinkClicked(Object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frmCompanyFiles = new CompanyFilesForm();
            frmCompanyFiles.Show();
        }
    }
}