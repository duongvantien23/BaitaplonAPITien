using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public partial interface IPhanLoaiSPBusiness
    {
        PhanLoaiSPModel GetPhanLoaiSPByID(string id);
        bool Create(PhanLoaiSPModel model);
        bool Update(PhanLoaiSPModel model);
        bool Delete(int id);
    }
}
