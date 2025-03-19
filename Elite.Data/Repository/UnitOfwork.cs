using Elite.Data.Data;
using Elite.Data.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elite.Data.Repository
{
    public class UnitOfwork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public IProductRepository product { get; private set; }
        public ICategoryRepository category { get; private set; }
        public UnitOfwork(ApplicationDbContext db) 
        {
            _db = db;
            category = new CategoryRepository(_db);
            product = new ProductRepository(_db);
        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
