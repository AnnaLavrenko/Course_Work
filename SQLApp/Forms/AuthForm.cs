using System;
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
            this.passwordField.AutoSize = false;
            this.passwordField.Size = new Size(passwordField.Size.Width, userField.Size.Height);
        }


        private void closeWindowButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void closeWindowButton_MouseEnter(object sender, EventArgs e)
        {

        }
        Point lastPoin;
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoin.X;
                this.Top += e.Y - lastPoin.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoin = new Point(e.X, e.Y);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String loginUser = userField.Text;
            String passwordUser = passwordField.Text;
            DateTime birthDay = new DateTime();

            DBHandler dbHandler = new DBHandler();
            dbHandler.OpenConnection();
            DataTable dbTable = new DataTable();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();

            MySqlCommand mySqlCommand = new MySqlCommand("select * from users where login=@uL and password=@uP", dbHandler.GetConnection());
            mySqlCommand.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passwordUser;
            mySqlCommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;

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
                //this.Close();
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
    }
}
