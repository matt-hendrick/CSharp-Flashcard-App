using FlashcardLibrary;
using FlashcardLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlashcardUI
{
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                UserModel user = new UserModel();
                
                user.Username = usernameTextbox.Text;
                user.Email = emailTextbox.Text;
                user.Password = passwordTextbox.Text;

                DatabaseConnector.Connection.CreateUser(user);

            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        private bool ValidateForm()
        {
            // if any of the fields are empty, return false
            if (usernameTextbox.Text.Length < 1 || emailTextbox.Text.Length < 1 || passwordTextbox.Text.Length < 1 || confirmPasswordTextbox.Text.Length < 1 ) return false;

            // if password fields don't match return false
            if (passwordTextbox.Text != confirmPasswordTextbox.Text) return false;

            return true;
        }
    }
}
