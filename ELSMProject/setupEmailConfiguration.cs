using System;
using System.Windows.Forms;

namespace ELSM_Project
{
    public partial class setupEmailConfiguration : Form
    {
        public setupEmailConfiguration()
        {
            InitializeComponent();
        }

        public static string SMTPServer, SMTPPort, EmailUsername, EmailPass;

        private void btnInstall_Click(object sender, EventArgs e)
        {
            SMTPPort = txtSMTPPort.Text;
            SMTPServer = txtSMTPServer.Text;
            EmailPass = txtEmailPassword.Text;
            EmailUsername = txtEmailUsername.Text;

            Hide();
            setupCompanyCreate company = new setupCompanyCreate();
            company.ShowDialog();
        }
    }
}
