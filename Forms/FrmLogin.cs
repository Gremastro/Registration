using System.Data.SqlClient;

namespace Registration
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        readonly DataBase dataBase = new();
        SqlCommand command = new();

        private void LogInButton_Click(object sender, EventArgs e)
        {
            dataBase.sqlConnection.Open();
            string login = "SELECT * FROM Users_db WHERE login_user= '" + txtUsername.Text + "' and password_user= '" + txtPassword.Text + "'";
            command = new SqlCommand(login, dataBase.sqlConnection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read() == true)
            {
                new Dashboard().Show();
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

        private void ClearButton_Click(object sender, EventArgs e)
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

        private void CreateAccountLabel_Click(object sender, EventArgs e)
        {
            new FrmRegistration().Show();
            this.Hide();
        }
    }
}
