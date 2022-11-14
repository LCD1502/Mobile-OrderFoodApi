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

namespace OrderFoodAPI.Controllers
{
    public class FoodController : ApiController
    {
        [Route("api/FoodController/GetAllMonAn")]
        [HttpGet]

        public IHttpActionResult GetAllMonAn()
        {
            try
            {
                DataTable result = Database.ReadTable("GetAllMonAn");
                return Ok(result);
            }
            catch
            {
                return NotFound();

            }
        }

        [Route("api/FoodController/GetOneMonAn")]
        [HttpGet]
        public IHttpActionResult GetOneMonAn(int mama)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("mama", mama);
                DataTable result = Database.ReadTable("GetOneMonAn", param);
                return Ok(result);
            }
            catch
            {
                return NotFound();

            }
        }

        [Route("api/FoodController/GetMonAnNhaHang")]
        [HttpGet]

        public IHttpActionResult GetMonAnNhaHang(int manh)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("manh", manh);
                DataTable result = Database.ReadTable("GetMonAnByNhaHang", param);
                return Ok(result);
            }
            catch
            {
                return NotFound();

            }
        }
    }
}