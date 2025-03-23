﻿using Elite.Data.Data;
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
        public ICompanyRepository company { get; private set; }
        public IShoppingCartRepository shoppingCart { get; private set; }
        public IApplicationUserRepository ApplicationUser { get; private set; }

        public UnitOfwork(ApplicationDbContext db) 
        {
            _db = db;
            category = new CategoryRepository(_db);
            product = new ProductRepository(_db);
            company = new CompanyRepository(_db);
            shoppingCart = new ShoppingCartRepository(_db);
            ApplicationUser = new ApplicationUserRepository(_db);
        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
