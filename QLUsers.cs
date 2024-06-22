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

namespace PhanMemPhatPhim
{
    public partial class QLUsers : Form
    {
        public QLUsers()
        {
            InitializeComponent();
        }



        private void btHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm();
            adminForm.ShowDialog();
        }

        private void btQLUsers_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
        private void btDanhsach_Click(object sender, EventArgs e)
        {
            UpdateListBox();
        }
        private void XoaPhim(string tenPhim)
        {
            // Xóa dòng từ cơ sở dữ liệu và cập nhật lại ID của các dòng còn lại
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Xóa dòng từ cơ sở dữ liệu
                        using (SqlCommand command = new SqlCommand("DELETE FROM Phim WHERE Ten = @Ten", connection, transaction))
                        {
                            command.Parameters.AddWithValue("@Ten", tenPhim);
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                CapNhatID(connection, transaction);
                                transaction.Commit();
                                MessageBox.Show("Phim đã được xóa thành công.");
                            }
                            else
                            {
                                MessageBox.Show("Phim không tồn tại.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Lỗi truy xuất: " + ex.Message);
                    }
                }
            }
        }
        private void CapNhatID(SqlConnection connection, SqlTransaction transaction)
        {
            string updateCommand = "UPDATE Phim SET ID = ID - 1 WHERE ID > @ID";
            using (SqlCommand command = new SqlCommand(updateCommand, connection, transaction))
            {
                command.Parameters.AddWithValue("@ID", GetID(connection, transaction));
                command.ExecuteNonQuery();
            }
        }
        private int GetID(SqlConnection connection, SqlTransaction transaction)
        {
            string selectCommand = "SELECT MAX(ID) FROM Phim";
            using (SqlCommand command = new SqlCommand(selectCommand, connection, transaction))
            {
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    return 0;
                }
            }
        }
        private void LbListfilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LbListfilm.SelectedItem != null)
            {
                string selectedPhim = LbListfilm.SelectedItem.ToString();
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng có tên phim '" + selectedPhim + "'?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    XoaPhim(selectedPhim);
                }
            }
        }
    }
}
