using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Newtonsoft.Json;
using AppFoodApi.Database;
using OrderFoodAPI.Models;

namespace OrderFoodAPI.Controllers
{
    public class BillController : ApiController
    {
        [Route("api/BillController/GetHoaDonByUser")]
        [HttpGet]
        public IHttpActionResult GetHoaDonByUser(int mand)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("mand", mand);
                DataTable result = Database.ReadTable("GetHoaDonByUser", param);
                return Ok(result);
            }
            catch
            {
                return NotFound();

            }
        }

        [Route("api/BillController/GetCTHDByUser")]
        [HttpGet]
        public IHttpActionResult GetCTHDByUser(int mand)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("mand", mand);
                DataTable result = Database.ReadTable("GetCTHDByUser", param);
                return Ok(result);
            }
            catch
            {
                return NotFound();

            }
        }

        [Route("api/BillController/InsertHoaDon")]
        [HttpPost]

        public IHttpActionResult InsertHoaDon(Bill bill)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("mand", bill.MAND);
                param.Add("tongtien", bill.TONGTIEN);
                param.Add("tgdat", bill.TGDAT);
                param.Add("tggiao", bill.TGGIAO);
                int kq = int.Parse(Database.Exec_Command("InsertHoaDon", param).ToString());
                return Ok(kq);
            }
            catch
            {
                return NotFound();

            }
        }

        [Route("api/BillController/InsertCTHoaDon")]
        [HttpPost]

        public IHttpActionResult InsertCTHoaDon(BillDetail billDetail)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("mahd", billDetail.MAHD);
                param.Add("mama", billDetail.MAMA);
                param.Add("soluong", billDetail.SOLUONG);
                param.Add("ship", billDetail.SHIP);
                int kq = int.Parse(Database.Exec_Command("InsertCTHoaDon", param).ToString());
                return Ok(kq);
            }
            catch
            {
                return NotFound();

            }
        }
    }
}