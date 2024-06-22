using System.Data.SqlClient;
using System.Runtime.InteropServices;
﻿using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Login1
{
    public partial class Login : Form
    {
        private const bool V = false;

        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam);

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Enter(object sender, EventArgs e)
        {

        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "UserName")
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.White;
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserName.Text = "UserName";
                txtUserName.ForeColor = Color.White;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.White;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.White;
                txtPassword.UseSystemPasswordChar = V;
            }
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private string GetUserRole(string username)
        {
            string query = "SELECT Permission FROM Account WHERE Username = @Username";
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@Username", username);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return reader.GetString(0);
                }
            }
            // Return default role if not found
            return "User";
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        Modify modify = new Modify();

        private void btlogin_Click(object sender, EventArgs e)
        {
            string UserName = txtUserName.Text.Trim();
            string Password = txtPassword.Text.Trim();

            if (UserName == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!");
                return;
            }
            else if (Password == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                return;
            }

            string query = "SELECT * FROM Account WHERE UserName = @Username AND Password = @Password";
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@Username", UserName);
                command.Parameters.AddWithValue("@Password", Password);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                    // Open appropriate form based on user role
                    Menu menu = new Menu();
                    menu.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void btsignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register2 register = new Register2();
            register.ShowDialog();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btlogin_Click(sender, e);
            }
        }

    }
}