using Microsoft.EntityFrameworkCore;
using ThiGK.Models;

namespace ThiGK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCongViec();
            try
            {
                using var db = TaoContext();

                bool ketNoiThanhCong = db.Database.CanConnect();

                MessageBox.Show(
                    ketNoiThanhCong
                        ? "Kết nối database thành công!"
                        : "Không kết nối được database!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
            SetButtonState(false);
        }

        private DuLieuContext TaoContext()
        {
            var options = new DbContextOptionsBuilder<DuLieuContext>()
                .UseSqlServer(
                    @"Server=localhost\SQLEXPRESS01;Database=DuLieu;Trusted_Connection=True;TrustServerCertificate=True")
                .Options;

            return new DuLieuContext(options);
        }

        private void LoadCongViec()
        {
            using var db = TaoContext();

            dgvDSCV.DataSource = db.CongViecs
                .AsNoTracking()
                .ToList();
        }

        private void SetButtonState(bool status)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = status;
            btnXoa.Enabled = status;
            btnThoat.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaCV.Text) || string.IsNullOrWhiteSpace(txtTenCV.Text) || string.IsNullOrWhiteSpace(txtLuongThang.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            using var db = TaoContext();
            string maCongViec = txtMaCV.Text.Trim();
            if (db.CongViecs.Any(c => c.MaCongViec == maCongViec))
            {
                MessageBox.Show("Mã công việc đã tồn tại.");
                return;
            }

            if (!int.TryParse(txtLuongThang.Text, out int luongThang))
            {
                MessageBox.Show("Lương tháng phải là một số nguyên.");
                return;
            }

            try
            {
                using var db1 = TaoContext();
                var congViec = new CongViec
                {
                    MaCongViec = txtMaCV.Text,
                    TenCongViec = txtTenCV.Text,
                    LuongThang = txtLuongThang.Text
                };
                db1.CongViecs.Add(congViec);
                db1.SaveChanges();
                LoadCongViec();
                txtMaCV.Clear();
                txtTenCV.Clear();
                txtLuongThang.Clear();
                btnThem.Enabled = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm khách hàng: {ex.Message}");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dgvDSCV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvDSCV.Rows[e.RowIndex];
            txtMaCV.Text = row.Cells["MaCongViec"].Value.ToString();
            txtTenCV.Text = row.Cells["TenCongViec"].Value.ToString();
            txtLuongThang.Text = row.Cells["LuongThang"].Value.ToString();
            SetButtonState(true);
            btnThem.Enabled = false;
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maCV = txtMaCV.Text.Trim();
            if (string.IsNullOrEmpty(maCV))
            {
                MessageBox.Show("Vui lòng chọn công việc để xóa.");
                return;
            }
            var result = MessageBox.Show($"Bạn có muốn xóa công việc này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using var db = TaoContext();
                    var congViec = db.CongViecs.Find(maCV);
                    if (congViec != null)
                    {
                        db.CongViecs.Remove(congViec);
                        db.SaveChanges();
                        LoadCongViec();
                        txtMaCV.Clear();
                        txtTenCV.Clear();
                        txtLuongThang.Clear();
                        SetButtonState(false);
                        
                    }
                    else
                    {
                        MessageBox.Show("Công việc không tồn tại.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa công việc: {ex.Message}");
                }
            }
            txtMaCV.Clear();
            txtTenCV.Clear();
            txtLuongThang.Clear();
            dgvDSCV.ClearSelection();
            SetButtonState(false);
        }



        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaCV.Text) || string.IsNullOrWhiteSpace(txtTenCV.Text) || string.IsNullOrWhiteSpace(txtLuongThang.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }


            if (!int.TryParse(txtLuongThang.Text, out int luongThang))
            {
                MessageBox.Show("Lương tháng phải là một số nguyên.");
                return;
            }
            try
            {
                using var db1 = TaoContext();
                var congViec = db1.CongViecs.Find(txtMaCV.Text);
                if (congViec != null)
                {
                    congViec.TenCongViec = txtTenCV.Text;
                    congViec.LuongThang = txtLuongThang.Text;
                    db1.SaveChanges();
                    LoadCongViec();
                    txtMaCV.Clear();
                    txtTenCV.Clear();
                    txtLuongThang.Clear();
                    MessageBox.Show("Cập nhật thông tin công việc thành công.");
                    SetButtonState(false);
                    dgvDSCV.ClearSelection();
                    btnThem.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Công việc không tồn tại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật thông tin công việc : {ex.Message}");
            }
        }
    }
}
