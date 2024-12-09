using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookShopTuto
{
    public partial class PhieuNhap : Form
    {
        // Khai báo đối tượng dataProvider bên trong lớp PhieuNhap
        private DataProvider dataProvider = new DataProvider();
        private int selectedPhieuNhapId;

        public PhieuNhap()
        {
            InitializeComponent();
        }

        private void PhieuNhap_Load(object sender, EventArgs e)
        {
            loadDgPhieuNhap();
            LoadMaSach();
            LoadMaNhaPhanPhoi();
        }

        private void loadDgPhieuNhap()
        {
            try
            {
                string query = @"
                    SELECT 
                        pn.ma_phieu_nhap,
                        np.ma_nha_phan_phoi AS [Mã nhà phân phối],
                        np.ten_nha_phan_phoi AS [Tên Nhà Phân Phối],
                        pn.ngay_lap_phieu_nhap AS [Ngày Lập Phiếu],
                        s.ma_sach AS [Mã sách], 
                        s.ten_sach AS [Tên sách],
                        ctpn.so_luong AS [Số lượng],
                        ctpn.gia_nhap AS [Giá nhập], 
                        ctpn.thanh_tien AS [Thành tiền]
                    FROM 
                        tbl_phieu_nhap pn
                    JOIN 
                        tbl_chi_tiet_phieu_nhap ctpn ON pn.ma_phieu_nhap = ctpn.ma_phieu_nhap
                    JOIN 
                        tbl_nha_phan_phoi np ON pn.ma_nha_phan_phoi = np.ma_nha_phan_phoi
                    JOIN 
                        tbl_sach s ON ctpn.ma_sach = s.ma_sach";

                // Thực hiện truy vấn và lấy kết quả
                DataTable dt = dataProvider.execQuery(query);

                // Gán DataTable cho DataGridView
                dgPhieuNhap.DataSource = dt;

                // Ẩn cột ma_phieu_nhap nếu không cần hiển thị
                dgPhieuNhap.Columns["ma_phieu_nhap"].Visible = false;

                // Thiết lập chế độ tự động điều chỉnh chiều rộng cột
                dgPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Căn giữa tên đầu bảng
                foreach (DataGridViewColumn column in dgPhieuNhap.Columns)
                {
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu phiếu nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Books sach = new Books();
            sach.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoaiSach loai_sach = new LoaiSach();
            loai_sach.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoaDon hoa_don = new HoaDon();
            hoa_don.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu trang_chu = new TrangChu();
            trang_chu.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            KhoHang kho_hang = new KhoHang();
            kho_hang.ShowDialog();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhaPhanPhoi nha_phan_phoi = new NhaPhanPhoi();
            nha_phan_phoi.ShowDialog();
            this.Close();
        }

        private void LoadMaSach()
        {
            try
            {
                // Tạo câu truy vấn để lấy tên sách từ bảng sách
                string query = "SELECT ma_sach FROM tbl_sach";

                // Thực hiện truy vấn và lấy kết quả
                DataTable dt = dataProvider.execQuery(query);

                // Gán tên sách vào ComboBox
                cbPhieuNhapMaSach.DataSource = dt;
                cbPhieuNhapMaSach.DisplayMember = "ma_sach"; // Cột hiển thị
                cbPhieuNhapMaSach.ValueMember = "ma_sach"; // Cột giá trị
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu tên sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cbPhieuNhapMaSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPhieuNhapMaSach.SelectedValue != null)
            {
                string maSach = cbPhieuNhapMaSach.SelectedValue.ToString();
            }
        }

        private void LoadMaNhaPhanPhoi()
        {
            try
            {
                // Tạo câu truy vấn để lấy mã nhà phân phối từ bảng phiếu nhập
                string query = "SELECT DISTINCT ma_nha_phan_phoi, ten_nha_phan_phoi FROM tbl_nha_phan_phoi";

                // Thực hiện truy vấn và lấy kết quả vào DataTable
                DataTable dt = dataProvider.execQuery(query);

                // Gán DataTable làm nguồn dữ liệu cho ComboBox
                cbPhieuNhapMaNPP.DataSource = dt;

                // Thiết lập cột hiển thị là mã nhà phân phối
                cbPhieuNhapMaNPP.DisplayMember = "ma_nha_phan_phoi"; // Cột hiển thị
                cbPhieuNhapMaNPP.ValueMember = "ma_nha_phan_phoi"; // Cột giá trị
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu mã nhà phân phối: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cbPhieuNhapMaNPP_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu có giá trị được chọn
            if (cbPhieuNhapMaNPP.SelectedValue != null)
            {
                // Lấy mã nhà phân phối đã chọn
                string maNhaPhanPhoi = cbPhieuNhapMaNPP.SelectedValue.ToString();

                // Truy vấn để lấy tên nhà phân phối từ cơ sở dữ liệu
                string query = "SELECT ten_nha_phan_phoi FROM tbl_nha_phan_phoi WHERE ma_nha_phan_phoi = @maNhaPhanPhoi";

                Dictionary<string, object> parameters = new Dictionary<string, object>
        {
            { "@maNhaPhanPhoi", maNhaPhanPhoi } // Thêm tham số mã nhà phân phối
        };

                // Gọi phương thức execScalar để lấy tên nhà phân phối
                object result = dataProvider.execScalar(query, parameters);

                if (result != null)
                {
                    // Cập nhật DataGridView với mã và tên nhà phân phối
                    dgPhieuNhap.Rows.Clear(); // Xóa các dòng cũ
                    dgPhieuNhap.Rows.Add(maNhaPhanPhoi, result.ToString()); // Thêm dòng mới
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhà phân phối với mã đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnPhieuNhapThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các thành phần giao diện người dùng
                DateTime ngayLapPhieuNhap = dateNgayLapPhieuNhap.Value;

                // Lấy mã nhà phân phối
                int maNhaPhanPhoi;
                if (!int.TryParse(cbPhieuNhapMaNPP.SelectedValue.ToString(), out maNhaPhanPhoi))
                {
                    MessageBox.Show("Mã nhà phân phối không hợp lệ.");
                    return;
                }

                // Lấy mã sách
                int maSach;
                if (!int.TryParse(cbPhieuNhapMaSach.SelectedValue.ToString(), out maSach))
                {
                    MessageBox.Show("Mã sách không hợp lệ.");
                    return;
                }

                // Lấy số lượng và giá nhập
                int soLuong = (int)numPhieuNhapSoLuong.Value;
                double giaNhap;
                if (!double.TryParse(numPhieuNhapGiaNhap.Text, out giaNhap) || giaNhap <= 0)
                {
                    MessageBox.Show("Giá nhập không hợp lệ.");
                    return;
                }

                // Chuỗi kết nối đến cơ sở dữ liệu
                string connectionString = @"Data Source=DESKTOP-E1A4U7J\SQLSERVER2022;Initial Catalog=db_quan_ly_ban_sach;Integrated Security=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Bắt đầu một giao dịch
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Chèn vào bảng tbl_phieu_nhap
                            string insertPhieuNhapQuery = @"
                        INSERT INTO tbl_phieu_nhap (ngay_lap_phieu_nhap, ma_nha_phan_phoi) 
                        OUTPUT INSERTED.ma_phieu_nhap 
                        VALUES (@ngayLapPhieuNhap, @maNhaPhanPhoi)";

                            SqlCommand insertPhieuNhapCommand = new SqlCommand(insertPhieuNhapQuery, connection, transaction);
                            insertPhieuNhapCommand.Parameters.AddWithValue("@ngayLapPhieuNhap", ngayLapPhieuNhap);
                            insertPhieuNhapCommand.Parameters.AddWithValue("@maNhaPhanPhoi", maNhaPhanPhoi);

                            // Lấy mã phiếu nhập vừa chèn
                            int maPhieuNhap = (int)insertPhieuNhapCommand.ExecuteScalar();

                            // Chèn vào bảng tbl_chi_tiet_phieu_nhap (không chèn cột thanh_tien)
                            string insertChiTietPhieuNhapQuery = @"
                        INSERT INTO tbl_chi_tiet_phieu_nhap (ma_phieu_nhap, ma_sach, so_luong, gia_nhap) 
                        VALUES (@maPhieuNhap, @maSach, @soLuong, @giaNhap)";

                            SqlCommand insertChiTietCommand = new SqlCommand(insertChiTietPhieuNhapQuery, connection, transaction);
                            insertChiTietCommand.Parameters.AddWithValue("@maPhieuNhap", maPhieuNhap);
                            insertChiTietCommand.Parameters.AddWithValue("@maSach", maSach);
                            insertChiTietCommand.Parameters.AddWithValue("@soLuong", soLuong);
                            insertChiTietCommand.Parameters.AddWithValue("@giaNhap", giaNhap);

                            insertChiTietCommand.ExecuteNonQuery();

                            // Commit transaction
                            transaction.Commit();

                            // Hiển thị thông báo thành công
                            MessageBox.Show("Thêm phiếu nhập thành công!");

                            // Hiển thị thông tin mới lên dgPhieuNhap
                            loadDgPhieuNhap(); // Gọi hàm để tải dữ liệu mới
                        }
                        catch (Exception ex)
                        {
                            // Rollback transaction nếu có lỗi
                            transaction.Rollback();
                            MessageBox.Show("Lỗi khi thêm phiếu nhập: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }
        private void btnPhieuNhapSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có phiếu nhập nào được chọn hay không
            if (selectedPhieuNhapId == 0)
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập cần sửa.");
                return;
            }

            try
            {
                // Lấy dữ liệu từ các thành phần giao diện người dùng
                DateTime ngayLapPhieuNhap = dateNgayLapPhieuNhap.Value;

                int maNhaPhanPhoi;
                if (!int.TryParse(cbPhieuNhapMaNPP.SelectedValue.ToString(), out maNhaPhanPhoi))
                {
                    MessageBox.Show("Mã nhà phân phối không hợp lệ.");
                    return;
                }

                int maSach;
                if (!int.TryParse(cbPhieuNhapMaSach.SelectedValue.ToString(), out maSach))
                {
                    MessageBox.Show("Mã sách không hợp lệ.");
                    return;
                }

                int soLuong = (int)numPhieuNhapSoLuong.Value;
                double giaNhap;
                if (!double.TryParse(numPhieuNhapGiaNhap.Text, out giaNhap) || giaNhap <= 0)
                {
                    MessageBox.Show("Giá nhập không hợp lệ.");
                    return;
                }

                // Chuỗi kết nối đến cơ sở dữ liệu
                string connectionString = @"Data Source=DESKTOP-E1A4U7J\SQLSERVER2022;Initial Catalog=db_quan_ly_ban_sach;Integrated Security=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Bắt đầu một giao dịch
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Cập nhật bảng tbl_phieu_nhap
                            string updatePhieuNhapQuery = @"
                        UPDATE tbl_phieu_nhap 
                        SET ngay_lap_phieu_nhap = @ngayLapPhieuNhap, ma_nha_phan_phoi = @maNhaPhanPhoi 
                        WHERE ma_phieu_nhap = @maPhieuNhap";

                            SqlCommand updatePhieuNhapCommand = new SqlCommand(updatePhieuNhapQuery, connection, transaction);
                            updatePhieuNhapCommand.Parameters.AddWithValue("@ngayLapPhieuNhap", ngayLapPhieuNhap);
                            updatePhieuNhapCommand.Parameters.AddWithValue("@maNhaPhanPhoi", maNhaPhanPhoi);
                            updatePhieuNhapCommand.Parameters.AddWithValue("@maPhieuNhap", selectedPhieuNhapId);
                            updatePhieuNhapCommand.ExecuteNonQuery();

                            // Cập nhật bảng tbl_chi_tiet_phieu_nhap (không cập nhật cột thanh_tien)
                            string updateChiTietPhieuNhapQuery = @"
                        UPDATE tbl_chi_tiet_phieu_nhap 
                        SET ma_sach = @maSach, so_luong = @soLuong, gia_nhap = @giaNhap 
                        WHERE ma_phieu_nhap = @maPhieuNhap";

                            SqlCommand updateChiTietCommand = new SqlCommand(updateChiTietPhieuNhapQuery, connection, transaction);
                            updateChiTietCommand.Parameters.AddWithValue("@maSach", maSach);
                            updateChiTietCommand.Parameters.AddWithValue("@soLuong", soLuong);
                            updateChiTietCommand.Parameters.AddWithValue("@giaNhap", giaNhap);
                            updateChiTietCommand.Parameters.AddWithValue("@maPhieuNhap", selectedPhieuNhapId);
                            updateChiTietCommand.ExecuteNonQuery();

                            // Commit transaction nếu tất cả đều thành công
                            transaction.Commit();

                            MessageBox.Show("Cập nhật phiếu nhập thành công!");

                            // Tải lại dữ liệu lên DataGridView
                            loadDgPhieuNhap();
                        }
                        catch (Exception ex)
                        {
                            // Rollback transaction nếu có lỗi
                            transaction.Rollback();
                            MessageBox.Show("Lỗi khi cập nhật phiếu nhập: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }




        private void btnPhieuNhapXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có phiếu nhập nào được chọn không
            if (selectedPhieuNhapId == 0)
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập cần xóa.");
                return;
            }

            DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu nhập này?",
                                                         "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.No)
            {
                return;
            }

            string connectionString = @"Data Source=DESKTOP-E1A4U7J\SQLSERVER2022;Initial Catalog=db_quan_ly_ban_sach;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Sử dụng giao dịch để đảm bảo tính nhất quán của dữ liệu
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Xóa các bản ghi liên quan trong bảng tbl_chi_tiet_phieu_nhap trước
                        string deleteChiTietPhieuNhapQuery = @"
                    DELETE FROM tbl_chi_tiet_phieu_nhap 
                    WHERE ma_phieu_nhap = @maPhieuNhap";
                        SqlCommand deleteChiTietCommand = new SqlCommand(deleteChiTietPhieuNhapQuery, connection, transaction);
                        deleteChiTietCommand.Parameters.AddWithValue("@maPhieuNhap", selectedPhieuNhapId);
                        deleteChiTietCommand.ExecuteNonQuery();

                        // Xóa bản ghi trong bảng tbl_phieu_nhap
                        string deletePhieuNhapQuery = @"
                    DELETE FROM tbl_phieu_nhap 
                    WHERE ma_phieu_nhap = @maPhieuNhap";
                        SqlCommand deletePhieuNhapCommand = new SqlCommand(deletePhieuNhapQuery, connection, transaction);
                        deletePhieuNhapCommand.Parameters.AddWithValue("@maPhieuNhap", selectedPhieuNhapId);
                        deletePhieuNhapCommand.ExecuteNonQuery();

                        // Commit transaction nếu tất cả đều thành công
                        transaction.Commit();

                        MessageBox.Show("Xóa phiếu nhập thành công!");

                        // Tải lại dữ liệu lên DataGridView
                        loadDgPhieuNhap();
                    }
                    catch (Exception ex)
                    {
                        // Rollback transaction nếu có lỗi
                        transaction.Rollback();
                        MessageBox.Show("Lỗi khi xóa phiếu nhập: " + ex.Message);
                    }
                }
            }
        }



        private void dgPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có nhấp vào hàng hợp lệ không
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu từ hàng đã chọn
                DataGridViewRow row = dgPhieuNhap.Rows[e.RowIndex];

                // Hiển thị thông tin vào các điều khiển trên form
                selectedPhieuNhapId = Convert.ToInt32(row.Cells["ma_phieu_nhap"].Value);
                dateNgayLapPhieuNhap.Value = Convert.ToDateTime(row.Cells["Ngày Lập Phiếu"].Value);
                cbPhieuNhapMaNPP.SelectedValue = row.Cells["Mã nhà phân phối"].Value.ToString();
                cbPhieuNhapMaSach.SelectedValue = row.Cells["Mã sách"].Value.ToString();
                numPhieuNhapSoLuong.Value = Convert.ToDecimal(row.Cells["Số lượng"].Value);
                numPhieuNhapGiaNhap.Value = Convert.ToDecimal(row.Cells["Giá nhập"].Value);
            }
        }

        private void btnPhieuNhapRefresh_Click(object sender, EventArgs e)
        {
            // Làm mới lại các thành phần giao diện người dùng
            dateNgayLapPhieuNhap.Value = DateTime.Now; // Đặt ngày lập phiếu về ngày hiện tại
            cbPhieuNhapMaNPP.SelectedIndex = -1; // Xóa chọn mục hiện tại của ComboBox nhà phân phối
            cbPhieuNhapMaSach.SelectedIndex = -1; // Xóa chọn mục hiện tại của ComboBox mã sách
            numPhieuNhapSoLuong.Value = 0; // Đặt số lượng về 1 hoặc giá trị mặc định
            numPhieuNhapGiaNhap.Value = 0;

            // Làm mới dữ liệu trên DataGridView
            loadDgPhieuNhap();

            // Xóa giá trị ID phiếu nhập đã chọn
            selectedPhieuNhapId = 0;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim(); // Lấy từ khóa tìm kiếm từ TextBox và loại bỏ khoảng trắng
            if (string.IsNullOrEmpty(searchTerm))
            {
                // Nếu không có từ khóa tìm kiếm, tải lại toàn bộ dữ liệu
                loadDgPhieuNhap();
                return;
            }

            try
            {
                // Tạo câu truy vấn để tìm kiếm các phiếu nhập dựa trên từ khóa
                string query = @"
            SELECT 
                pn.ma_phieu_nhap AS [Mã phiếu nhập],
                np.ma_nha_phan_phoi AS [Mã nhà phân phối],
                np.ten_nha_phan_phoi AS [Tên Nhà Phân Phối],
                pn.ngay_lap_phieu_nhap AS [Ngày Lập Phiếu],
                s.ma_sach AS [Mã sách], 
                s.ten_sach AS [Tên sách],
                ctpn.so_luong AS [Số lượng]
            FROM 
                tbl_phieu_nhap pn
            JOIN 
                tbl_chi_tiet_phieu_nhap ctpn ON pn.ma_phieu_nhap = ctpn.ma_phieu_nhap
            JOIN 
                tbl_nha_phan_phoi np ON pn.ma_nha_phan_phoi = np.ma_nha_phan_phoi
            JOIN 
                tbl_sach s ON ctpn.ma_sach = s.ma_sach
            WHERE 
                np.ten_nha_phan_phoi LIKE @searchTerm OR 
                s.ten_sach LIKE @searchTerm OR 
                s.ma_sach LIKE @searchTerm OR 
                CAST(pn.ma_phieu_nhap AS NVARCHAR) LIKE @searchTerm OR
                CAST(pn.ngay_lap_phieu_nhap AS NVARCHAR) LIKE @searchTerm";

                // Tạo tham số cho câu truy vấn
                Dictionary<string, object> parameters = new Dictionary<string, object>
        {
            { "@searchTerm", "%" + searchTerm + "%" } // Thêm ký tự % để tìm kiếm linh hoạt
        };

                // Thực hiện truy vấn và lấy kết quả
                DataTable dt = dataProvider.execQuery(query, parameters);

                // Gán DataTable cho DataGridView
                dgPhieuNhap.DataSource = dt;

                // Ẩn cột ma_phieu_nhap nếu không cần hiển thị
                if (dgPhieuNhap.Columns.Contains("Mã phiếu nhập"))
                {
                    dgPhieuNhap.Columns["Mã phiếu nhập"].Visible = false;
                }

                // Thiết lập chế độ tự động điều chỉnh chiều rộng cột
                dgPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Căn giữa nội dung cho các cột
                foreach (DataGridViewColumn column in dgPhieuNhap.Columns)
                {
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm phiếu nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}