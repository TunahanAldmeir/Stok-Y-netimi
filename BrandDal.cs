using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSatış
{
    public class BrandDal
    {
        public void Add(Brand brand)
        {
            using (StokTakipContext context = new StokTakipContext())
            {
                context.Brands.Add(brand);
                context.SaveChanges();
            }
        }
    }
}
