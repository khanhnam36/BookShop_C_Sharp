using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookShopTuto
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
            HienThiSoDonBanRa();
            HienThiDoanhThuNgay();
            HienThiSachBanChayTheoThang();
            HienThiSoLuongSachHetHang();
            LoadThangVaoComboBox();
            HienThiDoanhThuThang(DateTime.Now.Month);
            this.cbDoanhThuTheoThang.SelectedIndexChanged += new System.EventHandler(this.cbDoanhThuTheoThang_SelectedIndexChanged_1);
        }

        // Phương thức để hiển thị số đơn bán ra trong ngày
        private void HienThiSoDonBanRa()
        {
            // Chuỗi kết nối đến SQL Server (cần thay đổi tùy theo cấu hình của bạn)
            string connectionString = @"Data Source=DESKTOP-E1A4U7J\SQLSERVER2022;Initial Catalog=db_quan_ly_ban_sach;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open(); // Mở kết nối
                    string query = "SELECT COUNT(*) FROM tbl_hoa_don WHERE CONVERT(DATE, ngay_lap_hoa_don) = CONVERT(DATE, GETDATE())";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Lấy số lượng hóa đơn trong ngày
                        int soDonBanRa = (int)cmd.ExecuteScalar();
                        // Hiển thị lên Label `lblSoDonBanRa`
                        lblSoDonBanRa.Text = soDonBanRa.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi truy vấn dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Phương thức để hiển thị doanh thu trong ngày
        private void HienThiDoanhThuNgay()
        {
            string connectionString = @"Data Source=DESKTOP-E1A4U7J\SQLSERVER2022;Initial Catalog=db_quan_ly_ban_sach;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Truy vấn để tính tổng `thanh_tien` của các hóa đơn trong ngày hiện tại
                    string query = "SELECT SUM(thanh_tien) FROM tbl_hoa_don WHERE CONVERT(DATE, ngay_lap_hoa_don) = CONVERT(DATE, GETDATE())";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Lấy giá trị tổng doanh thu
                        object result = cmd.ExecuteScalar();
                        double doanhThu = result != DBNull.Value ? Convert.ToDouble(result) : 0.0;

                        // Hiển thị doanh thu và thêm "VNĐ"
                        lblDoanhThuNgay.Text = doanhThu.ToString("N0") + " VNĐ";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi truy vấn doanh thu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Phương thức để hiển thị sách bán chạy nhất theo tháng
        private void HienThiSachBanChayTheoThang()
        {
            string connectionString = @"Data Source=DESKTOP-E1A4U7J\SQLSERVER2022;Initial Catalog=db_quan_ly_ban_sach;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                SELECT TOP 1 s.ten_sach, SUM(hd.so_luong) AS TongSoLuong
                FROM tbl_hoa_don hd
                JOIN tbl_sach s ON hd.ma_sach = s.ma_sach
                WHERE MONTH(hd.ngay_lap_hoa_don) = MONTH(GETDATE())
                GROUP BY s.ten_sach
                ORDER BY TongSoLuong DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            string tenSachBanChay = reader["ten_sach"].ToString();
                            lblSachBanChay.Text = tenSachBanChay + " - " + reader["TongSoLuong"].ToString() + " quyển";
                        }
                        else
                        {
                            lblSachBanChay.Text = "Không có dữ liệu";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi truy vấn: " + ex.Message);
                }
            }
        }

        // Phương thức để hiển thị tổng số lượng sách sắp hết hàng (số lượng < 10)
        private void HienThiSoLuongSachHetHang()
        {
            string connectionString = @"Data Source=DESKTOP-E1A4U7J\SQLSERVER2022;Initial Catalog=db_quan_ly_ban_sach;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Câu truy vấn đếm tổng số lượng sách có số lượng tồn kho dưới 10
                    string query = @"
                SELECT COUNT(*) AS SoLuongSachHetHang
                FROM tbl_sach s
                LEFT JOIN (
                    SELECT ma_sach, SUM(so_luong) AS TongSoLuongNhap
                    FROM tbl_chi_tiet_phieu_nhap
                    GROUP BY ma_sach
                ) csn ON s.ma_sach = csn.ma_sach
                LEFT JOIN (
                    SELECT ma_sach, SUM(so_luong) AS TongSoLuongBan
                    FROM tbl_hoa_don
                    GROUP BY ma_sach
                ) hd ON s.ma_sach = hd.ma_sach
                WHERE (ISNULL(csn.TongSoLuongNhap, 0) - ISNULL(hd.TongSoLuongBan, 0)) < 10";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int soLuongHetHang = Convert.ToInt32(cmd.ExecuteScalar());

                        if (soLuongHetHang > 0)
                        {
                            lblSachHetHang.Text = $"{soLuongHetHang} sách sắp hết hàng";
                        }
                        else
                        {
                            lblSachHetHang.Text = "Không có sách sắp hết hàng";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi truy vấn sách hết hàng: " + ex.Message);
                }
            }
        }

        // Phương thức load tháng vào ComboBox
        private void LoadThangVaoComboBox()
        {
            // Thêm các tháng vào ComboBox từ 1 đến 12
            for (int i = 1; i <= 12; i++)
            {
                cbDoanhThuTheoThang.Items.Add("Tháng " + i);
            }

            // Đặt mặc định ComboBox hiển thị tháng hiện tại
            cbDoanhThuTheoThang.SelectedIndex = DateTime.Now.Month - 1;
        }

        // Sự kiện khi chọn tháng trong ComboBox
        private void cbDoanhThuTheoThang_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbDoanhThuTheoThang.SelectedIndex != -1)
            {
                // Lấy giá trị tháng từ ComboBox
                int thang = cbDoanhThuTheoThang.SelectedIndex + 1;
                HienThiDoanhThuThang(thang);
            }
        }

        // Phương thức hiển thị doanh thu theo tháng đã chọn
        private void HienThiDoanhThuThang(int thang)
        {
            string connectionString = @"Data Source=DESKTOP-E1A4U7J\SQLSERVER2022;Initial Catalog=db_quan_ly_ban_sach;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Truy vấn tổng doanh thu trong tháng đã chọn
                    string query = @"
                SELECT ISNULL(SUM(thanh_tien), 0) AS TongDoanhThu
                FROM tbl_hoa_don
                WHERE MONTH(ngay_lap_hoa_don) = @Thang AND YEAR(ngay_lap_hoa_don) = @Nam";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Thang", thang);
                        cmd.Parameters.AddWithValue("@Nam", DateTime.Now.Year);

                        // Thực thi truy vấn và lấy kết quả
                        object result = cmd.ExecuteScalar();

                        // Kiểm tra và cập nhật doanh thu cho tháng
                        if (result != null && result != DBNull.Value)
                        {
                            double doanhThu = Convert.ToDouble(result);
                            lblDoanhThuThang.Text = $"{doanhThu:n0} VNĐ";  // Hiển thị doanh thu tháng đã chọn
                        }
                        else
                        {
                            lblDoanhThuThang.Text = "0 VNĐ";  // Nếu không có dữ liệu, hiển thị 0
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu có sự cố khi truy vấn cơ sở dữ liệu
                    MessageBox.Show("Lỗi khi truy vấn doanh thu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            this.Hide();
            Books sach = new Books();
            sach.ShowDialog();
            this.Close();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login dang_xuat = new Login();
            dang_xuat.ShowDialog();
            this.Close();
        }

        private void btnShow_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra nếu người dùng chưa chọn tháng
            if (cbDoanhThuTheoThang.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn tháng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy tháng và năm từ ComboBox và thời gian hiện tại
            int thang = cbDoanhThuTheoThang.SelectedIndex + 1;
            int nam = DateTime.Now.Year;

            // Xác định số ngày trong tháng đã chọn
            int soNgayTrongThang = DateTime.DaysInMonth(nam, thang);

            // Chuỗi kết nối tới SQL Server
            string connectionString = @"Data Source=DESKTOP-E1A4U7J\SQLSERVER2022;Initial Catalog=db_quan_ly_ban_sach;Integrated Security=True;";

            // Tạo Dictionary để lưu doanh thu của từng ngày, mặc định doanh thu là 0
            Dictionary<int, double> doanhThuTheoNgay = new Dictionary<int, double>();
            for (int ngay = 1; ngay <= soNgayTrongThang; ngay++)
            {
                doanhThuTheoNgay[ngay] = 0;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Truy vấn lấy doanh thu của từng ngày có trong cơ sở dữ liệu
                    string query = @"
            SELECT DAY(ngay_lap_hoa_don) AS Ngay, SUM(thanh_tien) AS DoanhThu
            FROM tbl_hoa_don
            WHERE MONTH(ngay_lap_hoa_don) = @Thang AND YEAR(ngay_lap_hoa_don) = @Nam
            GROUP BY DAY(ngay_lap_hoa_don)
            ORDER BY Ngay";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Thang", thang);
                        cmd.Parameters.AddWithValue("@Nam", nam);

                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            int ngay = reader.GetInt32(0);
                            double doanhThu = reader.IsDBNull(1) ? 0 : reader.GetDouble(1);
                            doanhThuTheoNgay[ngay] = doanhThu;
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi truy vấn dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Xóa dữ liệu cũ trên Chart
            DoanhThu.Series["DoanhThu"].Points.Clear();

            // Cấu hình trục X để hiển thị tất cả các ngày
            DoanhThu.ChartAreas[0].AxisX.Interval = 1;
            DoanhThu.ChartAreas[0].AxisX.Minimum = 1;
            DoanhThu.ChartAreas[0].AxisX.Maximum = soNgayTrongThang;
            DoanhThu.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // Xoay nhãn ngày để tránh trùng lặp
            DoanhThu.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;

            // Cấu hình trục Y
            DoanhThu.ChartAreas[0].AxisY.LabelStyle.Format = "{0:n0}";
            DoanhThu.ChartAreas[0].AxisY.Title = "Doanh Thu (VNĐ)";
            DoanhThu.ChartAreas[0].AxisX.Title = "Ngày";

            // Hiển thị doanh thu của tất cả các ngày trong tháng
            for (int ngay = 1; ngay <= soNgayTrongThang; ngay++)
            {
                double doanhThu = doanhThuTheoNgay[ngay];
                DoanhThu.Series["DoanhThu"].Points.AddXY(ngay, doanhThu);
            }
        }
    }
}
