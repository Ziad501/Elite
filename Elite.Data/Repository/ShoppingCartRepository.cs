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
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
        private readonly ApplicationDbContext _context;
        public ShoppingCartRepository(ApplicationDbContext context) :base(context)
        {
            _context = context;   
        }

        public void Update(ShoppingCart cart)
        {
            _context.ShoppingCarts.Update(cart);
        }

    }
}
