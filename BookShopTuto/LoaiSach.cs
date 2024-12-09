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
    public partial class LoaiSach : Form
    {
        private DataProvider dataProvider = new DataProvider();

        public LoaiSach()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            loadDgLoaiSach(); // Gọi hàm này khi khởi tạo để nạp dữ liệu lên DataGridView
        }

        private void loadDgLoaiSach()
        {
            StringBuilder query = new StringBuilder("SELECT ma_loai_sach as [Mã Loại Sách], ten_loai_sach as [Tên Loại Sách] FROM tbl_loai_sach;");
            DataTable dt = dataProvider.execQuery(query.ToString());
            dgLoaiSach.DataSource = dt;

            // Thiết lập chế độ tự động điều chỉnh chiều rộng cột
            dgLoaiSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Căn giữa tên đầu bảng
            foreach (DataGridViewColumn column in dgLoaiSach.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void btnLoaiSachThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                string tenLoaiSach = txtLoaiSachTen.Text;

                if (string.IsNullOrWhiteSpace(tenLoaiSach))
                {
                    MessageBox.Show("Tên loại sách không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "INSERT INTO tbl_loai_sach (ten_loai_sach) VALUES (@tenLoaiSach)";
                var parameters = new Dictionary<string, object>
                {
                    { "@tenLoaiSach", tenLoaiSach }
                };

                dataProvider.execNonQuery(query, parameters);
                loadDgLoaiSach();
                MessageBox.Show("Thêm loại sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm loại sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoaiSachSua_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgLoaiSach.CurrentRow != null)
                {
                    int maLoaiSach = (int)dgLoaiSach.CurrentRow.Cells[0].Value;
                    string tenLoaiSach = txtLoaiSachTen.Text;

                    if (string.IsNullOrWhiteSpace(tenLoaiSach))
                    {
                        MessageBox.Show("Tên loại sách không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string query = "UPDATE tbl_loai_sach SET ten_loai_sach = @tenLoaiSach WHERE ma_loai_sach = @maLoaiSach";
                    var parameters = new Dictionary<string, object>
                    {
                        { "@tenLoaiSach", tenLoaiSach },
                        { "@maLoaiSach", maLoaiSach }
                    };

                    dataProvider.execNonQuery(query, parameters);
                    loadDgLoaiSach();
                    MessageBox.Show("Sửa thông tin loại sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa loại sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoaiSachXóa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgLoaiSach.CurrentRow != null)
                {
                    int maLoaiSach = (int)dgLoaiSach.CurrentRow.Cells[0].Value;
                    string query = "DELETE FROM tbl_loai_sach WHERE ma_loai_sach = @maLoaiSach";
                    var parameters = new Dictionary<string, object>
            {
                { "@maLoaiSach", maLoaiSach }
            };

                    dataProvider.execNonQuery(query, parameters);
                    loadDgLoaiSach();
                    MessageBox.Show("Xóa loại sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa loại sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoaiSachRefresh_Click(object sender, EventArgs e)
        {
            txtLoaiSachTen.Text = string.Empty;

            dgLoaiSach.ClearSelection();

            loadDgLoaiSach();
        }


        private void dgLoaiSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgLoaiSach.Rows[e.RowIndex];
                txtLoaiSachTen.Text = row.Cells[1].Value.ToString();
            }
        }

        private void txtSachTenSach_TextChanged(object sender, EventArgs e)
        {

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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu trang_chu = new TrangChu();
            trang_chu.ShowDialog();
            this.Close();
        }

        private void dgLoaiSach_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgLoaiSach.Rows[e.RowIndex];
                txtLoaiSachTen.Text = row.Cells[1].Value.ToString();
            }
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            StringBuilder query = new StringBuilder("SELECT ma_loai_sach as [Mã Loại Sách], ten_loai_sach as [Tên Loại Sách] ");
            query.Append("FROM tbl_loai_sach ");

            // Thêm điều kiện tìm kiếm nếu từ khóa không rỗng
            if (!string.IsNullOrEmpty(keyword))
            {
                query.Append("WHERE ma_loai_sach LIKE @keyword OR ten_loai_sach LIKE @keyword");
            }

            // Thực hiện truy vấn với tham số
            var parameters = new Dictionary<string, object>
    {
        { "@keyword", "%" + keyword + "%" }
    };

            DataTable dt = dataProvider.execQuery(query.ToString(), parameters);
            dgLoaiSach.DataSource = dt;
        }
    }
}
