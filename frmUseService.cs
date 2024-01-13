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
    public partial class frmUseService : Form
    {
        LinqToQLKSDataContext db;
        public frmUseService()
        {
            InitializeComponent();
        }

        private void ShowDichVu()
        {
            List<DichVu> dichVus = db.DichVus.ToList();
            DichVubindingSource.DataSource = dichVus;
        }

        private void ShowTreeView()
        {
            tvKhachHang.Nodes.Clear();
            List<Khach> khaches = db.Khaches.ToList();
            for(int i = 0; i < khaches.Count; i++)
            {
                tvKhachHang.Nodes.Add(khaches[i].CMT, khaches[i].HoTen);
                string cmt = khaches[i].CMT;
                List<ThuePhong> thuePhongs = db.ThuePhongs.Where(record => record.CMT == cmt && record.NgayDi == null).ToList();
                for(int j = 0; j < thuePhongs.Count; j++)
                {
                    Phong phong = db.Phongs.FirstOrDefault(record => record.MaPhong == thuePhongs[j].MaPhong);
                    if (phong != null)
                    {
                        tvKhachHang.Nodes[i].Nodes.Add(phong.MaPhong, phong.TenPhong);
                    }
                }
            }
        }

        private void frmUseService_Load(object sender, EventArgs e)
        {
            db = new LinqToQLKSDataContext(SQLHelper.ConnectString);
            ShowTreeView();
            ShowDichVu();
            dataGridViewDichVu.AutoGenerateColumns = false;
            dataGridViewSDDV.AutoGenerateColumns = false;
        }

        private void ShowTheoKH()
        {
            List<SDDV> dsSDDV = db.SDDVs.Where(record => record.CMT == tvKhachHang.SelectedNode.Name).ToList();
            SDDVbindingSource.DataSource = dsSDDV;
        }

        private void ShowTheoPhong()
        {
            List<SDDV> dsSDDV = db.SDDVs.Where(record => record.CMT == tvKhachHang.SelectedNode.Parent.Name
            && record.MaPhong == tvKhachHang.SelectedNode.Name).ToList();
            SDDVbindingSource.DataSource = dsSDDV;
        }

        private void tvKhachHang_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(tvKhachHang.SelectedNode.Level == 0)
            {
                ShowTheoKH();
            }
            else
            {
                ShowTheoPhong();
            }
        }

        private void KhoaCN(bool value)
        {
            btnSua.Enabled = value;
            btnThem.Enabled = value;
            btnXoa.Enabled = value;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(tvKhachHang.SelectedNode.Level == 0)
            {
                MessageBox.Show("Bạn phải chọn phòng muốn thêm dịch vụ", "Thông báo");
            }
            else
            {
                if(btnThem.Text == "Thêm")
                {
                    dataGridViewDichVu.Enabled = false;
                    btnThem.Text = "Lưu lại";
                    SDDV sDDV = db.SDDVs.SingleOrDefault(record => record.CMT == tvKhachHang.SelectedNode.Parent.Name
                    && record.MaDV == dataGridViewDichVu.CurrentRow.Cells[0].Value.ToString()
                    && record.MaPhong == tvKhachHang.SelectedNode.Name);
                    if(sDDV == null)
                    {
                        KhoaCN(false);
                        btnThem.Enabled = true;
                        SDDVbindingSource.AddNew();
                        dataGridViewSDDV.BeginEdit(false);
                        string input = "";
                        while (Function.KiemTraSoLuong(input) == false)
                        {
                            input = Microsoft.VisualBasic.Interaction.InputBox("Nhập vào số lượng dịch vụ (phải là số nguyên dương)", "Số lượng");
                        }
                        try
                        {
                            dataGridViewSDDV.CurrentRow.Cells[3].Value = int.Parse(input);
                            dataGridViewSDDV.CurrentRow.Cells[1].Value = tvKhachHang.SelectedNode.Name.ToString();
                            dataGridViewSDDV.CurrentRow.Cells[2].Value = dataGridViewDichVu.CurrentRow.Cells[0].Value.ToString();
                            dataGridViewSDDV.CurrentRow.Cells[4].Value = DateTime.Now.Date;
                            dataGridViewSDDV.CurrentRow.Cells[5].Value = tvKhachHang.SelectedNode.Name.ToString();
                        }
                        catch
                        {
                            MessageBox.Show("Bạn chưa chọn dịch vụ", "Lỗi");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dịch vụ này đã sử dụng trước đó. Vui lòng chọn sửa để thêm số lượng");
                        btnThem.Text = "Thêm";
                        KhoaCN(true);
                    }
                    
                }
                else
                {
                    dataGridViewDichVu.Enabled = true;
                    try
                    {
                        SDDVbindingSource.EndEdit();
                        SDDV sDDV = new SDDV();
                        sDDV.CMT = tvKhachHang.SelectedNode.Parent.Name.ToString();
                        sDDV.MaDV = dataGridViewDichVu.CurrentRow.Cells[0].Value.ToString();
                        sDDV.MaPhong = tvKhachHang.SelectedNode.Name.ToString();
                        sDDV.NgaySD = DateTime.Now.Date;
                        sDDV.SoLuong = int.Parse(dataGridViewSDDV.CurrentRow.Cells[3].Value.ToString());
                        db.SDDVs.InsertOnSubmit(sDDV);
                        db.SubmitChanges();
                        SDDVbindingSource.ResetBindings(false);
                        MessageBox.Show("Sử dụng dịch vụ mới thành công", "Sử dụng dịch vụ");
                    }
                    catch
                    {
                        MessageBox.Show("Xảy ra lỗi thêm dịch vụ", "Lỗi");
                    }
                    btnThem.Text = "Thêm";
                    KhoaCN(true);
                    ShowTheoPhong();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dịch vụ trong Danh sách sử dụng?",
                "Xóa dịch vụ",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                if(dataGridViewSDDV.SelectedRows.Count > 0)
                {
                    DataGridViewRow currentRow = dataGridViewSDDV.CurrentRow;
                    if (!Function.IsEmptyRow(currentRow))
                    {
                        try
                        {
                            SDDV sDDV = db.SDDVs.SingleOrDefault(record => record.MaHDDV == int.Parse(currentRow.Cells[0].Value.ToString()));
                            if (sDDV != null)
                            {
                                db.SDDVs.DeleteOnSubmit(sDDV);
                                db.SubmitChanges();
                                SDDVbindingSource.RemoveCurrent();
                                MessageBox.Show("Xóa thành công!", "Xóa");
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Xóa dịch vụ thất bại: " + ex.Message);
                        }
                    }
                }
                
            }
        }

        bool suaSL = false;
        string inputSL = "";
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!suaSL)
            {
                while (Function.KiemTraSoLuong(inputSL) == false)
                {
                    inputSL = Microsoft.VisualBasic.Interaction.InputBox("Nhập vào số lượng dịch vụ (phải là số nguyên dương)", "Số lượng");
                }
            }
            if (btnSua.Text == "Sửa")
            {
                btnSua.Text = "Lưu lại";
                KhoaCN(false);
                btnSua.Enabled = true;
                suaSL = true;
            }
            else
            {
                if(dataGridViewSDDV.SelectedRows.Count > 0)
                {
                    DataGridViewRow currentRow = dataGridViewSDDV.CurrentRow;
                    if (!Function.IsEmptyRow(currentRow))
                    {
                        try
                        {
                            SDDV sDDV = db.SDDVs.SingleOrDefault(record => record.MaHDDV == int.Parse(currentRow.Cells[0].Value.ToString()));
                            sDDV.SoLuong = int.Parse(inputSL);
                            db.SubmitChanges();
                            MessageBox.Show("Sửa thành công!", "Sửa");
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Sửa thất bại: " + ex.Message);
                        }
                        finally
                        {
                            btnSua.Text = "Sửa";
                            suaSL = false;
                            inputSL = "";
                            KhoaCN(true);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Chưa chọn dịch vụ trong danh sách sử dụng",
                                   "Lỗi",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
