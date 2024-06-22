using AxWMPLib;
using Login1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Trong form Information.cs

namespace PhanMemPhatPhim
{
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        public Information(string tenPhim, string moTa, string dienVien, string daoDien, int namPhatHanh, string theLoai, string anhPhim, string anhMoTa1, string anhMoTa2)
        {
            InitializeComponent();

            // Gán dữ liệu cho các controls trong form
            labelTenPhim.Text = tenPhim;
            labelMoTa.Text = moTa;
            dienvien.Text = dienVien;
            daodien.Text = daoDien;
            nam.Text = namPhatHanh.ToString();
            theloai.Text = theLoai;

            // Load hình ảnh
            try
            {
                anhPhimm.Image = Image.FromFile(anhPhim);
                anhMotaPhim1.Image = Image.FromFile(anhMoTa1);
                anhMotaPhim2.Image = Image.FromFile(anhMoTa2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải ảnh: " + ex.Message);
            }
        }
        private string LayDuongDanPhim(string tenPhim)
        {
            string duongDan = "";
            string query = "SELECT Duongdan FROM Phim WHERE Ten = @Ten";

            // Tạo kết nối
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                // Tạo đối tượng SqlCommand
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    // Thêm tham số @TenPhim vào câu truy vấn
                    command.Parameters.AddWithValue("@Ten", tenPhim);

                    try
                    {
                        // Mở kết nối
                        sqlConnection.Open();

                        // Thực hiện truy vấn và lấy kết quả    
                        object result = command.ExecuteScalar();

                        // Kiểm tra nếu có kết quả
                        if (result != null)
                        {
                            duongDan = result.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy đường dẫn phim.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lấy đường dẫn phim: " + ex.Message);
                    }
                }
            }

            return duongDan;
        }
        private void AddClickCount(int accountId, int MovieId)
        {
            string query = "IF EXISTS (SELECT 1 FROM LuotXem WHERE IDaccount = @AccountId AND IDmovie = @MovieId) " +
                   "BEGIN " +
                   "    UPDATE LuotXem SET Viewtime = Viewtime + 1 WHERE IDaccount = @AccountId AND IDmovie = @MovieId " +
                   "END " +
                   "ELSE " +
                   "BEGIN " +
                   "    INSERT INTO LuotXem (IDaccount, IDmovie, Viewtime) VALUES (@AccountId, @MovieId, 1) " +
                   "END";
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@AccountId", accountId);
                command.Parameters.AddWithValue("@MovieId", MovieId);

                try
                {
                    sqlConnection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void btXemphim_Click(object sender, EventArgs e)
        {
            int accountId = 1;
            int itemId =0;
            itemId++;

            AddClickCount(accountId, itemId);

            string tenPhim = labelTenPhim.Text;


            string duongDan = LayDuongDanPhim(tenPhim);


            if (!string.IsNullOrEmpty(duongDan))
            {
                TRINHPHAT trinhPhatForm = new TRINHPHAT();

                trinhPhatForm.axWindowsMediaPlayer1.URL = duongDan;


                trinhPhatForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không tìm thấy đường dẫn phim.");
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void anhPhim_Click(object sender, EventArgs e)
        {

        }
        private void Information_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelTenPhim_Click(object sender, EventArgs e)
        {

        }
    }
}
