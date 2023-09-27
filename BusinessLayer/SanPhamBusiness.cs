using BusinessLayer.Interfaces;
using DataAccessLayer.Interfaces;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public partial class SanPhamBusiness : ISanPhamBusiness
    {
        public ISanPhamResponsitory _res;

        public SanPhamBusiness(ISanPhamResponsitory sanPhamResponsitory)
        {
            _res = sanPhamResponsitory;
        }
        public SanPhamModel GetSanPhamByID(string id)
        {
            return _res.GetSanPhamByID(id);
        }
        public bool Create(SanPhamModel model)
        {
            return _res.Create(model);
        }

        public bool Update(SanPhamModel model)
        {
            return _res.Update(model);
        }

        public List<SanPhamModel> Search(int pageIndex, int pageSize, out long total, string TenSanPham)
        {
            return _res.Search(pageIndex, pageSize, out total, TenSanPham);
        }
    }
}
    


    

