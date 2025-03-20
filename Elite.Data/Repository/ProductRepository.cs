using Elite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elite.Data.Repository.IRepository;
using Elite.Data.Data;

namespace Elite.Data.Repository
{
    public class ProductRepository : Repository<Product>,IProductRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context) :base(context)
        {
            _context = context;   
        }

        public void Update(Product pro)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == pro.Id);
            if (product != null)
            {
                if (pro.ImageUrl != null)
                {
                    product.ImageUrl = pro.ImageUrl;
                }
                product.ProductName = pro.ProductName;
                product.Description = pro.Description;
                product.Brand = pro.Brand;
                product.Price = pro.Price;
                product.Price50 = pro.Price50;
                product.Price100 = pro.Price100;
                product.CategoryId = pro.CategoryId;
            }
        }
    }
}
