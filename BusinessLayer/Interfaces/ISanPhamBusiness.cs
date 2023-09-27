using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public partial interface ISanPhamBusiness
    {
        SanPhamModel GetSanPhamByID(string id);
        bool Create(SanPhamModel model);
        bool Update(SanPhamModel model);
        public List<SanPhamModel> Search(int pageIndex, int pageSize, out long total, string TenSanPham);
    }
}
