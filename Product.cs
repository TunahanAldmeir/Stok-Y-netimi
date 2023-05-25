using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSatış
{
    public class Product
    {
        [Key]
        public int BarkodNo { get; set; }
        public string CategoryName { get; set; }
        public string BrandNmae { get; set; }
        public string ProductName { get; set; }
        public int Unit { get; set; }
        public decimal TakePrice { get; set; }
        public decimal SellPrice { get; set; }
    }
}
