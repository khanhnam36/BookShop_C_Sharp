using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopTuto
{

    public partial class Books : Form
    {
        private DataProvider dataProvider = new DataProvider();
        private string stLoaiSach;
        // Khai báo biến trạng thái
        private bool isZoomed = false;
        // Khai báo biến toàn cục để theo dõi trạng thái thu nhỏ
        private bool isMinimized = false;

        public Books()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            initSach();
            loadDgSach(); // Gọi hàm này khi khởi tạo để nạp dữ liệu lên DataGridView
        }


        private void initSach()
        {
            loadDgSach();
            loadcbSachLoaiSach();
        }

        private void loadDgSach()
        {
            StringBuilder query = new StringBuilder("SELECT ma_sach as [Mã Sách], ten_sach as [Tên Sách], ");
            query.Append("ten_loai_sach as [Loại Sách], tac_gia as [Tác Giả], gia_ban as [Giá Bán] ");
            query.Append("FROM tbl_sach, tbl_loai_sach ");
            query.Append("WHERE tbl_sach.ma_loai_sach = tbl_loai_sach.ma_loai_sach;");

            DataTable dt = dataProvider.execQuery(query.ToString());
            dgSach.DataSource = dt;

            // Căn giữa tên đầu bảng
            foreach (DataGridViewColumn column in dgSach.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void loadcbSachLoaiSach()
        {
            DataTable dt = dataProvider.execQuery("SELECT * FROM tbl_loai_sach");
            cbSachLoaiSach.DisplayMember = "ten_loai_sach";
            cbSachLoaiSach.ValueMember = "ma_loai_sach";
            cbSachLoaiSach.DataSource = dt;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSachThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu các TextBox để trống
                if (string.IsNullOrWhiteSpace(txtSachTenSach.Text) || string.IsNullOrWhiteSpace(txtSachTacGia.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string tenSach = txtSachTenSach.Text;
                int maLoaiSach = (int)cbSachLoaiSach.SelectedValue;
                string tacGia = txtSachTacGia.Text;
                float giaBan = (float)numSachGiaBan.Value;

                string query = "INSERT INTO tbl_sach (ten_sach, ma_loai_sach, tac_gia, gia_ban) VALUES (@tenSach, @maLoaiSach, @tacGia, @giaBan)";
                var parameters = new Dictionary<string, object>
        {
            { "@tenSach", tenSach },
            { "@maLoaiSach", maLoaiSach },
            { "@tacGia", tacGia },
            { "@giaBan", giaBan }
        };

                dataProvider.execNonQuery(query, parameters);
                loadDgSach();
                MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSachSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgSach.CurrentRow != null)
                {
                    // Kiểm tra nếu các TextBox để trống
                    if (string.IsNullOrWhiteSpace(txtSachTenSach.Text) || string.IsNullOrWhiteSpace(txtSachTacGia.Text))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int maSach = (int)dgSach.CurrentRow.Cells[0].Value;
                    string tenSach = txtSachTenSach.Text;
                    int maLoaiSach = (int)cbSachLoaiSach.SelectedValue;
                    string tacGia = txtSachTacGia.Text;
                    float giaBan = (float)numSachGiaBan.Value;

                    string query = "UPDATE tbl_sach SET ten_sach = @tenSach, ma_loai_sach = @maLoaiSach, tac_gia = @tacGia, gia_ban = @giaBan WHERE ma_sach = @maSach";
                    var parameters = new Dictionary<string, object>
            {
                { "@tenSach", tenSach },
                { "@maLoaiSach", maLoaiSach },
                { "@tacGia", tacGia },
                { "@giaBan", giaBan },
                { "@maSach", maSach }
            };

                    dataProvider.execNonQuery(query, parameters);
                    loadDgSach();
                    MessageBox.Show("Sửa thông tin sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSachXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgSach.CurrentRow != null)
                {
                    int maSach = (int)dgSach.CurrentRow.Cells[0].Value;
                    string query = "DELETE FROM tbl_sach WHERE ma_sach = @maSach";
                    var parameters = new Dictionary<string, object>
            {
                { "@maSach", maSach }
            };

                    dataProvider.execNonQuery(query, parameters);
                    loadDgSach();
                    MessageBox.Show("Xóa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSachRefresh_Click(object sender, EventArgs e)
        {
            // Đặt các TextBox rỗng
            txtSachTenSach.Text = string.Empty;
            txtSachTacGia.Text = string.Empty;

            // Đặt ComboBox về trạng thái chưa chọn
            cbSachLoaiSach.SelectedIndex = -1; // Không chọn mục nào trong ComboBox

            // Đặt các NumericUpDown về 0
            numSachGiaBan.Value = 0;

            // Bỏ chọn bất kỳ hàng nào trong DataGridView nếu có
            dgSach.ClearSelection();

            // Tải lại dữ liệu vào DataGridView nếu cần
            loadDgSach();
        }

        private void dgSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra rằng hàng được chọn hợp lệ
            {
                DataGridViewRow row = dgSach.Rows[e.RowIndex];

                // Debugging: Kiểm tra số lượng cột trong hàng được chọn
                Console.WriteLine($"Số lượng cột trong hàng: {row.Cells.Count}");

                // Kiểm tra số lượng cột có đủ để tránh lỗi chỉ số ngoài phạm vi
                if (row.Cells.Count >= 5) // Đảm bảo có đủ cột trước khi truy cập
                {
                    txtSachTenSach.Text = row.Cells[1].Value?.ToString() ?? string.Empty; // Sử dụng toán tử null-coalescing để tránh lỗi
                    cbSachLoaiSach.Text = row.Cells[2].Value?.ToString() ?? string.Empty;
                    txtSachTacGia.Text = row.Cells[3].Value?.ToString() ?? string.Empty;
                    // Kiểm tra giá trị của cột gia_ban có hợp lệ không
                    if (decimal.TryParse(row.Cells[4].Value?.ToString(), out decimal giaBan))
                    {
                        numSachGiaBan.Value = giaBan;
                    }
                    else
                    {
                        numSachGiaBan.Value = 0; // Nếu không chuyển đổi được, đặt về 0
                    }
                }
                else
                {
                    MessageBox.Show("Không đủ cột trong hàng được chọn.");
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            StringBuilder query = new StringBuilder("SELECT ma_sach as [Mã Sách], ten_sach as [Tên Sách], ");
            query.Append("ten_loai_sach as [Loại Sách], tac_gia as [Tác Giả], gia_ban as [Giá Bán] ");
            query.Append("FROM tbl_sach, tbl_loai_sach ");
            query.Append("WHERE tbl_sach.ma_loai_sach = tbl_loai_sach.ma_loai_sach ");

            // Thêm điều kiện tìm kiếm cho tất cả các cột
            if (!string.IsNullOrEmpty(keyword))
            {
                query.Append("AND (ma_sach LIKE @keyword ");
                query.Append("OR ten_sach LIKE @keyword ");
                query.Append("OR ten_loai_sach LIKE @keyword ");
                query.Append("OR tac_gia LIKE @keyword ");
                query.Append("OR gia_ban LIKE @keyword)");
            }

            // Thực hiện truy vấn và hiển thị kết quả trong DataGridView
            var parameters = new Dictionary<string, object>
    {
        { "@keyword", "%" + keyword + "%" }
    };

            DataTable dt = dataProvider.execQuery(query.ToString(), parameters);
            dgSach.DataSource = dt;
        }



        private void cbSachLoaiSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            stLoaiSach = comboBox.SelectedValue.ToString();
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Thiết lập trạng thái của Form thành thu nhỏ
            this.WindowState = FormWindowState.Minimized;
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

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu trang_chu = new TrangChu();
            trang_chu.ShowDialog();
            this.Close();
        }
    }
}
