using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public partial interface IHoaDonBusiness
    {
        HoaDonModel GetDatabyID(int id);
        public bool Create(HoaDonModel model);
        public bool Update(HoaDonModel model);
        List<HoaDonModel> Search(int pageIndex, int pageSize, out long total, string TenKH, DateTime? fr_NgayTao, DateTime? to_NgayTao);

    }
}

