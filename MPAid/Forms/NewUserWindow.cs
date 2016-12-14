﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MPAid
{
    /// <summary>
    /// The screen allowing a new user to be created.
    /// </summary>
    public partial class NewUserWindow : Form
    {
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public NewUserWindow()
        {
            InitializeComponent();
        }

        private string username = null;
        private string usercode = null;
        private bool valid = false; //Set to true when the user is authenticated.
        /// <summary>
        /// Link to the details of all users in the system.
        /// </summary>
        private UserManagement allUsers;
        /// <summary>
        /// Gets the values of the user from the text boxes, and uses them to create an MPAi user object.
        /// </summary>
        /// <returns>The created user object.</returns>
        public MPAiUser getCandidate()
        {
            username = userNameBox.Text;
            usercode = codeBox.Text;

            return (new MPAiUser(username, usercode));
        }
        /// <summary>
        /// Getter method for valid.
        /// </summary>
        /// <returns>Whether or not the registration was valid.</returns>
        public bool validRegistration()
        {
            return valid;
        }
        /// <summary>
        /// Closes the window if the operation is cancelled.
        /// </summary>
        /// <param name="sender">Automatically generated by Visual Studio.</param>
        /// <param name="e">Automatically generated by Visual Studio.</param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Allows the current group of users to be assigned from outside the class.
        /// </summary>
        /// <param name="console">The UserManagement object representing the current users.</param>
        public void SetAllUsers(UserManagement console)
        {
            allUsers = console;
        }

        /// <summary>
        /// Ensures that the new user is valid, and closes the window.
        /// </summary>
        /// <param name="sender">Automatically generated by Visual Studio.</param>
        /// <param name="e">Automatically generated by Visual Studio.</param>
        private void buttonOK_Click(object sender, EventArgs e) 
        {
            if (userNameBox.Text.Trim() == "")
            {
                MessageBox.Show("Username should not be empty! ",
                  "Oops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if ((codeBox.Text.Trim() == "") || (codeBox2.Text.Trim() == ""))
            {
                MessageBox.Show("Passwords should not be empty! ",
                   "Oops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (codeBox.Text != codeBox2.Text)
            {
                MessageBox.Show("Passwords do not match! ",
                    "Oops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            MPAiUser candidate = getCandidate();

            if (allUsers.ContainsUser(candidate))
            {
                MessageBox.Show("User already exist, please use a different name! ",
                    "Oops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                valid = true;
                this.Close();
            }

        }
        
    }
}
