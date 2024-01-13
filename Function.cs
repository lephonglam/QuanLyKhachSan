using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public class Function
    {
        public static bool KiemTraCMND(string cmt)
        {
            int cmnd;
            if (int.TryParse(cmt, out cmnd) == true && cmt.Length == 9)
            {
                return true;
            }
            return false;
        }

        public static bool KiemTraSDT(string sdt)
        {
            int soDienThoai;
            Regex reg = new Regex("\\d{10}");
            if (reg.IsMatch(sdt))
            {
                return true;
            }
            return false;
        }

        public static bool KiemTraGia(string giaPhong)
        {
            int gia;
            if(int.TryParse(giaPhong,out gia)  == true)
            {
                return true;
            }
            return false;
        }

        public static bool KiemTraSoLuong(string sl)
        {
            int soluong;
            if(int.TryParse(sl, out soluong) == true)
            {
                return true;
            }
            return false;
        }

        public static bool KiemTraLoaiNguoiDung(string value)
        {
            int loai;
            if(int.TryParse(value, out loai) == true && loai > 0 && loai < 3)
            {
                return true;
            }
            return false;
        }

        //private bool IsEmptyRow(DataGridViewRow row)
        //{
        //    if (row.Cells[0].Value != null) return false;
        //    else return true;
        //}

        public static bool IsEmptyRow(DataGridViewRow row)
        {
            foreach (DataGridViewCell cell in row.Cells)
            {
                if (cell.Value != null && cell.Value is string && !string.IsNullOrEmpty(cell.Value.ToString()))
                {
                    return false;
                }
                if(cell.Value != null && cell.Value is int && (int)cell.Value != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
