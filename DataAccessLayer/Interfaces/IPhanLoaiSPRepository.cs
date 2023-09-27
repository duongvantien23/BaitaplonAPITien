﻿using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
     public partial interface IPhanLoaiSPRepository
    {
        PhanLoaiSPModel GetPhanLoaiSPByID(string id);
        bool Create(PhanLoaiSPModel model);
        bool Update(PhanLoaiSPModel model);
        bool Delete(int MaPhanLoai);
    }
}
