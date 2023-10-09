using System.Data.SqlClient;
namespace Registration
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }
        readonly DataBase dataBase = new();
        SqlCommand command = new();

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "" && txtComPassword.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == txtComPassword.Text)
            {
                dataBase.sqlConnection.Open();
                string register = "INSERT INTO Users_db VALUES ('" + txtUsername.Text + "', '" + txtPassword.Text + "')";
                command = new SqlCommand(register, dataBase.sqlConnection);
                command.ExecuteNonQuery();
                dataBase.sqlConnection.Close();

                txtUsername.Text = "";
                txtPassword.Text = "";
                txtComPassword.Text = "";

                MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Passwords does not match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtComPassword.Text = "";
                txtPassword.Focus();
            }
        }

        private void CheckBxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBxShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtComPassword.PasswordChar = '•';
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtComPassword.Text = "";
            txtUsername.Focus();
        }

        private void BackToLogInLabel_Click(object sender, EventArgs e)
        {
            new FrmLogin().Show();
            this.Hide();
        }
    }
}