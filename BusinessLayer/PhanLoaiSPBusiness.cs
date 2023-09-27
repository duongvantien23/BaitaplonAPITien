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
    public partial class PhanLoaiSPBusiness : IPhanLoaiSPBusiness
    {
        private IPhanLoaiSPRepository _res;
        public PhanLoaiSPBusiness (IPhanLoaiSPRepository res)
        {
            _res = res;
        }
        public PhanLoaiSPModel GetPhanLoaiSPByID(string id)
        {
            return _res.GetPhanLoaiSPByID(id);
        }
        public bool Create(PhanLoaiSPModel model)
        {
            return _res.Create(model);
        }

        public bool Update(PhanLoaiSPModel model)
        {
            return _res.Update(model);
        }

        public bool Delete(int id)
        {
            return _res.Delete(id);
        }
    }
}
