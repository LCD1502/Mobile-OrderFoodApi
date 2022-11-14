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
    public class RestaurantController : ApiController
    {
        [Route("api/RestaurantController/GetNhaHang")] // oke
        [HttpGet]

        public IHttpActionResult GetNhaHang()
        {
            try
            {
                DataTable result = Database.ReadTable("GetAllNhaHang");
                return Ok(result);
            }
            catch
            {
                return NotFound();

            }
        }
        
    }
}