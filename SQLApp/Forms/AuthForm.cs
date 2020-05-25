﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SQLApp
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
            /*отрисовка текста при создании обьекта*/
            userField.Text = "Login";
            userField.ForeColor = Color.Gray;
            passwordField.Text = "Password";
            passwordField.ForeColor = Color.Gray;
            this.passwordField.AutoSize = false;
            this.passwordField.Size = new Size(passwordField.Size.Width, userField.Size.Height);
            this.ActiveControl = authLabel;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string loginUser = userField.Text;
            string passwordUser = passwordField.Text;
            DateTime birthDay = new DateTime();

            DBHandler dbHandler = new DBHandler();
            dbHandler.OpenConnection();
            DataTable dbTable = new DataTable();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();

            MySqlCommand mySqlCommand = new MySqlCommand("select * from users where login=@login and password=@password", dbHandler.GetConnection());
            mySqlCommand.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginUser;
            mySqlCommand.Parameters.Add("@password", MySqlDbType.VarChar).Value = passwordUser;

            mySqlDataAdapter.SelectCommand = mySqlCommand;
            mySqlDataAdapter.Fill(dbTable);
            foreach (DataRow row in dbTable.Rows)
            {
                birthDay = (DateTime) row["birth_day"];
            }
            if (dbTable.Rows.Count > 0)
            {
                this.Hide();
                Shop shop = new Shop(new User(loginUser, birthDay));
                shop.Show();
            }
            else
            {
                MessageBox.Show("User doesn't exist");
            }
        }

        private void SingUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void AuthForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // для placeholder
        private void UserField_Enter(object sender, EventArgs e)
        {
            if (userField.Text == "Login")
            {
                userField.Text = "";
                userField.ForeColor = Color.White;
            }
        }

        private void UserField_Leave(object sender, EventArgs e)
        {
            if (userField.Text == "")
            {
                userField.Text = "Login";
                userField.ForeColor = Color.Gray;
            }
        }

        private void PasswordField_Enter(object sender, EventArgs e)
        {
            if (passwordField.Text == "Password")
            {
                passwordField.Text = "";
                passwordField.ForeColor = Color.White;
            }
        }

        private void PasswordField_Leave(object sender, EventArgs e)
        {
            if (passwordField.Text == "")
            {
                passwordField.Text = "Password";
                passwordField.ForeColor = Color.Gray;
            }
        }
    }
}
