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
            _context.Products.Update(pro);
        }
    }
}
