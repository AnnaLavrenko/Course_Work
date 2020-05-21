using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SQLApp
{
    public partial class RegisterForm : Form
    {
        /*TEST COMMIT*/
        public RegisterForm()
        {
            InitializeComponent();
            userField.Text = "User Name";
            userField.ForeColor = Color.Gray;
            firstNameField.Text = "First Name";
            firstNameField.ForeColor = Color.Gray;
            LastNameField.Text = "Last Name";
            LastNameField.ForeColor = Color.Gray;
            passwordField.Text = "Password";
        }

        private void UserField_Enter(object sender, EventArgs e)
        {
            if (userField.Text == "User Name")
            {
                userField.Text = "";
                userField.ForeColor = Color.White;
            }
                
        }

        private void UserField_Leave(object sender, EventArgs e)
        {
            if (userField.Text == "")
            {
                userField.Text = "User Name";
                userField.ForeColor = Color.Gray;
            }
        }

        private void FirstNameField_Enter(object sender, EventArgs e)
        {
            if (firstNameField.Text == "First Name")
            {
                firstNameField.Text = "";
                firstNameField.ForeColor = Color.White;
            }
        }

        private void FirstNameField_Leave(object sender, EventArgs e)
        {
            if (firstNameField.Text == "")
            {
                firstNameField.Text = "First Name";
                firstNameField.ForeColor = Color.Gray;
            }
        }

        private void LastNameField_Enter(object sender, EventArgs e)
        {
            if (LastNameField.Text == "Last Name")
            {
                LastNameField.Text = "";
                LastNameField.ForeColor = Color.White;
            }
        }

        private void LastNameField_Leave(object sender, EventArgs e)
        {
            if (LastNameField.Text == "")
            {
                LastNameField.Text = "Last Name";
                LastNameField.ForeColor = Color.Gray;
            }
        }

        private void PasswordField_Enter(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
                CapsLockOntoolTip.SetToolTip(passwordField, "CAPS LOCK IS ON");
            passwordField.Clear();
            passwordField.ForeColor = Color.White;
        }

        private void PasswordField_Leave(object sender, EventArgs e)
        {
            if (passwordField.Text == "")
            {
                passwordField.Text = "Second Name";
                passwordField.ForeColor = Color.Gray;
            }
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            if(userField.Text == "User Name")
            {
                MessageBox.Show("Please fill User Name field");
                return;
            }

            if (firstNameField.Text == "First Name")
            {
                MessageBox.Show("Please fill User First Name");
                return;
            }

            if (firstNameField.Text == "Second Name")
            {
                MessageBox.Show("Please fill User Second Name");
                return;
            }

            if (IsUserExist()) return;

            DBHandler dBHandler = new DBHandler();
            dBHandler.OpenConnection();
            MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO `test_db`.`users` (`login`, `password`, `first_name`, `last_name`, `birth_day`) VALUES (@login, @password, @firstName, @lastName, @birthDay)", dBHandler.GetConnection());
            mySqlCommand.Parameters.Add("@login", MySqlDbType.VarChar).Value = userField.Text;
            mySqlCommand.Parameters.Add("@password", MySqlDbType.VarChar).Value = passwordField.Text;
            mySqlCommand.Parameters.Add("@firstName", MySqlDbType.VarChar).Value = firstNameField.Text;
            mySqlCommand.Parameters.Add("@lastName", MySqlDbType.VarChar).Value = LastNameField.Text;
            mySqlCommand.Parameters.Add("@birthDay", MySqlDbType.Date).Value = dateTimePicker.Value;
            
            if (mySqlCommand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("User successfully created");
                this.Hide();
                AuthForm authForm = new AuthForm();
                authForm.Show();
            }
            else
            {
                MessageBox.Show("Account didn't create properly");
            }
            dBHandler.CloseConnection();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DBHandler dBHandler = new DBHandler();
            dBHandler.OpenConnection();
            MySqlCommand command = new MySqlCommand("select * from users;", dBHandler.GetConnection());
            if (command.ExecuteNonQuery() == -1)
                MessageBox.Show("OK");
            dBHandler.CloseConnection();
        }

        private Boolean IsUserExist()
        {
            String loginUser = userField.Text;

            DBHandler dbHandler = new DBHandler();
            dbHandler.OpenConnection();
            DataTable dbTable = new DataTable();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();

            MySqlCommand mySqlCommand = new MySqlCommand("select * from users where login=@uL", dbHandler.GetConnection());
            mySqlCommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = userField.Text;

            mySqlDataAdapter.SelectCommand = mySqlCommand;
            mySqlDataAdapter.Fill(dbTable);

            
            if(dbTable.Rows.Count > 0)
            {
                MessageBox.Show("User Name Already Exist");
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private void SingUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AuthForm authForm = new AuthForm();
            authForm.Show();
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}