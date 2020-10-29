using DataManager;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JSTypeTester
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ProcessLogin()
        {
            if (this.txtUsername.Text == string.Empty || this.txtPassword.Text == string.Empty)
            {
                MessageBox.Show(this, "Please enter your credentials", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var registrationPrefix = System.Configuration.ConfigurationManager.AppSettings["registration_prefix"];
                if (this.txtPassword.Text == this.txtUsername.Text && this.txtUsername.Text.StartsWith(registrationPrefix))
                {
                    SpeedDataHandler.GetInstance().SetupUser(this.txtUsername.Text);
                    SpeedDataHandler.GetInstance().SetupEnvironment();

                    this.Hide();

                    User user = new User();
                    user.RegisterNumber = this.txtUsername.Text;

                    new Picker(user).ShowDialog();

                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "Invalid Register Number or password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            //ProcessLogin();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ProcessLogin();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            //ProcessLogin();
        }
    }
}
