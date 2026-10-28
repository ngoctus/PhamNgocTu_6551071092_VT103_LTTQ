using Microsoft.EntityFrameworkCore;
using QuanLyThuVien.Models;
using System.Globalization;

namespace QuanLyThuVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ========== Cau 4 ========
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraNhap(out string ma, out string ten, out string gia))
                return;

            try
            {
                using (var db = new DuLieuContext())
                {
                    if (db.CongViecs.Any(s => s.MaSach == ma))
                    {
                        MessageBox.Show("Mã sách\"" + ma + "\" đã tồn tại. Vui lòng nhập lại!",
                            "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaSach.Focus();
                        txtMaSach.SelectAll();
                        return;
                    }

                    db.CongViecs.Add(new CongViec
                    {
                        MaSach = ma,
                        TenSach = ten,
                        GiaTien = gia
                    });
                    db.SaveChanges();
                }

                LoadDanhSach();
                txtMaSach.Clear();
                txtTenSach.Clear();
                txtGiaTien.Clear();
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sách" + ex.Message, "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // ============ Cau 7 ============
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhap(out string ma, out string ten, out string gia))
                return;

            try
            {
                using (var db = new DuLieuContext())
                {
                    var s = db.CongViecs.Find(ma);
                    if (s != null)
                    {
                        s.TenSach = ten;
                        s.GiaTien = gia;
                        db.SaveChanges();
                    }
                }

                LoadDanhSach();
                DatTrangThaiBanDau();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật sách: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============ Cau 6 ============
        private void btnXoa_Click(object sender, EventArgs e)
        {
            var kq = MessageBox.Show("Bạn có muốn xóa quyển sách này không?", "Xóa quyển sách",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq != DialogResult.Yes) return;
            try
            {
                string ma = txtMaSach.Text.Trim();
                using (var db = new DuLieuContext())
                {
                    var s = db.CongViecs.Find(ma);
                    if (s != null)
                    {
                        db.CongViecs.Remove(s);
                        db.SaveChanges();
                    }
                }

                LoadDanhSach();
                DatTrangThaiBanDau();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa sách: " + ex.Message, "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============= CAU 3 ==============
        private void btnThoat_Click(object sender, EventArgs e)
        {
            var kq = MessageBox.Show("Bạn có muốn thoát không?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //=============== CAU 1 ===============
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
            DatTrangThaiBanDau();
        }

        private void LoadDanhSach()
        {
            try
            {
                using var db = new DuLieuContext();
                dgvSach.DataSource = db.CongViecs
                    .AsNoTracking()
                    .OrderBy(s => s.MaSach)
                    .ToList();
                dgvSach.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được dữ liệu" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DatTrangThaiBanDau()
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtGiaTien.Clear();
            txtMaSach.ReadOnly = false;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            btnThoat.Enabled = true;
        }

        // ============ Cau 2 ===============

        private void txtGiaTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            if (e.KeyChar >= 0 || e.KeyChar <= 9) return;

            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                if (!txtGiaTien.Text.Contains('.') && !txtGiaTien.Text.Contains(','))
                    return;
            }

            e.Handled = true;
        }

        // ========= Cau 4 ===========
        private bool KiemTraNhap(out string ma, out string ten, out string gia)
        {
            ma = txtMaSach.Text.Trim();
            ten = txtTenSach.Text.Trim();
            gia = txtGiaTien.Text.Trim().Replace(',', '.');

            if (ma == "" || ten == "" || gia == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (ma == "") txtMaSach.Focus();
                else if (ten == "") txtTenSach.Focus();
                else txtGiaTien.Focus();
                return false;
            }

            if (!double.TryParse(gia, NumberStyles.Float, CultureInfo.InvariantCulture, out _))
            {
                MessageBox.Show("Giá tiền phải là số nguyên hoặc số thực!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaTien.Focus();
                return false;
            }

            return true;
        }

        // ============ Cau 5 ===========
        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvSach.Rows[e.RowIndex];
            txtMaSach.Text = Convert.ToString(row.Cells["colMaSach"].Value);
            txtTenSach.Text = Convert.ToString(row.Cells["colTenSach"].Value);
            txtGiaTien.Text = Convert.ToString(row.Cells["colGiaTien"].Value);

            txtMaSach.ReadOnly = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
        }

        

    }
}
