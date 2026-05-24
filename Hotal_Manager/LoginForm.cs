using System;
using System.Windows.Forms;

namespace Hotal_Manager
{
    public partial class LoginForm : Form
    {
        // No database connection needed anymore
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Black;
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Nothing needed here
        }

        private void Button_login_Click(object sender, EventArgs e)
        {
            // Simple hardcoded check – only "Admin" works
            if (TextBox_username.Text.Trim() == "Admin" && TextBox_password.Text == "Admin")
            {
                this.Hide();
                MainForm mainform = new MainForm();
                mainform.Show();
            }
            else
            {
                // Keep the original Persian message style
                MessageBox.Show("اطلاعات شما وجود ندارد", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}