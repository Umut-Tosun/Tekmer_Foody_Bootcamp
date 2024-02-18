using FoodyTekmerEntityLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodyTekmerEntityLayer.Concrete
{
    public class Product : Main
    {
        public string ProductName { get; set; }
        public string ImageUrl { get; set; }
        public decimal OldPrice { get; set; }
        public decimal NewPrice { get; set; }
    }
}
