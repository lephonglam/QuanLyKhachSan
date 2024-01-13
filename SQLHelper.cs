using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    public static class SQLHelper
    {
        //private static string tenTK;
        //private static string matKhau;
        //private static int loaiTK;
        //private static string cMT;
        //private static string maPhong;
        //private static string maDV;
        //private static string maHD;
        private static List<int> dsMaHD;
        private static List<string> dsMaPhong;
        private static string connectString = System.Configuration.ConfigurationManager
            .ConnectionStrings["QuanLyKhachSan.Properties.Settings.QuanLyKhachSanConnectionString"].ToString();

        public static string TenTK { get; set; }
        public static string MatKhau {  get; set; }
        public static int LoaiTK {  get; set; }
        public static string CMT {  get; set; }
        public static string MaPhong {  get; set; }
        public static string MaDV { get; set; }
        public static string MaHD { get; set; }
        public static List<int> DsMaHD { get
            {
                if(dsMaHD == null)
                {
                    dsMaHD = new List<int>();
                }
                return dsMaHD;
            } }
        public static List<string> DsMaPhong { get
            {
                if(dsMaPhong == null)
                {
                    dsMaPhong = new List<string>();
                }
                return dsMaPhong;
            } }
        public static string ConnectString {  get { return connectString; } }
    }
}
