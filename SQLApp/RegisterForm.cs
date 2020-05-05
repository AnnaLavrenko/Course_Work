using System;
using System.Drawing;
using System.Windows.Forms;

namespace SQLApp
{
    public partial class RegisterForm : Form
    {
        /*TEST COMMIT*/
        public RegisterForm()
        {
            InitializeComponent();
            userField.Text = "User Name";
            firstNameField.Text = "First Name";
            secondNameField.Text = "Second Name";
            passwordField.Text = "Password";
        }

        private void closeWindowButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point lastPoin;
        private void header_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoin.X;
                this.Top += e.Y - lastPoin.Y;
            }
        }

        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoin = new Point(e.X, e.Y);
        }
    }
}