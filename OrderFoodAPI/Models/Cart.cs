using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderFoodAPI.Models
{
    public class Cart
    {
        public int MAGH { get; set; }
        public int MAND { get; set; }
        public int MAMA { get; set; }
        public float SOLUONG { get; set; }
        public float DONGIA { get; set; }
        public float TONGGIA { get; set; }
        public string IMG { get; set; }
        public string TEN { get; set; }
        public int MANH { get; set; }
        public string TENNH { get; set; }
    }
}