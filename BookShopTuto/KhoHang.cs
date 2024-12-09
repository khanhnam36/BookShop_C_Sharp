using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace BookShopTuto
{
    public partial class KhoHang : Form
    {
        private string connectionString = @"Data Source=DESKTOP-E1A4U7J\SQLSERVER2022;Initial Catalog=db_quan_ly_ban_sach;Integrated Security=True;";
        private DataProvider dataProvider = new DataProvider();

        public KhoHang()
        {
            InitializeComponent();
            LoadDgKhoHang();
            //LoadMaSach();
        }

        private void LoadDgKhoHang()
        {
            try
            {
                // Tạo câu truy vấn SQL để lấy dữ liệu về tổng số lượng nhập, bán và số lượng còn lại
                StringBuilder query = new StringBuilder(@"
SELECT 
    s.ma_sach AS [Mã Sách], 
    s.ten_sach AS [Tên Sách],
    ISNULL(ctpn.TotalNhap, 0) AS [Tổng Số Lượng Nhập], 
    ISNULL(hd.TotalBan, 0) AS [Tổng Số Lượng Bán], 
    (ISNULL(ctpn.TotalNhap, 0) - ISNULL(hd.TotalBan, 0)) AS [Số Lượng Còn Lại]
FROM tbl_sach s
LEFT JOIN (
    SELECT ma_sach, SUM(so_luong) AS TotalNhap
    FROM tbl_chi_tiet_phieu_nhap
    GROUP BY ma_sach
) ctpn ON s.ma_sach = ctpn.ma_sach
LEFT JOIN (
    SELECT ma_sach, SUM(so_luong) AS TotalBan
    FROM tbl_hoa_don
    GROUP BY ma_sach
) hd ON s.ma_sach = hd.ma_sach;"); 

                // Thực hiện truy vấn và lưu kết quả vào DataTable
                DataTable dt = dataProvider.execQuery(query.ToString());

                // Gán DataTable vào DataGridView
                dgKhoHang.DataSource = dt;

                // Thiết lập chế độ tự động điều chỉnh chiều rộng cột
                dgKhoHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Căn giữa tên đầu bảng
                foreach (DataGridViewColumn column in dgKhoHang.Columns)
                {
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            catch (Exception ex)
            {
                // In ra lỗi nếu có
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }










        //private void LoadMaSach()
        //{
        //    try
        //    {
        //        // Tạo câu truy vấn để lấy tên sách từ bảng sách
        //        string query = "SELECT ma_sach FROM tbl_sach";

        //        // Thực hiện truy vấn và lấy kết quả
        //        DataTable dt = dataProvider.execQuery(query);

        //        // Gán tên sách vào ComboBox
        //        cbKhoHangMaSach.DataSource = dt;
        //        cbKhoHangMaSach.DisplayMember = "ma_sach"; // Cột hiển thị
        //        cbKhoHangMaSach.ValueMember = "ma_sach"; // Cột giá trị
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi khi tải dữ liệu tên sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}



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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhieuNhap phieu_nhap = new PhieuNhap();
            phieu_nhap.ShowDialog();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhaPhanPhoi nha_phan_phoi = new NhaPhanPhoi();
            nha_phan_phoi.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu trang_chu = new TrangChu();
            trang_chu.ShowDialog();
            this.Close();
        }

        //private void btnKhoHangThem_Click(object sender, EventArgs e)
        //{
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            connection.Open();
        //            string query = "INSERT INTO tbl_kho_hang (ma_sach, vi_tri) VALUES (@MaSach, @ViTri)";

        //            using (SqlCommand command = new SqlCommand(query, connection))
        //            {
        //                command.Parameters.AddWithValue("@MaSach", cbKhoHangMaSach.Text);
        //                command.Parameters.AddWithValue("@ViTri", txtKhoHangViTri.Text);

        //                command.ExecuteNonQuery();
        //                MessageBox.Show("Thêm vào kho thành công!");

        //                LoadDgKhoHang(); // Làm mới dữ liệu
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message);
        //        }
        //    }
        //}


        //private void btnKhoHangSua_Click(object sender, EventArgs e)
        //{
        //    if (dgKhoHang.CurrentRow != null) // Check if a row is selected
        //    {
        //        // Retrieve the selected row's "ma_kho" value
        //        int maKho = Convert.ToInt32(dgKhoHang.CurrentRow.Cells["ma_kho"].Value);

        //        using (SqlConnection connection = new SqlConnection(connectionString))
        //        {
        //            try
        //            {
        //                connection.Open();
        //                string query = "UPDATE tbl_kho_hang SET vi_tri = @ViTri WHERE ma_kho = @MaKho";

        //                using (SqlCommand command = new SqlCommand(query, connection))
        //                {
        //                    command.Parameters.AddWithValue("@ViTri", txtKhoHangViTri.Text);
        //                    command.Parameters.AddWithValue("@MaKho", maKho); // Add the @MaKho parameter

        //                    command.ExecuteNonQuery();
        //                    MessageBox.Show("Cập nhật thông tin kho thành công!");

        //                    LoadDgKhoHang(); // Refresh the data in DataGridView
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message);
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui lòng chọn một sách để sửa!");
        //    }
        //}



        //private void btnKhoHangXoa_Click(object sender, EventArgs e)
        //{
        //    if (dgKhoHang.CurrentRow != null) // Kiểm tra xem có hàng nào được chọn không
        //    {
        //        // Lấy mã kho từ hàng được chọn
        //        int maKho = Convert.ToInt32(dgKhoHang.CurrentRow.Cells["ma_kho"].Value);

        //        using (SqlConnection connection = new SqlConnection(connectionString))
        //        {
        //            try
        //            {
        //                connection.Open();
        //                string query = "DELETE FROM tbl_kho_hang WHERE ma_kho = @MaKho";

        //                using (SqlCommand command = new SqlCommand(query, connection))
        //                {
        //                    command.Parameters.AddWithValue("@MaKho", maKho); // Sử dụng mã kho đã lấy

        //                    command.ExecuteNonQuery();
        //                    MessageBox.Show("Xóa sách khỏi kho thành công!");

        //                    LoadDgKhoHang(); // Làm mới dữ liệu
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message);
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui lòng chọn một sách để xóa!");
        //    }
        //}



        //private void btnKhoHangRefresh_Click(object sender, EventArgs e)
        //{
        //    // Đặt lại giá trị của các ô nhập liệu
        //    cbKhoHangMaSach.SelectedIndex = 0;
        //    txtKhoHangViTri.Clear();

        //    // Tải lại dữ liệu vào DataGridView
        //    LoadDgKhoHang();
        //}

        //private void dgKhoHang_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    // Lấy hàng hiện tại
        //    DataGridViewRow row = dgKhoHang.Rows[e.RowIndex];

        //    // Gán giá trị từ các cột vào các TextBox tương ứng
        //    cbKhoHangMaSach.Text = row.Cells["Mã sách"].Value.ToString();
        //    txtKhoHangViTri.Text = row.Cells["Vị trí"].Value.ToString();
        //}

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Gọi hàm tìm kiếm khi giá trị trong TextBox thay đổi
            SearchData(txtSearch.Text);
        }

        private void SearchData(string searchValue)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // Câu truy vấn tìm kiếm theo Mã Sách và Tên Sách
                    string query = @"
            SELECT 
                s.ma_sach AS [Mã Sách], 
                s.ten_sach AS [Tên Sách],
                ISNULL(SUM(csn.so_luong), 0) AS [Tổng Số Lượng Nhập], 
                ISNULL(SUM(hd.so_luong), 0) AS [Tổng Số Lượng Bán], 
                (ISNULL(SUM(csn.so_luong), 0) - ISNULL(SUM(hd.so_luong), 0)) AS [Số Lượng Còn Lại] 
            FROM tbl_sach s
            LEFT JOIN tbl_chi_tiet_phieu_nhap csn ON s.ma_sach = csn.ma_sach
            LEFT JOIN tbl_hoa_don hd ON s.ma_sach = hd.ma_sach
            WHERE s.ma_sach LIKE @SearchValue OR s.ten_sach LIKE @SearchValue
            GROUP BY s.ma_sach, s.ten_sach";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số tìm kiếm với ký tự wildcard
                        command.Parameters.AddWithValue("@SearchValue", "%" + searchValue + "%");

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        // Gán dữ liệu tìm kiếm cho DataGridView
                        dgKhoHang.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
                }
            }
        }

    }
}
