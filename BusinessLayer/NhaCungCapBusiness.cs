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
    public partial class NhaCungCapBusiness : INhaCungCapBusiness
    {
        private INhaCungCapResponsitory _res;
        public NhaCungCapBusiness(INhaCungCapResponsitory res)
        {
            _res = res;
        }
        public List<NhaCungCapModel> GetNhaCungCaps()
        {
            return _res.GetNhaCungCaps();
        }

        public bool Create(NhaCungCapModel model)
        {
            return _res.Create(model);
        }

        public bool Update(NhaCungCapModel model)
        {
            return _res.Update(model);
        }

        public bool Delete(int MaNhaCC)
        {
            return _res.Delete(MaNhaCC);
        }
    }
}

