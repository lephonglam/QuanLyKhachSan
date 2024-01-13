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
    public partial class frmService : Form
    {
        private LinqToQLKSDataContext db;
        public frmService()
        {
            InitializeComponent();
        }

        private void AnHien(bool value)
        {
            txtMaDichVu.Enabled = value;
            txtTenDichVu.Enabled = value;
            txtGiaDichVu.Enabled = value;
            txtDonViTinh.Enabled = value;
        }

        private void SetEmpty()
        {
            txtMaDichVu.Text = "";
            txtTenDichVu.Text = "";
            txtGiaDichVu.Text = "";
            txtDonViTinh.Text = "";
        }

        private void KhoaCN(bool value)
        {
            btnThem.Enabled = value;
            btnSua.Enabled = value;
            btnXoa.Enabled = value;
        }

        private void frmService_Load(object sender, EventArgs e)
        {
            db = new LinqToQLKSDataContext(SQLHelper.ConnectString);
            List<DichVu> dichVus = db.DichVus.ToList();
            DichVubindingSource.DataSource = dichVus;
            dataGridViewDichVu.AutoGenerateColumns = false;
            AnHien(false);
        }

        private void dataGridViewDichVu_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridViewDichVu.SelectedRows.Count > 0)
            {
                DataGridViewRow currentRow = dataGridViewDichVu.CurrentRow;
                if (!Function.IsEmptyRow(currentRow))
                {
                    txtMaDichVu.Text = currentRow.Cells[0].Value.ToString();
                    txtTenDichVu.Text = currentRow.Cells[1].Value.ToString();
                    txtGiaDichVu.Text = currentRow.Cells[2].Value.ToString();
                    txtDonViTinh.Text = currentRow.Cells[3].Value.ToString();
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(btnThem.Text == "Thêm")
            {
                btnThem.Text = "Lưu lại";
                AnHien(true);
                KhoaCN(false);
                SetEmpty();
                btnThem.Enabled = true;
                dataGridViewDichVu.BeginEdit(true);
                txtMaDichVu.Focus();
            }
            else
            {
                if(txtMaDichVu.Text.Trim() != "" && txtTenDichVu.Text.Trim() != "" 
                    && txtGiaDichVu.Text.Trim() != "" && txtDonViTinh.Text.Trim() != "")
                {
                    if (Function.KiemTraGia(txtGiaDichVu.Text))
                    {
                        DichVu KtDichVu = db.DichVus.SingleOrDefault(record => record.MaDV == txtMaDichVu.Text);
                        if(KtDichVu == null)
                        {
                            DichVu dichVu = new DichVu();
                            dichVu.MaDV = txtMaDichVu.Text.Trim();
                            dichVu.TenDV = txtTenDichVu.Text.Trim();
                            dichVu.GiaDV = int.Parse(txtGiaDichVu.Text.Trim());
                            dichVu.DVT = txtDonViTinh.Text.Trim();
                            db.DichVus.InsertOnSubmit(dichVu);
                            db.SubmitChanges();
                            MessageBox.Show("Thêm dịch vụ thành công", "Thêm dịch vụ");
                            AnHien(false);
                            KhoaCN(true);
                            btnThem.Text = "Thêm";
                            DichVubindingSource.Add(dichVu);
                            DichVubindingSource.EndEdit();
                        }
                        else
                        {
                            DichVubindingSource.EndEdit();
                            MessageBox.Show("Dịch vụ đã có trong danh sách. Vui lòng kiểm tra lại");
                            SetEmpty();
                            txtMaDichVu.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhập sai giá dịch vụ", "Lỗi");
                        txtGiaDichVu.Text = "";
                        txtGiaDichVu.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Hãy điền đầy đủ thông tin dịch vụ", "Lỗi");
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
                txtMaDichVu.Enabled = false;
                btnSua.Enabled = true;
            }
            else
            {
                if(dataGridViewDichVu.SelectedRows.Count > 0)
                {
                    if (Function.KiemTraGia(txtGiaDichVu.Text.Trim()))
                    {
                        DichVu dichVu = db.DichVus.SingleOrDefault(record => record.MaDV ==  txtMaDichVu.Text.Trim());
                        dichVu.TenDV = txtMaDichVu.Text.Trim();
                        dichVu.GiaDV = int.Parse(txtGiaDichVu.Text.Trim());
                        dichVu.DVT = txtDonViTinh.Text.Trim();
                        db.SubmitChanges();
                        MessageBox.Show("Sửa thành công");
                        AnHien(false);
                        KhoaCN(true);
                        btnSua.Text = "Sửa";
                    }
                    else
                    {
                        MessageBox.Show("Nhập sai giá dịch vụ", "Lỗi");
                        txtGiaDichVu.Text = "";
                        txtGiaDichVu.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Không có dịch vụ trong danh sách", "Thông báo");
                    AnHien(false);
                    KhoaCN(true);
                    btnSua.Text = "Sửa";
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dataGridViewDichVu.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa?",
                    "Xóa dịch vụ",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                    );
                if(result == DialogResult.OK)
                {
                    List<SDDV> dsSDDV = db.SDDVs.Where(record => record.MaDV == txtMaDichVu.Text.Trim()).ToList();
                    if(dsSDDV != null)
                    {
                        db.SDDVs.DeleteAllOnSubmit(dsSDDV);
                        db.SubmitChanges();
                    }

                    DichVu dichVu = db.DichVus.SingleOrDefault(record => record.MaDV == txtMaDichVu.Text);
                    if(dichVu != null)
                    {
                        db.DichVus.DeleteOnSubmit(dichVu); 
                        db.SubmitChanges();
                        MessageBox.Show("Xóa dịch vụ thành công!");
                        DichVubindingSource.RemoveCurrent();
                        dataGridViewDichVu.Refresh();
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có dịch vụ trong danh sách", "Thông báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
