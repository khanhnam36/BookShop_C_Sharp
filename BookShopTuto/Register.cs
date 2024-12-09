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

namespace BookShopTuto
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtTaiKhoan.Text;
            string password = txtMatKhau.Text;
            string confirmPassword = txtXacNhanMatKhau.Text;

            // Kiểm tra các ô không để trống và mật khẩu khớp nhau
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản và mật khẩu.");
            }
            else if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp.");
            }
            else
            {
                // Gọi hàm đăng ký tài khoản
                RegisterUser(username, password);
            }
        }

        // Hàm thêm tài khoản vào cơ sở dữ liệu
        private void RegisterUser(string username, string password)
        {
            string connectionString = @"Data Source=DESKTOP-E1A4U7J\SQLSERVER2022;Initial Catalog=db_quan_ly_ban_sach;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Kiểm tra xem tài khoản đã tồn tại chưa
                    string checkQuery = "SELECT COUNT(*) FROM tbl_users WHERE username = @username";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@username", username);

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Tên tài khoản đã tồn tại. Vui lòng chọn tên khác.");
                        return;
                    }

                    // Nếu tài khoản chưa tồn tại, thêm vào cơ sở dữ liệu
                    string insertQuery = "INSERT INTO tbl_users (username, password) VALUES (@username, @password)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@username", username);
                    insertCmd.Parameters.AddWithValue("@password", password);

                    insertCmd.ExecuteNonQuery();
                    MessageBox.Show("Đăng ký tài khoản thành công!");

                    // Làm mới các trường nhập liệu
                    txtTaiKhoan.Clear();
                    txtMatKhau.Clear();
                    txtXacNhanMatKhau.Clear();
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Có lỗi xảy ra với cơ sở dữ liệu: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                }
            }
        }

    }
}
