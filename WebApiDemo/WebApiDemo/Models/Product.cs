using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDemo.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime AddingDate { get; set; }
        public int Numbers { get; set; }
    }
}