using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSatış
{
    public class Costumer
    {
        [Key]
        public string tc { get; set; }
        public string adsoyad { get; set; }
        public string tel { get; set; }
        public string adres { get; set; }
        public string email { get; set; }

    }
}
