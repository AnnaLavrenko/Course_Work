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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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
            if(e.Button == MouseButtons.Left)
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
            
            DBHandler dbHandler = new DBHandler();
            dbHandler.openConnection();
            DataTable dbTable = new DataTable();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();

            MySqlCommand mySqlCommand = new MySqlCommand("select * from users where login=@uP and password=@uL", dbHandler.getConnection());
            mySqlCommand.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passwordUser;
            mySqlCommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;

            mySqlDataAdapter.SelectCommand = mySqlCommand;
            mySqlDataAdapter.Fill(dbTable);

            MessageBox.Show(dbTable.Rows.Count > 0 ? "Successfully logged in" : "User doesn't exist");
        }
    }
}
