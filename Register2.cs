using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace Login1
{
    public partial class Register2 : Form
    {
        private const bool V = false;
        public Register2()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam);

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Enter(object sender, EventArgs e)
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

        private void txtConfirm_Enter(object sender, EventArgs e)   // doi ten txtbox confirm pass
        {
            if (txtConfirm.Text == "Confirm Password")
            {
                txtConfirm.Text = "";
                txtConfirm.ForeColor = Color.White;
                txtConfirm.UseSystemPasswordChar = true;
            }
        }

        private void txtConfirm_Leave(object sender, EventArgs e)
        {
            if (txtConfirm.Text == "")
            {
                txtConfirm.Text = "Confirm Password";
                txtConfirm.ForeColor = Color.White;
                txtConfirm.UseSystemPasswordChar = V;
            }
        }

        private void btexit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        // check pass va tentk
        public bool checkAccount(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        Modify modify = new Modify();
        private void btRegister_Click(object sender, EventArgs e)
        {
            string UserName = txtUserName.Text;
            string Password = txtPassword.Text;
            string Confirm = txtConfirm.Text;
            if (!checkAccount(UserName))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản dài 6-24 ký tự, với các ký tự chữ và số, chữ hoa và chữ thường!");
                return;
            }
            if (!checkAccount(Password))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu dài 6-24 ký tự, với các ký tự chữ và số, chữ hoa và chữ thường!");
                return;
            }
            if (Confirm != Password)
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác!");
                return;
            }
            string getLastIDQuery = "SELECT TOP 1 ID FROM Account ORDER BY ID DESC";
            int lastID = 0;
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlCommand getCommand = new SqlCommand(getLastIDQuery, sqlConnection);
                object result = getCommand.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    lastID = Convert.ToInt32(result);
                }
            }
            int nextID = lastID + 1;
            string nextIDFormatted = nextID.ToString("D3");
            try
            {
                string query = "INSERT INTO Account (ID,UserName, Password) VALUES (@ID,@UserName, @Password)";
                using (SqlConnection sqlConnection = Connection.GetSqlConnection())
                {
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    command.Parameters.AddWithValue("@ID", nextIDFormatted);
                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@Password", Password);
                    int rowsAffected = command.ExecuteNonQuery();
                    sqlConnection.Close();
                    if (rowsAffected > 0)
                    {
                        if (MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập luôn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            this.Hide();
                            Login login = new Login();
                            login.ShowDialog();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đăng ký không thành công!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void btLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
