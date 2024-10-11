using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuongDinhHoang_Bai2
{
    internal class NhanVien
    {
        protected static int autoID = 0;
        public string Ten { get; set; }
        public string MaID { get; set; }
        public long LuongCoBan { get; set; }
        public long LuongThucLanh { get; set; }

        public NhanVien () { }
        public NhanVien(string id)
        {
            MaID = id == null ? $"EMP{++autoID}" : id;
        }

        public NhanVien(string ten, string id, long luong):this(id)
        {
            Ten = ten;
            LuongCoBan = luong; 
        }

        public virtual long TinhLuong()
        {
            LuongThucLanh = LuongCoBan;
            return LuongThucLanh;
        }
    }

    internal class QuanLy:NhanVien
    {
        public string ChucVu { get; set; }
        public float PhanTramHoaHong { get; set; }

        public QuanLy() { }
        public QuanLy(string ten, string id, long luong, string chucvu, float phantram) :base(ten, id, luong) 
        {
            ChucVu = chucvu;
            PhanTramHoaHong = phantram;
        }

        public override long TinhLuong()
        {
            var baseLuong = base.TinhLuong();
            return LuongThucLanh = baseLuong + (long)(baseLuong * PhanTramHoaHong); 
        }
    }
}
