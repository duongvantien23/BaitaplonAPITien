using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class SanPhamModel
    {
        public int MaSanPham { get; set; }
        public int MaDanhMuc { get; set; }
        public string TenSanPham { get; set; }
        public string AnhDaiDien { get; set; }
        public Decimal Gia { get; set; }
        public Decimal GiaGiam { get; set; }
        public int SoLuong { get; set; }
        public bool TrangThai { get; set; }
        public int LuotXem { get; set; }
        public bool DacBiet { get; set; }
        public List<ChiTietSPModel> list_json_chitiet_sp { get; set; }
        public List<SP_NhaCungCapModel> list_json_sp_ncc { get; set; }
    }
}
