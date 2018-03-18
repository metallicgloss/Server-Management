using System;
using System.Windows.Forms;

namespace ELSM_Project
{
    public partial class setupEmailConfiguration : Form
    {
        public setupEmailConfiguration()
        {
            //On form load initialize component.
            InitializeComponent();
        }

        public static string SMTPServer, SMTPPort, EmailUsername, EmailPass;

        private void btnInstall_Click(object sender, EventArgs e)
        {
            //If entered text isn't blank, set variables to match data inserted into the form. Else, output messagebox.
            if ((txtSMTPPort.Text != "") && (txtSMTPServer.Text != "") && (txtEmailPassword.Text != "") && (txtEmailUsername.Text != ""))
            {
                SMTPPort = txtSMTPPort.Text;
                SMTPServer = txtSMTPServer.Text;
                EmailPass = txtEmailPassword.Text;
                EmailUsername = txtEmailUsername.Text;
                Hide();
                setupCompanyCreate company = new setupCompanyCreate();
                company.ShowDialog();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please enter data into the form.");
            }
        }
    }
}