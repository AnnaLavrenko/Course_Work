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
            secondNameField.Text = "Second Name";
            secondNameField.ForeColor = Color.Gray;
            passwordField.Text = "Password";
        }

        Point lastPoin;
        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoin.X;
                this.Top += e.Y - lastPoin.Y;
            }
        }

        private void Reader_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoin = new Point(e.X, e.Y);
        }

        private void UserField_Enter(object sender, EventArgs e)
        {
            if (userField.Text == "User Name")
            {
                userField.Text = "";
                userField.ForeColor = Color.Black;
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
                firstNameField.ForeColor = Color.Black;
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

        private void SecondNameField_Enter(object sender, EventArgs e)
        {
            if (secondNameField.Text == "Second Name")
            {
                secondNameField.Text = "";
                secondNameField.ForeColor = Color.Black;
            }
        }

        private void SecondNameField_Leave(object sender, EventArgs e)
        {
            if (secondNameField.Text == "")
            {
                secondNameField.Text = "Second Name";
                secondNameField.ForeColor = Color.Gray;
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
            MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO `test_db`.`users` (`login`, `password`, `first_name`, `second_name`) VALUES (@login, @password, @firstName, @secondName)", dBHandler.GetConnection());
            mySqlCommand.Parameters.Add("@login", MySqlDbType.VarChar).Value = userField.Text;
            mySqlCommand.Parameters.Add("@password", MySqlDbType.VarChar).Value = passwordField.Text;
            mySqlCommand.Parameters.Add("@firstName", MySqlDbType.VarChar).Value = firstNameField.Text;
            mySqlCommand.Parameters.Add("@secondName", MySqlDbType.VarChar).Value = secondNameField.Text;
            
            if (mySqlCommand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("User successfully created");
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