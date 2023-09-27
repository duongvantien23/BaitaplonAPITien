using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public partial interface IKhachHangBusiness
    {
        bool Create(KhachHangModel model);
        bool Update(KhachHangModel model);
        KhachHangModel GetDatabyID(string id);
        List<KhachHangModel> GetDataAll();
        bool Delete(int id);

        List<KhachHangModel> Search(int pageIndex, int pageSize, out long total, string tenkh, string diachi);
    }
}
