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
    public class CartController : ApiController
    {
        [Route("api/CartController/GetGioHang")]
        [HttpGet]
        public IHttpActionResult GetGioHang(int mand)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("mand", mand);
                DataTable result = Database.ReadTable("GetGioHang", param);
                return Ok(result);
            }
            catch
            {
                return NotFound();

            }
        }

        [Route("api/CartController/DeleteAllGioHang")]
        [HttpGet]
        public IHttpActionResult DeleteAllGioHang(int mand)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("mand", mand);
                DataTable result = Database.ReadTable("DeleteAllGioHang", param);
                return Ok(result);
            }
            catch
            {
                return NotFound();

            }
        }

        [Route("api/CartController/GetCartFood")]
        [HttpGet]
        public IHttpActionResult GetCartFood(int mand)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("mand", mand);
                DataTable result = Database.ReadTable("GetCartFood", param);
                return Ok(result);
            }
            catch
            {
                return NotFound();

            }
        }

        [Route("api/CartController/InsertGioHang")]
        [HttpPost]

        public IHttpActionResult InsertGioHang(Cart cart)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("mand", cart.MAND);
                param.Add("mama", cart.MAMA);
                int kq = int.Parse(Database.Exec_Command("InsertGioHang", param).ToString());
                return Ok(kq);
            }
            catch
            {
                return NotFound();

            }
        }

        [Route("api/CartController/DeleteGioHang")]
        [HttpPost]

        public IHttpActionResult DeleteGioHang(Cart cart)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("mand", cart.MAND);
                param.Add("mama", cart.MAMA);
                int kq = int.Parse(Database.Exec_Command("DeleteGioHang", param).ToString());
                return Ok(kq);
            }
            catch
            {
                return NotFound();

            }
        }

    }
}