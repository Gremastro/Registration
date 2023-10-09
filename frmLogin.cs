using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Registration
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=WIN-URDQA9ADV82;Initial Catalog=Пользователи;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            string login = "SELECT * FROM Users_db WHERE login_user= '" + txtUsername.Text + "' and password_user= = '" + txtPassword.Text + "'";
            command = new SqlCommand(login, sqlConnection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read() == true)
            {
                new dashboard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void CheckBxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBxShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }
    }
}
