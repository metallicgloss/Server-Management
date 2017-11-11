﻿using System;
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
    public partial class manageAccountPassword : Form
    {
        public manageAccountPassword()
        {
            InitializeComponent();
        }

        private void manageAccountPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            manageAccount Account = new manageAccount();
            Account.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
            manageAccount Account = new manageAccount();
            Account.ShowDialog();
        }
    }
}
