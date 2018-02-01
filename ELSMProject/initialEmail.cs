using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELSM_Project
{
    public partial class initialEmail : Form
    {
        public initialEmail()
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
            createCompany company = new createCompany();
            company.ShowDialog();
        }
    }
}
