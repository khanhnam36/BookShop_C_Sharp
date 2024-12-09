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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
            this.Close();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtTaiKhoan.Text;  // Lấy tên đăng nhập từ TextBox
            string password = txtMatKhau.Text;   // Lấy mật khẩu từ TextBox

            // Kiểm tra thông tin đăng nhập
            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Đăng nhập thành công!");
                // Chuyển sang form chính của ứng dụng (nếu có)
                this.Hide();
                TrangChu trang_chu = new TrangChu();
                trang_chu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!");
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            // Chuỗi kết nối với database
            string connectionString = @"Data Source=DESKTOP-E1A4U7J\SQLSERVER2022;Initial Catalog=db_quan_ly_ban_sach;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Câu truy vấn kiểm tra tài khoản và mật khẩu
                    string query = "SELECT COUNT(1) FROM tbl_users WHERE username = @username AND password = @password";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    // Truyền tham số cho câu truy vấn
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    // Thực thi câu truy vấn và kiểm tra kết quả
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count == 1; // Trả về true nếu có tài khoản khớp
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
