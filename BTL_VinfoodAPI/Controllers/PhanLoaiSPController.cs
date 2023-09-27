using BusinessLayer.Interfaces;
using DataModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BTL_VinfoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhanLoaiSPController : ControllerBase
    {
        private IPhanLoaiSPBusiness _phanLoaiSPBUS;

        public PhanLoaiSPController(IPhanLoaiSPBusiness phanLoaiSPBUS)
        {
            _phanLoaiSPBUS = phanLoaiSPBUS;
        }
        [Route("get-by-id/{id}")]
        [HttpGet]
        public PhanLoaiSPModel GetSanPhamByID(string id)
        {
            return _phanLoaiSPBUS.GetPhanLoaiSPByID(id);
        }

        [Route("create-plsanpham")]
        [HttpPost]
        public PhanLoaiSPModel CreatePhanLoaiSP([FromBody] PhanLoaiSPModel model)
        {
            _phanLoaiSPBUS.Create(model);
            return model;
        }

        [Route("update-plsanpham")]
        [HttpPut]
        public PhanLoaiSPModel UpdatePhanLoaiSP([FromBody] PhanLoaiSPModel model)
        {
            _phanLoaiSPBUS.Update(model);
            return model;
        }
        [Route("delete-plsanpham")]
        [HttpDelete]
        public bool Delete(int MaPhanLoai)
        {
            return _phanLoaiSPBUS.Delete(MaPhanLoai);
        }
    }
}
