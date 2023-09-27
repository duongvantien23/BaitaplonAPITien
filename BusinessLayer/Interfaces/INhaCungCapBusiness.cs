using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public partial interface INhaCungCapBusiness
    {
        List<NhaCungCapModel> GetNhaCungCaps();

        public bool Create(NhaCungCapModel model);
        public bool Update(NhaCungCapModel model);
        public bool Delete(int MaNhaCC);
    }
}

