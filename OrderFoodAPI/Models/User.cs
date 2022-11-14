using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderFoodAPI.Models
{
    public class User
    {
        public int MAND { get; set; }
        public string USERNAME { get; set; }
        public string PASS { get; set; }
        public string HOTEN { get; set; }
        public string SDT { get; set; }
        public string EMAIL { get; set; }
        public DateTime? NGAYSINH { get; set; }
        public string AVATAR { get; set; }
    }
}