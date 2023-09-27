using BusinessLayer.Interfaces;
using DataModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BTL_VinfoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhaCungCapController : ControllerBase
    {
        private INhaCungCapBusiness _nhaCungCapBus;

        public NhaCungCapController(INhaCungCapBusiness nhaCungCapBus)
        {
            _nhaCungCapBus = nhaCungCapBus;
        }

        [Route("get-all-nhacungcap")]
        [HttpGet]
        public IEnumerable<NhaCungCapModel> GetDataAll()
        {
            return _nhaCungCapBus.GetNhaCungCaps();
        }

        [Route("create-nhacungcap")]
        [HttpPost]
        public bool Create(NhaCungCapModel model)
        {
            return _nhaCungCapBus.Create(model);
        }

        [Route("update-nhacungcap")]
        [HttpPut]
        public bool Update(NhaCungCapModel model)
        {
            return _nhaCungCapBus.Update(model);
        }

        [Route("delete-nhacungcap")]
        [HttpDelete]
        public bool Delete(int MaNhaCC)
        {
            return _nhaCungCapBus.Delete(MaNhaCC);
        }
    }
}
