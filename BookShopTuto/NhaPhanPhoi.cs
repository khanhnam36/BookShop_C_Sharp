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
    public partial class NhaPhanPhoi : Form
    {
        private DataProvider dataProvider = new DataProvider(); // Khởi tạo DataProvider
        private int maNhaPhanPhoi;

        public NhaPhanPhoi()
        {
            InitializeComponent();
            LoadNhaPhanPhoi();
            txtNPPMa.ReadOnly = true;
        }

        private void LoadNhaPhanPhoi()
        {
            // Tạo câu truy vấn để lấy dữ liệu từ bảng tbl_nha_phan_phoi
            string query = "SELECT ma_nha_phan_phoi AS [Mã Nhà Phân Phối], " +
                           "ten_nha_phan_phoi AS [Tên Nhà Phân Phối], " +
                           "dia_chi AS [Địa Chỉ], " +
                           "so_dien_thoai AS [Số Điện Thoại] FROM tbl_nha_phan_phoi";

            try
            {
                // Sử dụng DataProvider để thực hiện truy vấn
                DataTable dataTable = dataProvider.execQuery(query);

                // Gán DataTable cho DataGridView
                dgNPP.DataSource = dataTable;

                // Thiết lập chế độ tự động điều chỉnh chiều rộng cột
                dgNPP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Căn giữa tên đầu bảng
                foreach (DataGridViewColumn column in dgNPP.Columns)
                {
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                // Cập nhật giá trị mã nhà phân phối cho txtNPPMa
                string maxQuery = "SELECT MAX(ma_nha_phan_phoi) FROM tbl_nha_phan_phoi";
                DataTable maxTable = dataProvider.execQuery(maxQuery);

                // Kiểm tra xem có mã nào trong bảng không
                if (maxTable.Rows.Count > 0 && maxTable.Rows[0][0] != DBNull.Value)
                {
                    int nextMaNPP = Convert.ToInt32(maxTable.Rows[0][0]) + 1; // Tăng giá trị lên 1
                    txtNPPMa.Text = nextMaNPP.ToString(); // Gán giá trị cho txtNPPMa
                }
                else
                {
                    txtNPPMa.Text = "1"; // Nếu chưa có nhà phân phối nào, khởi tạo mã là 1
                }

                // Thiết lập txtNPPMa là ReadOnly để không cho phép người dùng nhập liệu
                txtNPPMa.ReadOnly = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Books sach = new Books();
            sach.ShowDialog();
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LoaiSach loai_sach = new LoaiSach();
            loai_sach.ShowDialog();
            this.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            HoaDon hoa_don = new HoaDon();
            hoa_don.ShowDialog();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PhieuNhap phieu_nhap = new PhieuNhap();
            phieu_nhap.ShowDialog();
            this.Close();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            KhoHang kho_hang = new KhoHang();
            kho_hang.ShowDialog();
            this.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu trang_chu = new TrangChu();
            trang_chu.ShowDialog();
            this.Close();
        }

        private void btnNPPThem_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các ô nhập liệu
            string maNPP = txtNPPMa.Text;
            string tenNPP = txtNPPTen.Text;
            string diaChi = txtNPPDiaChi.Text;
            string soDienThoai = txtNPPSDT.Text;

            // Kiểm tra xem các ô nhập liệu có trống không
            if (string.IsNullOrEmpty(tenNPP) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(soDienThoai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhà phân phối!");
                return;
            }

            // Câu truy vấn để chèn dữ liệu vào bảng
            string query = "INSERT INTO tbl_nha_phan_phoi (ma_nha_phan_phoi, ten_nha_phan_phoi, dia_chi, so_dien_thoai) " +
                           "VALUES (@maNPP,@tenNPP, @diaChi, @soDienThoai)";

            try
            {
                // Sử dụng Dictionary<string, object> để lưu các tham số
                Dictionary<string, object> parameters = new Dictionary<string, object>
        {
            { "@maNPP", maNPP },
            { "@tenNPP", tenNPP },
            { "@diaChi", diaChi },
            { "@soDienThoai", soDienThoai }
        };

                // Thực hiện truy vấn thêm dữ liệu
                int rowsAffected = dataProvider.execNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm nhà phân phối thành công!");
                    LoadNhaPhanPhoi(); // Cập nhật lại danh sách nhà phân phối

                    // Đặt lại giá trị cho txtNPPMa (hoặc có thể để trống)
                    txtNPPMa.Text = string.Empty; // Hoặc gán một giá trị cố định nào đó nếu cần
                }
                else
                {
                    MessageBox.Show("Thêm nhà phân phối thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnNPPSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu các trường nhập liệu để trống
                if (string.IsNullOrWhiteSpace(txtNPPTen.Text) || string.IsNullOrWhiteSpace(txtNPPDiaChi.Text) ||
                    string.IsNullOrWhiteSpace(txtNPPSDT.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy dữ liệu từ các trường nhập liệu
                string tenNPP = txtNPPTen.Text;
                string diaChiNPP = txtNPPDiaChi.Text;
                string sdtNPP = txtNPPSDT.Text;

                // Lấy mã nhà phân phối từ ô txtNPPMa
                int maNhaPhanPhoi = Convert.ToInt32(txtNPPMa.Text);

                // Câu lệnh cập nhật thông tin nhà phân phối
                string query = "UPDATE tbl_nha_phan_phoi SET ten_nha_phan_phoi = @tenNPP, dia_chi = @diaChiNPP, " +
                               "so_dien_thoai = @sdtNPP WHERE ma_nha_phan_phoi = @maNPP";

                // Thêm các tham số cho câu lệnh truy vấn
                var parameters = new Dictionary<string, object>
        {
            { "@tenNPP", tenNPP },
            { "@diaChiNPP", diaChiNPP },
            { "@sdtNPP", sdtNPP },
            { "@maNPP", maNhaPhanPhoi }
        };

                // Gọi hàm thực hiện truy vấn
                int rowsAffected = dataProvider.execNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật nhà phân phối thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNhaPhanPhoi(); // Tải lại dữ liệu trong DataGridView
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công. Vui lòng kiểm tra lại thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật nhà phân phối: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNPPXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu không có nhà phân phối nào được chọn
                if (string.IsNullOrWhiteSpace(txtNPPMa.Text))
                {
                    MessageBox.Show("Vui lòng chọn nhà phân phối cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy mã nhà phân phối từ ô txtNPPMa
                int maNhaPhanPhoi = Convert.ToInt32(txtNPPMa.Text);

                // Xác nhận xóa nhà phân phối
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà phân phối này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    // Câu lệnh xóa nhà phân phối
                    string query = "DELETE FROM tbl_nha_phan_phoi WHERE ma_nha_phan_phoi = @maNPP";

                    // Thêm tham số cho câu lệnh truy vấn
                    var parameters = new Dictionary<string, object>
            {
                { "@maNPP", maNhaPhanPhoi }
            };

                    // Gọi hàm thực hiện truy vấn
                    int rowsAffected = dataProvider.execNonQuery(query, parameters);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa nhà phân phối thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadNhaPhanPhoi(); // Tải lại dữ liệu trong DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhà phân phối để xóa. Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa nhà phân phối: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNPPRefresh_Click(object sender, EventArgs e)
        {
            txtNPPMa.Clear();
            txtNPPTen.Clear();
            txtNPPDiaChi.Clear();
            txtNPPSDT.Clear();

            // Bỏ chọn bất kỳ hàng nào trong DataGridView
            dgNPP.ClearSelection();

            // Tải lại dữ liệu vào DataGridView
            LoadNhaPhanPhoi();
        }

        private void dgNPP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có bấm vào hàng hợp lệ không
            if (e.RowIndex >= 0) // e.RowIndex < 0 nghĩa là tiêu đề cột được click
            {
                // Lấy dữ liệu từ hàng đã click
                DataGridViewRow row = dgNPP.Rows[e.RowIndex];

                // Hiển thị dữ liệu lên các TextBox
                txtNPPMa.Text = row.Cells["Mã Nhà Phân Phối"].Value?.ToString() ?? string.Empty;
                txtNPPTen.Text = row.Cells["Tên Nhà Phân Phối"].Value?.ToString() ?? string.Empty;
                txtNPPDiaChi.Text = row.Cells["Địa Chỉ"].Value?.ToString() ?? string.Empty;
                txtNPPSDT.Text = row.Cells["Số Điện Thoại"].Value?.ToString() ?? string.Empty;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Lấy giá trị tìm kiếm từ ô txtSearch
            string searchValue = txtSearch.Text;

            // Tạo câu truy vấn để tìm kiếm nhà phân phối theo tên
            string query = "SELECT ma_nha_phan_phoi AS [Mã Nhà Phân Phối], " +
                           "ten_nha_phan_phoi AS [Tên Nhà Phân Phối], " +
                           "dia_chi AS [Địa Chỉ], " +
                           "so_dien_thoai AS [Số Điện Thoại] " +
                           "FROM tbl_nha_phan_phoi " +
                           "WHERE ten_nha_phan_phoi LIKE @searchValue";

            // Tạo từ điển tham số cho câu truy vấn
            var parameters = new Dictionary<string, object>
    {
        { "@searchValue", "%" + searchValue + "%" }
    };

            try
            {
                // Sử dụng DataProvider để thực hiện truy vấn
                DataTable dataTable = dataProvider.execQuery(query, parameters);

                // Gán DataTable cho DataGridView
                dgNPP.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

    }
}
