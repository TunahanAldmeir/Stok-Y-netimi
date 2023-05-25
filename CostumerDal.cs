using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSatış
{
    public class CostumerDal
    {
        public List<Costumer> GetAll()
        {
            using (StokTakipContext stok = new StokTakipContext())
            {
                return stok.Costumers.ToList();
            }
        }
        public void Add(Costumer costumer)
        {
            using (StokTakipContext context = new StokTakipContext())
            {
                context.Costumers.Add(costumer);
                context.SaveChanges();
            }
        }
        public void Update(Costumer costumer)
        {
            using (StokTakipContext context = new StokTakipContext())
            {
                var entity = context.Entry(costumer);
                entity.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(Costumer costumer)
        {
            using (StokTakipContext context = new StokTakipContext())
            {
                var entity = context.Entry(costumer);
                entity.State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
