using DataAccessLayer.Interfaces;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class HoaDonRepository : IHoaDonRepository
    {
        private IDatabaseHelper _dbHelper;
        public HoaDonRepository(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }
        public HoaDonModel GetDatabyID(int id)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_hoadon_get_by_id",
                     "@MaHoaDon", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<HoaDonModel>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Create(HoaDonModel model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_create_hoadon",
                    "@TrangThai", model.TrangThai,
                    "@NgayTao", model.NgayTao,
                    "@NgayDuyet", model.NgayDuyet,
                    "@TongGia", model.TongGia,
                    "@TenKH", model.TenKH,
                    "@GioiTinh", model.GioiTinh,
                    "@Diachi", model.Diachi,
                    "@Email", model.Email,
                    "@SDT", model.SDT,
                    "@DiaChiGiaoHang", model.DiaChiGiaoHang,
                    "@ThoiGianGiaoHang", model.ThoiGianGiaoHang,
                    "@list_json_chitiet_hoadon", model.list_json_chitiet_hoadon != null ? MessageConvert.SerializeObject(model.list_json_chitiet_hoadon) : null);
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
        public bool Update(HoaDonModel model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_update_hoadon",
                    "@MaHoaDon", model.MaHoaDon,
                    "@TrangThai", model.TrangThai,
                    "@NgayTao", model.NgayTao,
                    "@NgayDuyet", model.NgayDuyet,
                    "@TongGia", model.TongGia,
                    "@TenKH", model.TenKH,
                    "@GioiTinh", model.GioiTinh,
                    "@Diachi", model.Diachi,
                    "@Email", model.Email,
                    "@SDT", model.SDT,
                    "@DiaChiGiaoHang", model.DiaChiGiaoHang,
                    "@ThoiGianGiaoHang", model.ThoiGianGiaoHang,
                    "@list_json_chitiet_hoadon", model.list_json_chitiet_hoadon != null ? MessageConvert.SerializeObject(model.list_json_chitiet_hoadon) : null);
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

        public List<HoaDonModel> Search(int pageIndex, int pageSize, out long total, string TenKH, DateTime? fr_NgayTao, DateTime? to_NgayTao)
        {
            string msgError = "";
            total = 0;
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_Thongkekhach_hoadon_search",
                    "@page_index", pageIndex,
                    "@page_size", pageSize,
                    "@TenKH", TenKH,
                    "@fr_ngaytao", fr_NgayTao,
                    "@to_ngaytao", to_NgayTao);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                if (dt.Rows.Count > 0) total = (long)dt.Rows[0]["RecordCount"];
                return dt.ConvertTo<HoaDonModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

