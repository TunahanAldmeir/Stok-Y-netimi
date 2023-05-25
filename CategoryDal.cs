using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSatış
{
    public class CategoryDal
    {
        public List<Category> GetAll()
        {
            using (StokTakipContext stok = new StokTakipContext())
            {
                return stok.Categories.ToList();
            }
        }
        public void Add(Category category)
        {
            using(StokTakipContext context = new StokTakipContext())
            {
                context.Categories.Add(category);
                context.SaveChanges();
            }
        }
    }
}
