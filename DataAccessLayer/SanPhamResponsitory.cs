using DataAccessLayer.Interfaces;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public partial class SanPhamResponsitory : ISanPhamResponsitory
    {
        private IDatabaseHelper _dbHelper;

        public SanPhamResponsitory(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }
        public SanPhamModel GetSanPhamByID(string id)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_get_SanPhamBy_ID",
                     "@MaSanPham", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<SanPhamModel>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Create(SanPhamModel model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_create_sp",
                    "@MaDanhMuc", model.MaDanhMuc,
                    "@TenSanPham", model.TenSanPham,
                    "@AnhDaiDien", model.AnhDaiDien,
                    "@Gia", model.Gia,
                    "@GiaGiam", model.GiaGiam,
                    "@SoLuong", model.SoLuong,
                    "@TrangThai", model.TrangThai,
                    "@LuotXem", model.LuotXem,
                    "@DacBiet", model.DacBiet,
                    "@list_json_chitiet_sanpham", model.list_json_chitiet_sp != null ? MessageConvert.SerializeObject(model.list_json_chitiet_sp) : null,
                    "@list_json_sanpham_nhacc", model.list_json_sp_ncc != null ? MessageConvert.SerializeObject(model.list_json_sp_ncc) : null);
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool Update(SanPhamModel model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_update_sp",
                    "@MaSanPham", model.@MaSanPham,
                    "@MaDanhMuc", model.MaDanhMuc,
                    "@TenSanPham", model.TenSanPham,
                    "@AnhDaiDien", model.AnhDaiDien,
                    "@Gia", model.Gia,
                    "@GiaGiam", model.GiaGiam,
                    "@SoLuong", model.SoLuong,
                    "@TrangThai", model.TrangThai,
                    "@LuotXem", model.LuotXem,
                    "@DacBiet", model.DacBiet,
                    "@list_json_chitiet_sanpham", model.list_json_chitiet_sp != null ? MessageConvert.SerializeObject(model.list_json_chitiet_sp) : null,
                    "@list_json_sanpham_nhaphanphoi", model.list_json_sp_ncc != null ? MessageConvert.SerializeObject(model.list_json_sp_ncc) : null);
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<SanPhamModel> Search(int pageIndex, int pageSize, out long total, string TenSanPham)
        {
            string msgError = "";
            total = 0;
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_sanpham_search",
                    "@page_index", pageIndex,
                    "@page_size", pageSize,
                    "@TenSanPham", TenSanPham);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                if (dt.Rows.Count > 0) total = (long)dt.Rows[0]["RecordCount"];
                return dt.ConvertTo<SanPhamModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
