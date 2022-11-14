using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderFoodAPI.Models
{
    public class Bill
    {
        public int MAND { get; set; }
        public float TONGTIEN { get; set; }
        public DateTime? TGDAT { get; set; }
        public DateTime? TGGIAO { get; set; }
    }
}