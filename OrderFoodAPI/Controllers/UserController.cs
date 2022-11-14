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
    public class UserController : ApiController
    {
        [Route("api/UserController/CreateUser")]
        [HttpPost]

        public IHttpActionResult CreateUser(User user)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("username", user.USERNAME);
                param.Add("pw", user.PASS);
                param.Add("hoten", user.HOTEN);
                param.Add("sdt", user.SDT);
                param.Add("email", user.EMAIL);
                param.Add("ngaysinh", user.NGAYSINH);
                int kq = int.Parse(Database.Exec_Command("CreateUser", param).ToString());
                return Ok(kq);
            }
            catch
            {
                return NotFound();

            }
        }

        [Route("api/UserController/CheckOneUser")]
        [HttpPost]

        public IHttpActionResult CheckOneUser(User user)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("username", user.USERNAME);
                param.Add("pw", user.PASS);
                DataTable result = Database.ReadTable("CheckOneUser", param);
                return Ok(result);
            }
            catch
            {
                return NotFound();

            }
        }
    }
}