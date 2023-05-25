using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSatış
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (StokTakipContext stok = new StokTakipContext())
            {
                return stok.Products.ToList();
            }
        }
        public void Add(Product product)
        {
            using(StokTakipContext context = new StokTakipContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
        public void Update(Product product)
        {
            using (StokTakipContext context = new StokTakipContext())
            {
                var entity = context.Entry(product);
                entity.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
