using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderFoodAPI.Models
{
    public class BillDetail
    {
        public int MAHD { get; set; }
        public int MAMA { get; set; }
        public int SOLUONG { get; set; }
        public float SHIP { get; set; }
    }
}