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
    public class CategoryRepository : Repository<Category>,ICategoryRepository
    {
        private readonly ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context) :base(context)
        {
            _context = context;   
        }

        public void Update(Category cat)
        {
            _context.Categories.Update(cat);
        }
    }
}
