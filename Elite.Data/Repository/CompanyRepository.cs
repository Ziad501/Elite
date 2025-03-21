using Elite.Data.Data;
using Elite.Data.Repository.IRepository;
using Elite.Models;

namespace Elite.Data.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private readonly ApplicationDbContext _context;
        public CompanyRepository(ApplicationDbContext context) :base(context)
        {
            _context = context;   
        }

        public void Update(Company com)
        {
            _context.Companies.Update(com);
        }
    }
}
