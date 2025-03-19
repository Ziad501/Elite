using Elite.Models;

namespace Elite.Data.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product pro);

    }
}
