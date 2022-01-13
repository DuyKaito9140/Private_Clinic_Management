using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPMT
{
    class Content
    {
        public static string CMaBN = "";
        public static string CHoTen = "";
        public static string CMaThuoc = ""; 
        public static string CSoLuongConTrongKho = "";

        //phiếu khám bệnh
        public static string CMaPhieu = "";
        public static string CTrieuChung = "";
        public static string CLoaiBenh = "";
        public static string CThuoc = "";
        public static string Csoluongdung = "";
        public static string CCachDung = "";
        public static string CNgayKham = "";
        public static string CGioKham = "";

        public static string trangthai = "";

        //hoa don
        public static string HMaBN = "";
        public static string HHoTen = "";
        public static string HTenThuoc = "";
        public static string HGiaThuoc = "";
        public static string HLuongDung = "";

        //tra ve sau khi nhap hoa don
        public static string _MaBN = "";
        public static string _MaHD = "";
        public static string _TienThuoc = "";
        public static string _TienKham = "";

        //Lich
        public static string LMaBN = "";
        public static string LHoTenBN = "";
        public static string LSdt = "";
        public static string Ltrangthai = "";
        

        //KT có phải số ko
        public static bool IsNumber(char pValue)
        {
            if (!Char.IsDigit(pValue))
                    return false;
            return true;
        }
        //tk
        public static string dbeuser = "admin";
        public static string dbepas = "12345";
        //Doanh Thu
        public static string DMaBCDT = "";
        public static string DThangBC = "";
        public static string DNamBC = "";
        public static string DSoBN = "";
        public static string DTongDT = "";
        public static string feel = "";
        public static string suaMaBc = "";

        //Báo cáo thuốc
        public static string BCMaBCTh = "";
        public static string BCThang = "";
        public static string BCNam = "";
        public static string BCSoLuongThuocDung = "";
        public static string uptrangthai = "";

        //Lấy Day || Month || Year
        public static int IsDay(string ngay)
        {
            string[] temp = ngay.Split();
            string[] words = temp[0].Split('/');
            return int.Parse(words[1]);
        }
        public static int IsMonth(string thang)
        {
            string[] temp = thang.Split();
            string[] words = temp[0].Split('/');
            return int.Parse(words[0]);
        }
        public static int IsYear(string nam)
        {
            string[] temp = nam.Split();
            string[] words = temp[0].Split('/');
            return int.Parse(words[2]);
        }
        //tk
        public static string TKten = "";
        public static string TKQuyen = "Admin";
    }
}
