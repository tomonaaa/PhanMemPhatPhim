using AxWMPLib;
using Guna.UI2.WinForms;
using PhanMemPhatPhim;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Login1
{
    public partial class Menu : Form
    {
        string  Permission = "";

        public Menu()
        {
            InitializeComponent(); 
        }
        public Menu(string Permission, string AccountName)
        {
            InitializeComponent();
            this.Permission = Permission;
            label1.Text = "TK:" + AccountName;
        }



        private Form currentFormChild;

        private void OpenChildForm1(Form childForm1)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm1;
            childForm1.TopLevel = false;
            childForm1.FormBorderStyle = FormBorderStyle.None;
            childForm1.Dock = DockStyle.Fill;
            panel_back.Controls.Add(childForm1);
            panel_back.Tag = childForm1;
            childForm1.BringToFront();
            childForm1.Show();
        }
        private void OpenChildForm2(Form childForm2)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm2;
            childForm2.TopLevel = false;
            childForm2.FormBorderStyle = FormBorderStyle.None;
            childForm2.Dock = DockStyle.Fill;
            panel_back2.Controls.Add(childForm2);
            panel_back2.Tag = childForm2;
            childForm2.BringToFront();
            childForm2.Show();
        }
        private void btMovie_Click(object sender, EventArgs e)
        {
            OpenChildForm1(new Movies());
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm1(new Favourite());
        }
        private void btthemphim_Click(object sender, EventArgs e)
        {

        }
        private void btPhimdangxem_Click(object sender, EventArgs e)
        {
            OpenChildForm2(new PhimDangXem());
        }
        private void btHome_Click(object sender, EventArgs e)
        {

        }
        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        
        private void LbPlayList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LbListfilm.SelectedItem != null)
            {
                string selectedFilm = LbListfilm.SelectedItem.ToString();
                using (SqlConnection sqlConnection = Connection.GetSqlConnection())
                {
                    // Chuỗi truy vấn SQL để lấy thông tin của phim được chọn từ cơ sở dữ liệu
                    string query = "SELECT ID, Ten, MoTa, Dienvien, Daodien, NamPhatHanh, TheLoai, Pathanhphim, Pathanhmota1, Pathanhmota2 FROM Phim WHERE Ten LIKE @Ten";
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    command.Parameters.AddWithValue("@Ten", "%" + selectedFilm + "%");
                    sqlConnection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        // Lấy thông tin của phim từ kết quả truy vấn
                        string movieName = reader.GetString(reader.GetOrdinal("Ten"));
                        string movieDescription = reader.GetString(reader.GetOrdinal("MoTa"));
                        string dienVien = reader.GetString(reader.GetOrdinal("Dienvien"));
                        string daoDien = reader.GetString(reader.GetOrdinal("Daodien"));
                        int namPhatHanh = reader.GetInt32(reader.GetOrdinal("NamPhatHanh"));
                        string theLoai = reader.GetString(reader.GetOrdinal("TheLoai"));
                        string pathAnhPhim = reader.GetString(reader.GetOrdinal("Pathanhphim"));
                        string pathAnhMoTa1 = reader.GetString(reader.GetOrdinal("Pathanhmota1"));
                        string pathAnhMoTa2 = reader.GetString(reader.GetOrdinal("Pathanhmota2"));
                        Information informationForm = new Information(movieName, movieDescription, dienVien, daoDien, namPhatHanh, theLoai, pathAnhPhim, pathAnhMoTa1, pathAnhMoTa2);
                        informationForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy phim.");
                    }
                    reader.Close();
                }
            }
        }

        
        
        private List<string> GetDataFromDatabase()
        {
            List<string> filmNames = new List<string>();
            string query = "SELECT Ten FROM Phim";
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                SqlCommand command = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string filmName = reader.GetString(0);
                    filmNames.Add(filmName);
                }
                reader.Close();
            }
            return filmNames;
        }
        public void UpdateListBox()
        {
            LbListfilm.Items.Clear();
            List<string> newData = GetDataFromDatabase();
            foreach (string item in newData)
            {
                LbListfilm.Items.Add(item);
            }
        }
        private void btUpDate_Click(object sender, EventArgs e)
        {
            UpdateListBox();
        }
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btSearch_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void PerformSearch()
        {
            string searchText = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                using (SqlConnection sqlConnection = Connection.GetSqlConnection())
                {
                    string query = "SELECT ID, Ten, MoTa, Dienvien, Daodien, NamPhatHanh, TheLoai, Pathanhphim, Pathanhmota1, Pathanhmota2 FROM Phim WHERE Ten LIKE @Ten";
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    command.Parameters.AddWithValue("@Ten", "%" + searchText + "%");

                    sqlConnection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string movieName = reader.GetString(reader.GetOrdinal("Ten"));
                        string movieDescription = reader.GetString(reader.GetOrdinal("MoTa"));
                        string dienVien = reader.GetString(reader.GetOrdinal("Dienvien"));
                        string daoDien = reader.GetString(reader.GetOrdinal("Daodien"));
                        int namPhatHanh = reader.GetInt32(reader.GetOrdinal("NamPhatHanh"));
                        string theLoai = reader.GetString(reader.GetOrdinal("TheLoai"));

                        string pathAnhPhim = reader.GetString(reader.GetOrdinal("pathanhphim"));
                        string pathAnhMoTa1 = reader.GetString(reader.GetOrdinal("pathanhmota1"));
                        string pathAnhMoTa2 = reader.GetString(reader.GetOrdinal("pathanhmota2"));

                        Information informationForm = new Information(movieName, movieDescription, dienVien, daoDien, namPhatHanh, theLoai, pathAnhPhim, pathAnhMoTa1, pathAnhMoTa2);
                        informationForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy phim.");
                    }
                    reader.Close();
                }
            }
        }
        private void UpdatePhimListBox()
        {
            listTen.Items.Clear();
            // Kết nối với cơ sở dữ liệu
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                // Truy vấn để lấy tên phim từ bảng Phim
                string query = "SELECT Ten FROM Phim";
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string tenPhim = reader.GetString(0);
                            listTen.Items.Add(tenPhim);
                        }
                    }
                }
            }
        }

        private void UpdateViewtimeListBox()
        {
            listluot.Items.Clear();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                string query = "SELECT Viewtime FROM LuotXem";
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int viewtime = reader.GetInt32(0);
                            listluot.Items.Add(viewtime.ToString());
                        }
                    }
                }
            }
        }
        private void UpdateListBoxes()
        {
            UpdatePhimListBox();
            UpdateViewtimeListBox();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            UpdateListBoxes();
        }

        private string GetUserPermission(string username, string password)
        {
            string query = "SELECT TOP 1 Permission FROM Account WHERE Username = @Username AND Password = @Password";
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return reader.GetString(0);
                }
            }
            // Return default permission if not found
            return "User";
        }

        private void btUser_Click(object sender, EventArgs e)
        {
            string username = "admin1";
            string password = "admin1";

            string permission = GetUserPermission(username, password);
            Console.WriteLine("Permission: " + permission); // In giá trị permission ra để kiểm tra
            if (permission.Equals("admin1", StringComparison.OrdinalIgnoreCase))
            {
                this.Hide();
                UserForm userForm = new UserForm();
                userForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dienvien_Click(object sender, EventArgs e)
        {

        }

        private void btthemphim_Click_1(object sender, EventArgs e)
        {

        }

        private void btTP_Click(object sender, EventArgs e)
        {

        }

        private void btTP_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ThemPhim ThemPhim = new ThemPhim();
            ThemPhim.ShowDialog();
        }
    }
}
