using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmRoom : Form
    {
        private LinqToQLKSDataContext db;
        public frmRoom()
        {
            InitializeComponent();
        }

        private void AnHien(bool value)
        {
            txtMaPhong.Enabled = value;
            txtTenPhong.Enabled = value;
            txtGiaPhong.Enabled = value;
            cboLoaiPhong.Enabled = value;
            cboTinhTrang.Enabled = value;
        }

        private void SetEmpty()
        {
            txtMaPhong.Text = "";
            txtTenPhong.Text = "";
            txtGiaPhong.Text = "";
            cboLoaiPhong.Text = "";
            cboTinhTrang.Text = "";
        }

        private void KhoaCN(bool value)
        {
            btnThem.Enabled = value;
            btnSua.Enabled = value;
            btnXoa.Enabled = value;
        }

        private void frmRoom_Load(object sender, EventArgs e)
        {
            db = new LinqToQLKSDataContext(SQLHelper.ConnectString);
            List<Phong> phongs = db.Phongs.ToList();
            PhongbindingSource.DataSource = phongs;
            AnHien(false);
            dataGridViewPhong.AutoGenerateColumns = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                btnThem.Text = "Lưu lại";
                AnHien(true);
                KhoaCN(false);
                btnThem.Enabled = true;
                SetEmpty();
                dataGridViewPhong.BeginEdit(true);
                txtMaPhong.Focus();
            }
            else
            {
                if(txtMaPhong.Text.Trim() != "" && txtTenPhong.Text.Trim() != "" 
                    && txtGiaPhong.Text.Trim() != "" && cboLoaiPhong.Text.Trim() != "" && cboTinhTrang.Text.Trim() != "")
                {
                    if (Function.KiemTraGia(txtGiaPhong.Text.Trim()))
                    {
                        Phong KtPhong = db.Phongs.Where(record => record.MaPhong == txtMaPhong.Text.Trim()).SingleOrDefault();
                        if(KtPhong == null)
                        {
                            Phong phong = new Phong();
                            phong.MaPhong = txtMaPhong.Text.Trim();
                            phong.TenPhong = txtTenPhong.Text.Trim();
                            phong.GiaPhong = int.Parse(txtGiaPhong.Text.Trim());
                            phong.LoaiPhong = cboLoaiPhong.Text.Trim();
                            phong.TinhTrang = cboTinhTrang.Text.Trim();
                            db.Phongs.InsertOnSubmit(phong);
                            db.SubmitChanges();
                            AnHien(false);
                            MessageBox.Show("Thêm phòng thành công!", "Thông báo");
                            btnThem.Text = "Thêm";
                            KhoaCN(true);
                            PhongbindingSource.Add(phong);
                            PhongbindingSource.EndEdit();
                        }
                        else
                        {
                            PhongbindingSource.CancelEdit();
                            MessageBox.Show("Phòng đã có trong danh sách. Vui lòng kiểm tra lại.");
                            SetEmpty();
                            txtMaPhong.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhập giá phòng không chính xác", "Lỗi");
                        txtGiaPhong.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Hãy điền đầy đủ thông tin phòng", "Lỗi");
                }
            }
        }

        private void dataGridViewPhong_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridViewPhong.SelectedRows.Count > 0)
            {
                DataGridViewRow currentRow = dataGridViewPhong.CurrentRow;
                if(!Function.IsEmptyRow(currentRow))
                {
                    txtMaPhong.Text = currentRow.Cells[0].Value.ToString();
                    txtTenPhong.Text = currentRow.Cells[1].Value.ToString();
                    cboLoaiPhong.Text = currentRow.Cells[2].Value.ToString();
                    txtGiaPhong.Text = currentRow.Cells[3].Value.ToString();
                    cboTinhTrang.Text = currentRow.Cells[4].Value.ToString();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(btnSua.Text == "Sửa")
            {
                btnSua.Text = "Lưu lại";
                AnHien(true);
                KhoaCN(false);
                txtMaPhong.Enabled = false;
                btnSua.Enabled = true;
            }
            else
            {
                if(dataGridViewPhong.SelectedRows.Count > 0)
                {
                    if (Function.KiemTraGia(txtGiaPhong.Text.Trim()))
                    {
                        Phong phong = db.Phongs.SingleOrDefault(record => record.MaPhong == txtMaPhong.Text.Trim());
                        phong.TenPhong = txtTenPhong.Text.Trim();
                        phong.GiaPhong = int.Parse(txtGiaPhong.Text.Trim());
                        phong.LoaiPhong = cboLoaiPhong.Text.Trim();
                        phong.TinhTrang = cboTinhTrang.Text.Trim();
                        db.SubmitChanges();
                        MessageBox.Show("Sửa thành công!");
                        AnHien(false);
                        KhoaCN(true);
                        btnSua.Text = "Sửa";
                    }
                    else
                    {
                        MessageBox.Show("Nhập giá phòng không đúng", "Lỗi");
                        txtGiaPhong.Text = "";
                        txtGiaPhong.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Không có khách hàng trong danh sách", "Thông báo");
                    AnHien(false); 
                    KhoaCN(true);
                    btnSua.Text = "Sửa";
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            AnHien(false);
            if(dataGridViewPhong.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?",
                    "Xóa phòng",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);
                if(result == DialogResult.OK)
                {
                    List<ThuePhong> dsThuePhong = db.ThuePhongs.Where(record => record.MaPhong == txtMaPhong.Text.Trim()).ToList();
                    if(dsThuePhong != null)
                    {
                        db.ThuePhongs.DeleteAllOnSubmit(dsThuePhong);
                        db.SubmitChanges();
                    }

                    List<SDDV> dsSDDV = db.SDDVs.Where(record => record.MaPhong == txtMaPhong.Text.Trim()).ToList();
                    if(dsSDDV != null )
                    {
                        db.SDDVs.DeleteAllOnSubmit(dsSDDV); 
                        db.SubmitChanges();
                    }

                    Phong phong = db.Phongs.SingleOrDefault(record => record.MaPhong == txtMaPhong.Text.Trim());
                    if(phong != null)
                    {
                        db.Phongs.DeleteOnSubmit(phong); 
                        db.SubmitChanges();
                        MessageBox.Show("Xóa thành công!", "Xóa phòng");
                        PhongbindingSource.Remove(phong);
                        dataGridViewPhong.Refresh();
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
